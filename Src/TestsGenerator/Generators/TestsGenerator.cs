using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using TestsGenegator.Comparers;
using TestsGenegator.Enums;

namespace TestsGenegator.Generators
{
    internal class TestsGenerator
    {
        private List<Model.Model> _models = new List<Model.Model>();

        public void Generate(Database database, string destinationFolder)
        {
            AddModels(database);

            {
                var modelgenerator = new ModelGenerator();
                modelgenerator.Generate(_models.Distinct(new ModelTypeComparer()).ToList(), destinationFolder);
            }

            var testOneTimePart = new TestOneTimePart();
            var tests = new TestsPart();
            foreach (var model in _models)
            {
                testOneTimePart.Generate(model, database, destinationFolder);
                tests.Generate(model, database, destinationFolder);
            }
        }

        private void AddModels(Database database)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    AddPostgreSQLTypes();
                    break;
                }
                case Database.MsSQL:
                {
                    break; 
                }
                case Database.MySQL:
                { 
                    break; 
                }
            }
        }

        private void AddPostgreSQLTypes()
        {
            _models.Add(new Model.NpgsqlModel("integer", "Int32", "System.Int32"));
            _models.Add(new Model.NpgsqlModel("integer", "UInt32", "System.UInt32"));

            _models.Add(new Model.NpgsqlModel("bigint", "Int64", "System.Int64"));
            _models.Add(new Model.NpgsqlModel("bigint", "UInt64", "System.UInt64"));

            _models.Add(new Model.NpgsqlModel("smallint", "Byte", "System.Byte"));
            _models.Add(new Model.NpgsqlModel("smallint", "SByte", "System.SByte"));

            _models.Add(new Model.NpgsqlModel("smallint", "Int16", "System.Int16"));
            _models.Add(new Model.NpgsqlModel("smallint", "UInt16", "System.UInt16"));

            _models.Add(new Model.NpgsqlModel("char", "Char", "System.Char"));
            _models.Add(new Model.NpgsqlModel("numeric", "Decimal", "System.Decimal"));
            _models.Add(new Model.NpgsqlModel("double precision", "Double", "System.Double"));
            _models.Add(new Model.NpgsqlModel("boolean", "Boolean", "System.Boolean"));
            _models.Add(new Model.NpgsqlModel("real", "Single", "System.Single"));

            _models.Add(new Model.NpgsqlModel("time without time zone", "TimeSpan", "System.TimeSpan"));
            _models.Add(new Model.NpgsqlModel("time without time zone", "TimeOnly", "System.TimeOnly"));

            _models.Add(new Model.NpgsqlModel("date", "DateTime", "System.DateTime"));
            _models.Add(new Model.NpgsqlModel("date", "DateOnly", "System.DateOnly"));

            _models.Add(new Model.NpgsqlModel("time with time zone", "DateTimeOffset", "System.DateTimeOffset"));

            _models.Add(new Model.NpgsqlModel("text", "String", "System.String", true));

            _models.Add(new Model.NpgsqlModel("inet", "IPAddress", "System.Net.IPAddress", true));
            _models.Add(new Model.NpgsqlModel("macaddr", "PhysicalAddress", "System.Net.NetworkInformation.PhysicalAddress", true));
            _models.Add(new Model.NpgsqlModel("uuid", "Guid", "System.Guid"));
            _models.Add(new Model.NpgsqlModel("numeric", "BigInteger", "System.Numerics.BigInteger"));
            _models.Add(new Model.NpgsqlModel("bit varying", "BitArray", "System.Collections.BitArray", true));
            _models.Add(new Model.NpgsqlModel("tsquery", "NpgsqlTsQuery", "NpgsqlTypes.NpgsqlTsQuery", true));
            _models.Add(new Model.NpgsqlModel("tsvector", "NpgsqlTsVector", "NpgsqlTypes.NpgsqlTsVector", true));
            _models.Add(new Model.NpgsqlModel("point", "NpgsqlPoint", "NpgsqlTypes.NpgsqlPoint"));
            _models.Add(new Model.NpgsqlModel("lseg", "NpgsqlLSeg", "NpgsqlTypes.NpgsqlLSeg"));
            _models.Add(new Model.NpgsqlModel("path", "NpgsqlPath", "NpgsqlTypes.NpgsqlPath"));
            _models.Add(new Model.NpgsqlModel("polygon", "NpgsqlPolygon", "NpgsqlTypes.NpgsqlPolygon"));
            _models.Add(new Model.NpgsqlModel("line", "NpgsqlLine", "NpgsqlTypes.NpgsqlLine"));
            _models.Add(new Model.NpgsqlModel("circle", "NpgsqlCircle", "NpgsqlTypes.NpgsqlCircle"));
            _models.Add(new Model.NpgsqlModel("box", "NpgsqlBox", "NpgsqlTypes.NpgsqlBox"));
        }
    }
}