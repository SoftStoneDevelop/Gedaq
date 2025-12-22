using DotNet.Testcontainers.Containers;
using Microsoft.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Testcontainers.MsSql;

namespace Tests
{
    internal static class ContainerHelpers
    {
        /// <summary>
        /// Wait untill container start
        /// </summary>
        public static async ValueTask WaitContainerStateRunningAsync(this DockerContainer dockerContainer, TimeSpan timeout)
        {
            var sw = Stopwatch.StartNew();
            while (true)
            {
                if (dockerContainer.State == TestcontainersStates.Running)
                {
                    break;
                }

                if (sw.Elapsed >= timeout)
                {
                    throw new Exception($"Container start timeout ({timeout}) exceeded, benchmark stopped, current container state is {dockerContainer.State}.");
                }

                await Task.Delay(100);
            }
        }

        /// <summary>
        /// Wait until the container responds to at least one request
        /// </summary>
        public static async ValueTask WaitResponseAsync(this MsSqlContainer container, TimeSpan timeout)
        {
            var sw = Stopwatch.StartNew();
            while (true)
            {
                if (sw.Elapsed >= timeout)
                {
                    throw new Exception($"MsSQL has not responded to any queries in {timeout}. Container state {container.State}");
                }

                var connectionString = container.GetConnectionString();
                try
                {
                    await using var connection = (SqlConnection)SqlClientFactory.Instance.CreateConnection();
                    connection.ConnectionString = connectionString;

                    await connection.OpenAsync();
                    await using var command = connection.CreateCommand();
                    command.CommandText = "SELECT 1";
                    var result = await command.ExecuteScalarAsync();
                    if (result is int value && value == 1)
                    {
                        break;
                    }
                }
                catch
                {
                    // игнорим
                }

                await Task.Delay(100);
            }
        }
    }
}
