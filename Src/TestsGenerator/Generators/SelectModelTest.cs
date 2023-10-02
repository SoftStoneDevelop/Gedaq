using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class SelectModelTest
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
                    PostgreSQL.SelectModelTest.Generate(
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
                    MsSQL.SelectModelTest.Generate(
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
                    MySQL.SelectModelTest.Generate(
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