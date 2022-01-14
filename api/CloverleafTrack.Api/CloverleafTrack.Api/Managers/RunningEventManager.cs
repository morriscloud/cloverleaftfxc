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
    public class RunningEventManager
    {
        private readonly DatabaseOptions database;

        public RunningEventManager(IOptions<DatabaseOptions> database)
        {
            this.database = database.Value;
        }

        public async Task<IEnumerable<RunningEvent>> GetAllAsync()
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<RunningEvent>("SELECT * FROM [RunningEvents] r WHERE r.[Deleted] = 0 ORDER BY r.[Gender] ASC, r.[SortOrder] ASC");
        }

        public async Task<IEnumerable<RunningEvent>> GetAllForGenderAsync(Gender gender)
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<RunningEvent>("SELECT * FROM [RunningEvents] r WHERE r.[Deleted] = 0 AND r.[Gender] = @Gender ORDER BY r.[SortOrder] ASC", new { Gender = gender });
        }

        public async Task CreateAsync(EventDto runningEvent)
        {
            if (!runningEvent.SortOrder.HasValue)
            {
                using (var connection = new SqlConnection(database.ConnectionString))
                {
                    var maxSortOrder = await connection.QueryFirstOrDefaultAsync<int?>("SELECT MAX(r.[SortOrder]) FROM [RunningEvents] r WHERE r.[Gender] = @Gender", new { Gender = runningEvent.Gender });
                    if (!maxSortOrder.HasValue)
                    {
                        runningEvent.SortOrder = 1;
                    }
                    else
                    {
                        runningEvent.SortOrder = maxSortOrder + 1;
                    }
                }
            }

            using (var connection = new SqlConnection(database.ConnectionString))
            {
                await connection.InsertAsync(new RunningEvent { Name = runningEvent.Name, Gender = runningEvent.Gender, SortOrder = runningEvent.SortOrder.Value, DateCreated = DateTime.UtcNow });
            }
        }
    }
}
