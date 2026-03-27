using MySqlConnector;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestsGenerator.Comparers;
using TestsGenerator.Enums;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Generators
{
    public class TestsGenerator
    {
        private readonly List<Model.ModelType> _models = [];

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
            var directory = Directory.CreateDirectory($"{destinationFolder}/TestOneTimeParts/");
            foreach (var file in directory.GetFiles())
            {
                File.Delete(file.FullName);
            }

            foreach (var model in _models)
            {
                await testOneTimePart.Generate(model, database, destinationFolder);
            }
        }

        private async Task GenerateTestParts(Database database, string destinationFolder)
        {
            var tests = new TestsPart();
            var directory = Directory.CreateDirectory($"{destinationFolder}/TestsParts/");
            foreach (var file in directory.GetFiles())
            {
                File.Delete(file.FullName);
            }

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
                    AddMSSQLTypes();
                    break; 
                }
                case Database.MySQL:
                {
                    AddMySQLTypes();
                    break; 
                }
            }
        }

        private void AddPostgreSQLTypes()
        {
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Integer, "Int32", "System.Int32", type => new Int32ValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Bigint, "Int64", "System.Int64", type => new Int64ValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Smallint, "Byte", "System.Byte", type => new ByteValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Smallint, "SByte", "System.SByte", type => new SByteValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Smallint, "Int16", "System.Int16", type => new Int16ValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Char, "Char", "System.Char", type => new CharValueHelper(type), generateArray: false);

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Numeric, "Decimal", "System.Decimal", type => new DecimalValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Numeric, "BigInteger", "System.Numerics.BigInteger", type => new BigIntegerValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Money, "Decimal", "System.Decimal", type => new DecimalValueHelper(type, 2));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Double, "Double", "System.Double", type => new DoubleValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Boolean, "Boolean", "System.Boolean", type => new BooleanValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Real, "Single", "System.Single", type => new SingleValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Interval, "TimeSpan", "System.TimeSpan", type => new TimeSpanValueHelper(type, true));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Interval, "NpgsqlInterval", "NpgsqlTypes.NpgsqlInterval", type => new NpgsqlIntervalValueHelper(type, true));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Time, "TimeOnly", "System.TimeOnly", type => new TimeOnlyValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Timestamp, "DateTime", "System.DateTime", type => new DateTimeValueHelper(type, System.DateTimeKind.Local));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.TimestampTz, "DateTime", "System.DateTime", type => new DateTimeValueHelper(type, System.DateTimeKind.Utc));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Date, "DateOnly", "System.DateOnly", type => new DateOnlyValueHelper(type));

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Text, "String", "System.String", type => new StringValueHelper(type), size: 400, mustHaveSize: true, isReferenceType: true);

            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Inet, "IPAddress", "System.Net.IPAddress", type => new IPAddressValueHelper(type), isReferenceType: true);
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Uuid, "Guid", "System.Guid", type => new GuidValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Line, "NpgsqlLine", "NpgsqlTypes.NpgsqlLine", type => new NpgsqlLineValueHelper(type));
            if(false)
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Polygon, "NpgsqlPolygon", "NpgsqlTypes.NpgsqlPolygon", type => new NpgsqlPolygonValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Point, "NpgsqlPoint", "NpgsqlTypes.NpgsqlPoint", type => new NpgsqlPointValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Circle, "NpgsqlCircle", "NpgsqlTypes.NpgsqlCircle", type => new NpgsqlCircleValueHelper(type));
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Box, "NpgsqlBox", "NpgsqlTypes.NpgsqlBox", type => new NpgsqlBoxValueHelper(type));
            if (false)
            AddPostgreType(NpgsqlTypes.NpgsqlDbType.Path, "NpgsqlPath", "NpgsqlTypes.NpgsqlPath", type => new NpgsqlPathValueHelper(type));

            //_models.Add(new Model.NpgsqlModel("bit varying", "BitArray", "System.Collections.BitArray", true));
            //_models.Add(new Model.NpgsqlModel("tsquery", "NpgsqlTsQuery", "NpgsqlTypes.NpgsqlTsQuery", true));
            //_models.Add(new Model.NpgsqlModel("tsvector", "NpgsqlTsVector", "NpgsqlTypes.NpgsqlTsVector", true));
            //_models.Add(new Model.NpgsqlModel("lseg", "NpgsqlLSeg", "NpgsqlTypes.NpgsqlLSeg"));
        }

        private void AddPostgreType(
            NpgsqlDbType npgsqlDbType,
            string typeName,
            string typeFullName,
            Func<EnumerableType, ValueHelper> valueStorageFactory,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false,
            bool generateArray = true
            )
        {
            _models.Add(new Model.NpgsqlModel(npgsqlDbType, typeName, typeFullName, () => valueStorageFactory(EnumerableType.SingleType), EnumerableType.SingleType, size, mustHaveSize, isReferenceType));
            if (generateArray)
            { 
                _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Array | npgsqlDbType, typeName, typeFullName, () => valueStorageFactory(EnumerableType.Array), EnumerableType.Array, size, mustHaveSize, isReferenceType));
                _models.Add(new Model.NpgsqlModel(NpgsqlTypes.NpgsqlDbType.Array | npgsqlDbType, typeName, typeFullName, () => valueStorageFactory(EnumerableType.List), EnumerableType.List, size, mustHaveSize, isReferenceType));
            }
        }

        private void AddMSSQLTypes()
        {
            _models.Add(new Model.MSSQLModel(SqlDbType.Int, "Int32", "System.Int32", () => new Int32ValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MSSQLModel(SqlDbType.BigInt, "Int64", "System.Int64", () => new Int64ValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MSSQLModel(SqlDbType.TinyInt, "Byte", "System.Byte", () => new ByteValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MSSQLModel(SqlDbType.SmallInt, "Int16", "System.Int16", () => new Int16ValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MSSQLModel(SqlDbType.Decimal, "Decimal", "System.Decimal", () => new DecimalValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MSSQLModel(SqlDbType.Float, "Double", "System.Double", () => new DoubleValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MSSQLModel(SqlDbType.Bit, "Boolean", "System.Boolean", () => new BooleanValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MSSQLModel(SqlDbType.Real, "Single", "System.Single", () => new SingleValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MSSQLModel(SqlDbType.Time, "TimeSpan", "System.TimeSpan", () => new TimeSpanValueHelper(EnumerableType.SingleType, true)));

            _models.Add(new Model.MSSQLModel(SqlDbType.DateTime2, "DateTime", "System.DateTime", () => new DateTimeValueHelper(EnumerableType.SingleType, System.DateTimeKind.Local)));
            _models.Add(new Model.MSSQLModel(SqlDbType.Date, "DateOnly", "System.DateOnly", () => new DateOnlyValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MSSQLModel(SqlDbType.Text, "String", "System.String", () => new StringValueHelper(EnumerableType.SingleType), size: 400, mustHaveSize: true, isReferenceType: true));
            _models.Add(new Model.MSSQLModel(SqlDbType.UniqueIdentifier, "Guid", "System.Guid", () => new GuidValueHelper(EnumerableType.SingleType)));
        }

        private void AddMySQLTypes()
        {
            _models.Add(new Model.MySqlModel(MySqlDbType.Int32, "Int32", "System.Int32", () => new Int32ValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MySqlModel(MySqlDbType.Int64, "Int64", "System.Int64", () => new Int64ValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MySqlModel(MySqlDbType.Int16, "Int16", "System.Int16", () => new Int16ValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MySqlModel(MySqlDbType.Decimal, "Decimal", "System.Decimal", () => new DecimalValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MySqlModel(MySqlDbType.Double, "Double", "System.Double", () => new DoubleValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MySqlModel(MySqlDbType.Bool, "Boolean", "System.Boolean", () => new BooleanValueHelper(EnumerableType.SingleType)));
            _models.Add(new Model.MySqlModel(MySqlDbType.Float, "Single", "System.Single", () => new SingleValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MySqlModel(MySqlDbType.Time, "TimeSpan", "System.TimeSpan", () => new TimeSpanValueHelper(EnumerableType.SingleType, true)));

            _models.Add(new Model.MySqlModel(MySqlDbType.DateTime, "DateTime", "System.DateTime", () => new DateTimeValueHelper(EnumerableType.SingleType, System.DateTimeKind.Local)));
            _models.Add(new Model.MySqlModel(MySqlDbType.Date, "DateOnly", "System.DateOnly", () => new DateOnlyValueHelper(EnumerableType.SingleType)));

            _models.Add(new Model.MySqlModel(MySqlDbType.Text, "String", "System.String", () => new StringValueHelper(EnumerableType.SingleType), size: 400, mustHaveSize: true, isReferenceType: true));
        }
    }
}