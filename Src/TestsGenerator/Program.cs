using System.Threading.Tasks;

namespace TestsGenerator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var generator = new Generators.TestsGenerator();
            switch (args[0])
            {
                case "PostgreSQL":
                {
                    await generator.Generate(Enums.Database.PostgreSQL, args[1]);
                    break;
                }

                case "MsSQL":
                {
                    await generator.Generate(Enums.Database.MsSQL, args[1]);
                    break;
                }

                case "MySQL":
                {
                    await generator.Generate(Enums.Database.MySQL, args[1]);
                    break;
                }
            }
        }
    }
}