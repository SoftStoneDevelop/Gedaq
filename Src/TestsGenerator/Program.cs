using TestsGenegator.Generators;

namespace TestsGenegator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new TestsGenerator();
            switch (args[0])
            {
                case "PostgreSQL":
                {
                    generator.Generate(Enums.Database.PostgreSQL, args[1]);
                    break;
                }

                case "MsSQL":
                {
                    generator.Generate(Enums.Database.MsSQL, args[1]);
                    break;
                }

                case "MySQL":
                {
                    generator.Generate(Enums.Database.MySQL, args[1]);
                    break;
                }
            }
        }
    }
}