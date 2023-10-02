using TestsGenerator.Enums;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class InsertModelTest
    {
        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            Database database,
            string interfaceTypeName
            )
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    PostgreSQL.InsertModel.Generate(
                        order, 
                        stringBuilder, 
                        model, 
                        storage,
                        interfaceTypeName
                        );
                    break;
                }
                case Database.MsSQL:
                {
                    MsSQL.InsertModel.Generate(
                        order, 
                        stringBuilder, 
                        model, 
                        storage,
                        interfaceTypeName
                        );
                    break;
                }
                case Database.MySQL:
                {
                    MySQL.InsertModel.Generate(
                        order,
                        stringBuilder, 
                        model, 
                        storage,
                        interfaceTypeName
                        );
                    break;
                }
            }
        }
    }
}