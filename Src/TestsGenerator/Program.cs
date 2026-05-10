using System.Threading.Tasks;

namespace TestsGenerator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length > 0)
            {
                await GenerateTestsAsync(args[0], args[1]);
            }
            else
            {
                var solutionDirectory = "";

                var task1 = GenerateTestsAsync("PostgreSQL", $"{solutionDirectory}\\PostgreSQLTests");
                var task2 = GenerateTestsAsync("MsSQL", $"{solutionDirectory}\\MSSQLTests");
                var task3 = GenerateTestsAsync("MySQL", $"{solutionDirectory}\\MySQLTests");
                var task4 = GenerateTestsAsync("Clickhouse", $"{solutionDirectory}\\ClickhouseTests");

                await Task.WhenAll([task1, task2, task3, task4]);
            }
        }

        private static async Task GenerateTestsAsync(string databaseName, string projPatch)
        {
            var generator = new Generators.TestsGenerator();
            switch (databaseName)
            {
                case "PostgreSQL":
                {
                    await generator.Generate(Enums.Database.PostgreSQL, projPatch);
                    break;
                }

                case "MsSQL":
                {
                    await generator.Generate(Enums.Database.MsSQL, projPatch);
                    break;
                }

                case "MySQL":
                {
                    await generator.Generate(Enums.Database.MySQL, projPatch);
                    break;
                }

                case "Clickhouse":
                {
                    await generator.Generate(Enums.Database.Clickhouse, projPatch);
                    break;
                }
            }
        }
    }
}