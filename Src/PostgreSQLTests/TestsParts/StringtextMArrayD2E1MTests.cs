

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IStringMArraytextMArrayD2
    {
    }
    
    internal partial class StringMArraytextMArrayD2 : IStringMArraytextMArrayD2
    {


#region TestData

        private readonly StringtextMArrayD2E1M[] _testData = new StringtextMArrayD2E1M[]
        {
            new StringtextMArrayD2E1M
{
    Id = 9,
    Value = 
new System.String[,] { {
"xlviefenpxkmmauxnmcxbr",
"beqjsrbisfl", } },
    ModelInner = null,
    NullableValue = 
new System.String[,] { {
"rkmehwuupblokkxun",
"kbqqhqgnpvhrosnfnntsehpf", } },
},
            new StringtextMArrayD2E1M
{
    Id = 12,
    Value = 
new System.String[,] { {
"cmfaqlubbgy",
"nk", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 2,
    Value = 
new System.String[,] { {
"dcnldgmghrutnsfufoxyuaadvwyu",
"rskwwdpgdmqxnvivapm", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"voumhxfffcvbnydmsyoewmeoukf",
"cnaofunngghiqtx", } },
},
            new StringtextMArrayD2E1M
{
    Id = 14,
    Value = 
new System.String[,] { {
"qhhjfwgk",
"csuflijbvluvdoby", } },
    ModelInner = null,
    NullableValue = 
new System.String[,] { {
"vfbnwmfcasxmgangnuvi",
"lqpoagfhcmfvfldlk", } },
},
            new StringtextMArrayD2E1M
{
    Id = 23,
    Value = 
new System.String[,] { {
"dvjdklwyllmppavqwyadco",
"jvjydivpometuwrkoxh", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 11,
    Value = 
new System.String[,] { {
"amxskkylhehbgbslmwkgpdkciwbv",
"tytjeasceuleqrvnwodokkmksy", } },
    NullableValue = 
new System.String[,] { {
"wcvbtxnrthjp",
"lhnklrpjtggbqjsiifxgpatxdc", } },
},
    NullableValue = 
new System.String[,] { {
"clsbbf",
"ahnqqqkefahbiiqigrbppvhvhcsf", } },
},
            new StringtextMArrayD2E1M
{
    Id = 27,
    Value = 
new System.String[,] { {
"hhjv",
"tkk", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 32,
    Value = 
new System.String[,] { {
"hwepfw",
"hrqpvnmleimtnpydyrmjxmol", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 19,
    Value = 
new System.String[,] { {
"hsrawbc",
"cjkuidlebxy", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 39,
    Value = 
new System.String[,] { {
"kpiqmbpurix",
"nrjbbswdkcjxv", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 45,
    Value = 
new System.String[,] { {
"btanexbturfvwixyfbace",
"x", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 21,
    Value = 
new System.String[,] { {
"rbaixtkyalubfkviitroxbl",
"iplbwhvoau", } },
    NullableValue = 
new System.String[,] { {
"fmpstytafirhrlae",
"jdxykmxtjktdcitsomaowjsmx", } },
},
    NullableValue = 
new System.String[,] { {
"nhikmhlvniuntpmuwpacks",
"dxgkva", } },
},
            new StringtextMArrayD2E1M
{
    Id = 49,
    Value = 
new System.String[,] { {
"ttstgcbgioj",
"ehpyk", } },
    ModelInner = null,
    NullableValue = 
new System.String[,] { {
"kdvdh",
"hyuwafnfnmaatydpua", } },
},
            new StringtextMArrayD2E1M
{
    Id = 58,
    Value = 
new System.String[,] { {
"qkqdgwcj",
"akwoahvxcvbkgoyv", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 24,
    Value = 
new System.String[,] { {
"fewwfycvbjehchvhna",
"posdlcvcfkoeyhwffcuoheopqbypp", } },
    NullableValue = 
new System.String[,] { {
"quyibweudfdkenttxsxlrd",
"umxkeuwiqxteldsfrkmpsegcv", } },
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 60,
    Value = 
new System.String[,] { {
"kvpbypyougifsyl",
"wilyo", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 68,
    Value = 
new System.String[,] { {
"ebxoyuuwn",
"yqwnqt", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 32,
    Value = 
new System.String[,] { {
"euefugtfkhxrhaxngo",
"avoehocaxxwdbfjmsmc", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"rohxm",
"phbpctni", } },
},
            new StringtextMArrayD2E1M
{
    Id = 71,
    Value = 
new System.String[,] { {
"ghuy",
"", } },
    ModelInner = null,
    NullableValue = 
new System.String[,] { {
"hrbelmnesuqcaldgajwqtgdgdt",
"qvuynegmqblwameg", } },
},
            new StringtextMArrayD2E1M
{
    Id = 76,
    Value = 
new System.String[,] { {
"latwcrblyvc",
"qkcbfwheuwrnxuyqvcydinisou", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 35,
    Value = 
new System.String[,] { {
"thxhafvuonux",
"cddbmsnsghepogfq", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 83,
    Value = 
new System.String[,] { {
"cspqnkmvtpawilqndltkppkyb",
"eqvnfrxrxwrnpagcpnwygknyvcm", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 88,
    Value = 
new System.String[,] { {
"odvbscuvhxpeeyohqwdyvfkifb",
"gjkatbg", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 39,
    Value = 
new System.String[,] { {
"klkympueff",
"vkkfipjjehhnjewnmwmoenhqik", } },
    NullableValue = 
new System.String[,] { {
"htnicyqjlacancln",
"qicjcompyqq", } },
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 91,
    Value = 
new System.String[,] { {
"yaobcjudnhrnnphap",
"pdcyiylkufqqfbjjwumwushqqfqb", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 97,
    Value = 
new System.String[,] { {
"jaydiqjuiopq",
"syylhvxcckfqbpjkbxwrvvkovw", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 44,
    Value = 
new System.String[,] { {
"ermlvetjpebca",
"lq", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 106,
    Value = 
new System.String[,] { {
"rkxuwglwmkrnlpatq",
"fyvhlfceoalwyybj", } },
    ModelInner = null,
    NullableValue = 
new System.String[,] { {
"pimjkfwvdhtokpymwobufj",
"ba", } },
},
            new StringtextMArrayD2E1M
{
    Id = 113,
    Value = 
new System.String[,] { {
"rnjplmveqroemqx",
"xhglcdaqqwdedsnmpuaelpf", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 47,
    Value = 
new System.String[,] { {
"micpyhuwtsnoywed",
"lhbqdvfuvfosscexbt", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"mkeraocplgvfkyrywikqnbsrrtpdm",
"wwswfxhmvhybsbw", } },
},
            new StringtextMArrayD2E1M
{
    Id = 116,
    Value = 
new System.String[,] { {
"wuyhnlcunieh",
"utnuujn", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 118,
    Value = 
new System.String[,] { {
"gmouwlpivmrqieweipjbta",
"ketlwafwxwyintua", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 53,
    Value = 
new System.String[,] { {
"awrqofmsjljqqomi",
"kfjiemtreic", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 127,
    Value = 
new System.String[,] { {
"amrtujdvgrnyhnhykqugninp",
"vfujxhbcwcidlxmknobcxqvbnham", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 133,
    Value = 
new System.String[,] { {
"sllwtrkrowtjsnv",
"gxkjpahgonn", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 58,
    Value = 
new System.String[,] { {
"myhycprhjtmsqpbebyqkmyhyoxk",
"ncvpv", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 135,
    Value = 
new System.String[,] { {
"tuucuilpebtrvhncwlc",
"", } },
    ModelInner = null,
    NullableValue = 
new System.String[,] { {
"sv",
"toudxtrxwfiicxdfpipdraki", } },
},
            new StringtextMArrayD2E1M
{
    Id = 144,
    Value = 
new System.String[,] { {
"lcrhkqjkyiugbeomiiphk",
"bdyqnuvdjlsurjc", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 63,
    Value = 
new System.String[,] { {
"bufqgicajgxsduwlwfuxuq",
"fjnt", } },
    NullableValue = 
new System.String[,] { {
"ofqnwtanmldnghuovdh",
"fteavlqhplhoy", } },
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 152,
    Value = 
new System.String[,] { {
"xyebwxwvrnpmsh",
"vnluxfqiqlwmwrt", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 157,
    Value = 
new System.String[,] { {
"yoyquoesagpseovbxixhpgmafpogc",
"dumxrtlqngltnqwaiccx", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 67,
    Value = 
new System.String[,] { {
"qsxkcceck",
"colxfahvdolknglhqcjvfkwd", } },
    NullableValue = 
new System.String[,] { {
"q",
"bryxwaxdeom", } },
},
    NullableValue = 
new System.String[,] { {
"phkeqia",
"jtmnldsrcxsydnvtftkkicnsc", } },
},
            new StringtextMArrayD2E1M
{
    Id = 166,
    Value = 
new System.String[,] { {
"ceiougdhpmbywdsucprlayavnxv",
"uphbggmfkfrx", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 167,
    Value = 
new System.String[,] { {
"ctmksvlonmhqn",
"ogttcgaq", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 69,
    Value = 
new System.String[,] { {
"s",
"mhiokggahs", } },
    NullableValue = 
new System.String[,] { {
"ngebgnc",
"yanisepsucyvsfeajqijptnayoktj", } },
},
    NullableValue = 
new System.String[,] { {
"nvkie",
"dmgwyhqqqlvatltt", } },
},
            new StringtextMArrayD2E1M
{
    Id = 168,
    Value = 
new System.String[,] { {
"pghaolyf",
"fjdafgmsboorn", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 175,
    Value = 
new System.String[,] { {
"kkvvukfxdxmtpio",
"mopuipumoifec", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 73,
    Value = 
new System.String[,] { {
"kwfscydvphfhag",
"xflcnsyinedwusaw", } },
    NullableValue = 
new System.String[,] { {
"lloeivfhvkhldshjgwsd",
"", } },
},
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 179,
    Value = 
new System.String[,] { {
"knlouxptwkbly",
"cdunujfhniuxoirfaqlwqtw", } },
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMArrayD2E1M
{
    Id = 185,
    Value = 
new System.String[,] { {
"v",
"nlcbokcupsbiue", } },
    ModelInner = new StringtextMArrayD21MI
{
    Id = 75,
    Value = 
new System.String[,] { {
"ip",
"", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"kfkyqjjogh",
"vhpciwugcfv", } },
},
            new StringtextMArrayD2E1M
{
    Id = 192,
    Value = 
new System.String[,] { {
"qlfngkjijnsloxqxadeniq",
"givhukb", } },
    ModelInner = null,
    NullableValue = 
new System.String[,] { {
"sspfqbqwtnlnjh",
"xiirw", } },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmarrayd21mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmarrayd21mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(StringtextMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IStringMArraytextMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringMArraytextMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IStringMArraytextMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringMArraytextMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IStringMArraytextMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IStringMArraytextMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IStringMArraytextMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmarrayd2e1m(
	id,
    value,
    nullablevalue,
    stringtextmarrayd21mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextmarrayd21mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IStringMArraytextMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IStringMArraytextMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IStringMArraytextMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IStringMArraytextMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmarrayd2e1m(
	id,
    value,
    nullablevalue,
    stringtextmarrayd21mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    stringtextmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.String[,]>();
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IStringMArraytextMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.String[,]>();
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IStringMArraytextMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.String[,]>();
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IStringMArraytextMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.String[,]>();
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IStringMArraytextMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[,] { {
"nhikmhlvniuntpmuwpacks",
"dxgkva", } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmarrayd2e1m(
	id,
    value,
    nullablevalue,
    stringtextmarrayd21mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    stringtextmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextmarrayd21mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[,] nullable = null;
                nullable =  ((IStringMArraytextMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[,] { {
"kdvdh",
"hyuwafnfnmaatydpua", } }));
                nullable =  ((IStringMArraytextMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[,] nullable = null;
                nullable = await ((IStringMArraytextMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IStringMArraytextMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[,] { {
"rohxm",
"phbpctni", } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextMArrayD2E1M> models = null;

                models =  ((IStringMArraytextMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IStringMArraytextMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IStringMArraytextMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IStringMArraytextMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextMArrayD2E1M> models = null;

                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IStringMArraytextMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M), typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                ((IStringMArraytextMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringMArraytextMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringMArraytextMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
LEFT JOIN public.stringtextmarrayd21mi mi ON mi.id = m.stringtextmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringMArraytextMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringMArraytextMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M), typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                ((IStringMArraytextMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IStringMArraytextMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IStringMArraytextMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
LEFT JOIN public.stringtextmarrayd21mi mi ON mi.id = m.stringtextmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringMArraytextMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringMArraytextMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M), typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                await((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                ((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                 ((IStringMArraytextMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                 ((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringMArraytextMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringMArraytextMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                 ((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
LEFT JOIN public.stringtextmarrayd21mi mi ON mi.id = m.stringtextmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringMArraytextMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringMArraytextMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        StringtextMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        StringtextMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        StringtextMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        StringtextMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        StringtextMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        StringtextMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        StringtextMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        StringtextMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        StringtextMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        StringtextMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        StringtextMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        StringtextMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringMArraytextMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringMArraytextMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        StringtextMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        StringtextMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        StringtextMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        StringtextMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        StringtextMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        StringtextMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        StringtextMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        StringtextMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        StringtextMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        StringtextMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        StringtextMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        StringtextMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        StringtextMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        StringtextMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        StringtextMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        StringtextMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        StringtextMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        StringtextMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        StringtextMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        StringtextMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        StringtextMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        StringtextMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        StringtextMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        StringtextMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        StringtextMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        StringtextMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        StringtextMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        StringtextMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        StringtextMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        StringtextMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        StringtextMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        StringtextMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        StringtextMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        StringtextMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        StringtextMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        StringtextMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        StringtextMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        StringtextMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        StringtextMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        StringtextMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M), typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                await((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMArrayD2E1M>();
                var models2 = new List<FlatStringtextMArrayD2E1M>();
                ((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                 ((IStringMArraytextMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 168, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var firstItems2 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                 ((IStringMArraytextMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 116, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringMArraytextMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 39, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                await ((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringMArraytextMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 97, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatStringtextMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems1 = new List<FlatStringtextMArrayD2E1M>();
                var secondItems2 = new List<FlatStringtextMArrayD2E1M>();
                 ((IStringMArraytextMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 49, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatStringtextMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextmarrayd2e1m m
LEFT JOIN public.stringtextmarrayd21mi mi ON mi.id = m.stringtextmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IStringMArraytextMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringMArraytextMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        StringtextMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        StringtextMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        StringtextMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        StringtextMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        StringtextMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        StringtextMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        StringtextMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        StringtextMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        StringtextMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        StringtextMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        StringtextMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        StringtextMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        StringtextMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        StringtextMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        StringtextMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        StringtextMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        StringtextMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        StringtextMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        StringtextMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        StringtextMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        StringtextMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        StringtextMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        StringtextMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        StringtextMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        StringtextMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        StringtextMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        StringtextMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        StringtextMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        StringtextMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        StringtextMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        StringtextMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        StringtextMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        StringtextMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringMArraytextMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringMArraytextMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 27, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        StringtextMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        StringtextMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        StringtextMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        StringtextMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        StringtextMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        StringtextMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        StringtextMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        StringtextMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        StringtextMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        StringtextMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        StringtextMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        StringtextMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        StringtextMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        StringtextMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        StringtextMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        StringtextMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        StringtextMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        StringtextMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        StringtextMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        StringtextMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        StringtextMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        StringtextMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        StringtextMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        StringtextMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        StringtextMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        StringtextMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        StringtextMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        StringtextMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        StringtextMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        StringtextMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        StringtextMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        StringtextMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        StringtextMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        StringtextMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        StringtextMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        StringtextMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        StringtextMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        StringtextMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        StringtextMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        StringtextMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        StringtextMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        StringtextMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        StringtextMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        StringtextMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        StringtextMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        StringtextMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        StringtextMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        StringtextMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        StringtextMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        StringtextMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        StringtextMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        StringtextMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringMArraytextMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringMArraytextMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((IStringMArraytextMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                StringtextMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                StringtextMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                StringtextMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                StringtextMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                StringtextMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                StringtextMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                StringtextMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                StringtextMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                StringtextMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                StringtextMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                StringtextMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                StringtextMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                StringtextMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                StringtextMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                StringtextMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                StringtextMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                StringtextMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                StringtextMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                StringtextMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                StringtextMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                StringtextMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                StringtextMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                StringtextMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                StringtextMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                StringtextMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                StringtextMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                StringtextMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                StringtextMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                StringtextMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                StringtextMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                StringtextMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                StringtextMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                StringtextMArrayD2E1M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringMArraytextMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringMArraytextMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models =  ((IStringMArraytextMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                StringtextMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                StringtextMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                StringtextMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                StringtextMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                StringtextMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                StringtextMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                StringtextMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                StringtextMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                StringtextMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                StringtextMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                StringtextMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                StringtextMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                StringtextMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                StringtextMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                StringtextMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                StringtextMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                StringtextMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                StringtextMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                StringtextMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                StringtextMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                StringtextMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                StringtextMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                StringtextMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                StringtextMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                StringtextMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                StringtextMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                StringtextMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                StringtextMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                StringtextMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                StringtextMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                StringtextMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                StringtextMArrayD2E1M.AssertModel(models[31],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(StringtextMArrayD21MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringMArraytextMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringMArraytextMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringMArraytextMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringMArraytextMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(StringtextMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringMArraytextMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringMArraytextMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringMArraytextMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringMArraytextMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(StringtextMArrayD21MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IStringMArraytextMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringMArraytextMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IStringMArraytextMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IStringMArraytextMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(StringtextMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringMArraytextMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringMArraytextMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringMArraytextMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IStringMArraytextMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtextmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(StringtextMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_stringtextmarrayd2e1m m
LEFT JOIN public.binary_stringtextmarrayd21mi mi ON mi.id = m.stringtextmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IStringMArraytextMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IStringMArraytextMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IStringMArraytextMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IStringMArraytextMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtextmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(StringtextMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringMArraytextMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringMArraytextMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA), typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MIWA>();
                var models2 = new List<StringtextMArrayD21MIWA>();
                await ((IStringMArraytextMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MIWA>();
                var models2 = new List<StringtextMArrayD21MIWA>();
                ((IStringMArraytextMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringMArraytextMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_stringtextmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringMArraytextMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_stringtextmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA), typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MIWA>();
                var models2 = new List<StringtextMArrayD21MIWA>();
                await ((IStringMArraytextMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MIWA>();
                var models2 = new List<StringtextMArrayD21MIWA>();
                ((IStringMArraytextMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringMArraytextMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_stringtextmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringMArraytextMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_stringtextmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MI), typeof(StringtextMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MI>();
                var models2 = new List<StringtextMArrayD21MI>();
                await ((IStringMArraytextMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MI>();
                var models2 = new List<StringtextMArrayD21MI>();
                ((IStringMArraytextMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringMArraytextMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringMArraytextMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA), typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MIWA>();
                var models2 = new List<StringtextMArrayD21MIWA>();
                await ((IStringMArraytextMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextMArrayD21MIWA>();
                var models2 = new List<StringtextMArrayD21MIWA>();
                ((IStringMArraytextMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(StringtextMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMArrayD2))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringMArraytextMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringMArraytextMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

