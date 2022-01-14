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
    public class RunningRelayEventManager
    {
        private readonly DatabaseOptions database;

        public RunningRelayEventManager(IOptions<DatabaseOptions> database)
        {
            this.database = database.Value;
        }

        public async Task<IEnumerable<RunningRelayEvent>> GetAllAsync()
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<RunningRelayEvent>("SELECT * FROM [RunningRelayEvents] rr WHERE rr.[Deleted] = 0 ORDER BY rr.[Gender] ASC, rr.[SortOrder] ASC");
        }

        public async Task<IEnumerable<RunningRelayEvent>> GetAllForGenderAsync(Gender gender)
        {
            using var connection = new SqlConnection(database.ConnectionString);
            return await connection.QueryAsync<RunningRelayEvent>("SELECT * FROM [RunningRelayEvents] rr WHERE rr.[Deleted] = 0 AND rr.[Gender] = @Gender ORDER BY rr.[SortOrder] ASC", new { Gender = gender });
        }

        public async Task CreateAsync(EventDto runningRelayEvent)
        {
            if (!runningRelayEvent.SortOrder.HasValue)
            {
                using (var connection = new SqlConnection(database.ConnectionString))
                {
                    var maxSortOrder = await connection.QueryFirstOrDefaultAsync<int?>("SELECT MAX(rr.[SortOrder]) FROM [RunningRelayEvents] rr WHERE rr.[Gender] = @Gender", new { Gender = runningRelayEvent.Gender });
                    if (!maxSortOrder.HasValue)
                    {
                        runningRelayEvent.SortOrder = 1;
                    }
                    else
                    {
                        runningRelayEvent.SortOrder = maxSortOrder + 1;
                    }
                }
            }

            using (var connection = new SqlConnection(database.ConnectionString))
            {
                await connection.InsertAsync(new FieldRelayEvent { Name = runningRelayEvent.Name, Gender = runningRelayEvent.Gender, SortOrder = runningRelayEvent.SortOrder.Value, DateCreated = DateTime.UtcNow });
            }
        }
    }
}
