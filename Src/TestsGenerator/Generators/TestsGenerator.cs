using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestsGenerator.Comparers;
using TestsGenerator.Enums;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Generators
{
    public class TestsGenerator
    {
        private List<Model.ModelType> _models = new List<Model.ModelType>();

        public async Task Generate(Database database, string destinationFolder)
        {
            AddModels(database);

            var modelgenerator = new ModelGenerator();
            var modelGeneratorTask = modelgenerator.Generate(_models.Distinct(new ModelTypeComparer()).ToList(), destinationFolder);

            var generateTestOneTimeParts = GenerateTestOneTimeParts(database, destinationFolder);
            var generateTestParts = GenerateTestParts(database, destinationFolder);

            await modelGeneratorTask;
            await generateTestOneTimeParts;
            await generateTestParts;
        }

        private async Task GenerateTestOneTimeParts(Database database, string destinationFolder)
        {
            var testOneTimePart = new TestOneTimePart();
            foreach (var model in _models)
            {
                await testOneTimePart.Generate(model, database, destinationFolder);
            }
        }

        private async Task GenerateTestParts(Database database, string destinationFolder)
        {
            var tests = new TestsPart();
            foreach (var model in _models)
            {
                await tests.Generate(model, database, destinationFolder);
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
            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Integer, "Int32", "System.Int32", () => new Int32ValueHelper()));
            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Bigint, "Int64", "System.Int64", () => new Int64ValueHelper()));

            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Smallint, "Byte", "System.Byte", () => new ByteValueHelper()));
            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Smallint, "SByte", "System.SByte", () => new SByteValueHelper()));

            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Smallint, "Int16", "System.Int16", () => new Int16ValueHelper()));

            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Char, "Char", "System.Char", () => new CharValueHelper()));
            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Numeric, "Decimal", "System.Decimal", () => new DecimalValueHelper()));
            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Double, "Double", "System.Double", () => new DoubleValueHelper()));
            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Boolean, "Boolean", "System.Boolean", () => new BooleanValueHelper()));
            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Real, "Single", "System.Single", () => new SingleValueHelper()));

            //_models.Add(new Model.NpgsqlModel("time without time zone", "TimeSpan", "System.TimeSpan", () => new TimeSpanStorage()));
            //_models.Add(new Model.NpgsqlModel("time without time zone", "TimeOnly", "System.TimeOnly", () => new TimeOnlyStorage()));

            //_models.Add(new Model.NpgsqlModel("date", "DateTime", "System.DateTime", () => new DateTimeStorage()));
            //_models.Add(new Model.NpgsqlModel("date", "DateOnly", "System.DateOnly", () => new DateOnlyStorage()));

            //_models.Add(new Model.NpgsqlModel("time with time zone", "DateTimeOffset", "System.DateTimeOffset"));

            _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Text, "String", "System.String", () => new StringValueHelper(), size: 400, mustHaveSize: true, isReferenceType: true));

            //_models.Add(new Model.NpgsqlModel("inet", "IPAddress", "System.Net.IPAddress", true));
            //_models.Add(new Model.NpgsqlModel("macaddr", "PhysicalAddress", "System.Net.NetworkInformation.PhysicalAddress", true));
            //_models.Add(new Model.NpgsqlModel("uuid", "Guid", "System.Guid"));
            //_models.Add(new Model.NpgsqlModel("numeric", "BigInteger", "System.Numerics.BigInteger"));
            //_models.Add(new Model.NpgsqlModel("bit varying", "BitArray", "System.Collections.BitArray", true));
            //_models.Add(new Model.NpgsqlModel("tsquery", "NpgsqlTsQuery", "NpgsqlTypes.NpgsqlTsQuery", true));
            //_models.Add(new Model.NpgsqlModel("tsvector", "NpgsqlTsVector", "NpgsqlTypes.NpgsqlTsVector", true));
            //_models.Add(new Model.NpgsqlModel("point", "NpgsqlPoint", "NpgsqlTypes.NpgsqlPoint"));
            //_models.Add(new Model.NpgsqlModel("lseg", "NpgsqlLSeg", "NpgsqlTypes.NpgsqlLSeg"));
            //_models.Add(new Model.NpgsqlModel("path", "NpgsqlPath", "NpgsqlTypes.NpgsqlPath"));
            //_models.Add(new Model.NpgsqlModel("polygon", "NpgsqlPolygon", "NpgsqlTypes.NpgsqlPolygon"));
            //_models.Add(new Model.NpgsqlModel("line", "NpgsqlLine", "NpgsqlTypes.NpgsqlLine"));
            //_models.Add(new Model.NpgsqlModel("circle", "NpgsqlCircle", "NpgsqlTypes.NpgsqlCircle"));
            //_models.Add(new Model.NpgsqlModel("box", "NpgsqlBox", "NpgsqlTypes.NpgsqlBox"));
        }
    }
}