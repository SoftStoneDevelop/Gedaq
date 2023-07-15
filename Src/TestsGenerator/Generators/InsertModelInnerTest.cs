using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class InsertModelInnerTest
    {
        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model, 
            ModelValueStorage storage,
            Database database
            )
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    PostgreSQL.InsertModelInner.Generate(order, stringBuilder, model, storage);
                    break;
                }
                case Database.MsSQL:
                {
                    MsSQL.InsertModelInner.Generate(order, stringBuilder, model, storage);
                    break;
                }
                case Database.MySQL:
                {
                    MySQL.InsertModelInner.Generate(order, stringBuilder, model, storage);
                    break;
                }
            }
        }
    }
}