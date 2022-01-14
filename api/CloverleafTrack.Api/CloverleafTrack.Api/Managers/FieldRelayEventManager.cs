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
    public class FieldRelayEventManager
    {
        private readonly DatabaseOptions database;

        public FieldRelayEventManager(IOptions<DatabaseOptions> database)
        {
            this.database = database.Value;
        }

        public async Task<IEnumerable<FieldRelayEvent>> GetAllAsync()
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<FieldRelayEvent>("SELECT * FROM [FieldRelayEvents] fr WHERE fr.[Deleted] = 0 ORDER BY fr.[Gender] ASC, fr.[SortOrder] ASC");
        }

        public async Task<IEnumerable<FieldRelayEvent>> GetAllForGenderAsync(Gender gender)
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<FieldRelayEvent>("SELECT * FROM [FieldRelayEvents] fr WHERE fr.[Deleted] = 0 AND fr.[Gender] = @Gender ORDER BY fr.[SortOrder] ASC", new { Gender = gender });
        }

        public async Task CreateAsync(EventDto fieldRelayEvent)
        {
            if (!fieldRelayEvent.SortOrder.HasValue)
            {
                using (var connection = new SqlConnection(database.ConnectionString))
                {
                    var maxSortOrder = await connection.QueryFirstOrDefaultAsync<int?>("SELECT MAX(fr.[SortOrder]) FROM [FieldRelayEvents] fr WHERE fr.[Gender] = @Gender", new { Gender = fieldRelayEvent.Gender });
                    if (!maxSortOrder.HasValue)
                    {
                        fieldRelayEvent.SortOrder = 1;
                    }
                    else
                    {
                        fieldRelayEvent.SortOrder = maxSortOrder + 1;
                    }
                }
            }

            using (var connection = new SqlConnection(database.ConnectionString))
            {
                await connection.InsertAsync(new FieldRelayEvent { Name = fieldRelayEvent.Name, Gender = fieldRelayEvent.Gender, SortOrder = fieldRelayEvent.SortOrder.Value, DateCreated = DateTime.UtcNow });
            }
        }
    }
}
