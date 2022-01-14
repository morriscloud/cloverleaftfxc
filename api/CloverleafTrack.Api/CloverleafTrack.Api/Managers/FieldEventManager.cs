using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CloverleafTrack.Api.Dtos;
using CloverleafTrack.Api.Models;
using CloverleafTrack.Api.Models.TrackEvents;
using CloverleafTrack.Api.Options;

using Dapper;
using Dapper.Contrib.Extensions;

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace CloverleafTrack.Api.Managers
{
    public class FieldEventManager
    {
        private readonly DatabaseOptions database;

        public FieldEventManager(IOptions<DatabaseOptions> database)
        {
            this.database = database.Value;
        }

        public async Task<IEnumerable<FieldEvent>> GetAllAsync()
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<FieldEvent>("SELECT * FROM [FieldEvents] f WHERE f.[Deleted] = 0 ORDER BY f.[Gender] ASC, f.[SortOrder] ASC");
        }

        public async Task<IEnumerable<FieldEvent>> GetAllForGenderAsync(Gender gender)
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<FieldEvent>("SELECT * FROM [FieldEvents] f WHERE f.[Deleted] = 0 AND f.[Gender] = @Gender ORDER BY f.[SortOrder] ASC", new { Gender = gender });
        }

        public async Task CreateAsync(EventDto fieldEvent)
        {
            if (!fieldEvent.SortOrder.HasValue)
            {
                using (var connection = new SqlConnection(database.ConnectionString))
                {
                    var maxSortOrder = await connection.QueryFirstOrDefaultAsync<int?>("SELECT MAX(f.[SortOrder]) FROM [FieldEvents] f WHERE f.[Gender] = @Gender", new { Gender = fieldEvent.Gender });
                    if (!maxSortOrder.HasValue)
                    {
                        fieldEvent.SortOrder = 1;
                    }
                    else
                    {
                        fieldEvent.SortOrder = maxSortOrder + 1;
                    }
                }
            }

            using (var connection = new SqlConnection(database.ConnectionString))
            {
                await connection.InsertAsync(new FieldEvent { Name = fieldEvent.Name, Gender = fieldEvent.Gender, SortOrder = fieldEvent.SortOrder.Value, DateCreated = DateTime.UtcNow });
            }
        }
    }
}
