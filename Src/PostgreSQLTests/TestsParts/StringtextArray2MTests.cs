

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
    internal partial interface IStringListtextArray
    {
    }
    
    internal partial class StringListtextArray : IStringListtextArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2mi(
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
            queryMapType: typeof(StringtextArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                )
            ]
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

                changedRows =  ((IStringListtextArray)this).InsertModelInner(connection, 655209169, 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringListtextArray)this).InsertModelInner(connection, 1384533454, 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

});
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

                changedRows = await ((IStringListtextArray)this).InsertModelInnerAsync(connection, 1123737118, 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringListtextArray)this).InsertModelInnerAsync(connection, 1095006443, 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

});
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IStringListtextArray)this).InsertModelInnerReturning(connection, 614002150, 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

}, null);
                Assert.That(id, Is.EqualTo(614002150));

                id =  ((IStringListtextArray)this).InsertModelInnerReturning(connection, 1956046262, 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

});
                Assert.That(id, Is.EqualTo(1956046262));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 1166789781, 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

}, null);
                Assert.That(id, Is.EqualTo(1166789781));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 1577014744, 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

}, null);
                Assert.That(id, Is.EqualTo(1577014744));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 1918312443, 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

});
                Assert.That(id, Is.EqualTo(1918312443));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 321446412, 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

}, null);
                Assert.That(id, Is.EqualTo(321446412));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 1722865589, 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

});
                Assert.That(id, Is.EqualTo(1722865589));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 1283984742, 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

});
                Assert.That(id, Is.EqualTo(1283984742));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 937962530, 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

}, null);
                Assert.That(id, Is.EqualTo(937962530));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 1648176042, 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

}, null);
                Assert.That(id, Is.EqualTo(1648176042));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, 1626445477, 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

}, null);
                Assert.That(id, Is.EqualTo(1626445477));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2m(
	id,
    value,
    nullablevalue,
    stringtextarray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
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

                changedRows =  ((IStringListtextArray)this).InsertModel(connection, 2095994294, 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringListtextArray)this).InsertModel(connection, 1097081023, 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

}, null, 655209169);
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

                changedRows = await ((IStringListtextArray)this).InsertModelAsync(connection, 259254539, 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringListtextArray)this).InsertModelAsync(connection, 18221643, 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

}, null, 1384533454);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2m(
	id,
    value,
    nullablevalue,
    stringtextarray2mi_id
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
    stringtextarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(StringtextArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextArray2M> models = null;
                StringtextArray2M model = null;

                models =  ((IStringListtextArray)this).InsertModelReturning(connection, 648918175, 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IStringListtextArray)this).InsertModelReturning(connection, 258562317, 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

}, null, 1123737118).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258562317));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123737118));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IStringListtextArray)this).InsertModelReturning(connection, 1943311186, 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IStringListtextArray)this).InsertModelReturning(connection, 890404210, 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

}, null, 1095006443).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextArray2M> models = null;
                StringtextArray2M model = null;

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1017776286, 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 492361001, 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

}, 614002150).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 2108839067, 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1427648511, 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

}, null, 1956046262).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 610140601, 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1326407436, 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

}, 1166789781).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1356031885, 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1735637826, 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

}, 1577014744).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1939271010, 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 770740392, 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

}, null, 1918312443).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1583878482, 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1090844698, 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

}, 321446412).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1918345451, 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 319337871, 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

}, 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

}, 1722865589).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 472872725, 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 263820543, 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

}, null, 1283984742).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263820543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283984742));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1606157362, 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 81761369, 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

}, 937962530).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81761369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(937962530));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1618996726, 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1822040991, 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

}, 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

}, 1648176042).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1991342478, 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, 1973645907, 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

}, null, 1626445477).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        #endregion

#region Select Models

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
FROM public.stringtextarray2m m
LEFT JOIN public.stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(StringtextArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringListtextArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18221643));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1384533454));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81761369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(937962530));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258562317));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123737118));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259254539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263820543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283984742));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringListtextArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18221643));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1384533454));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81761369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(937962530));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258562317));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123737118));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259254539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263820543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283984742));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

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
FROM public.stringtextarray2m m
LEFT JOIN public.stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(StringtextArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringListtextArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18221643));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1384533454));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81761369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(937962530));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258562317));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123737118));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259254539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263820543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283984742));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringListtextArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18221643));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1384533454));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81761369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(937962530));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258562317));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123737118));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259254539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263820543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283984742));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringListtextArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringListtextArray)this).SetDbConnectionSelectModelParametrs(cmd, 319337871);
                var models =  ((IStringListtextArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(24));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringListtextArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringListtextArray)this).SetDbConnectionSelectModelParametrs(cmd, 492361001);
                var models = await ((IStringListtextArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(22));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((IStringListtextArray)this).DbConnectionSelectModelBatch(connection, 890404210, 1583878482))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(18));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                await foreach(var batchResult in ((IStringListtextArray)this).DbConnectionSelectModelBatchAsync(connection, 1326407436, 263820543))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(25));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(StringtextArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(StringtextArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<StringtextArray2MI>(7);

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 321446412,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 614002150,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 655209169,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

}
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 937962530,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1095006443,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

}
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1123737118,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

}
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1166789781,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(321446412));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614002150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(655209169));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(937962530));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1095006443));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123737118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166789781));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1283984742,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

}
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1384533454,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

}
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1577014744,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1626445477,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1648176042,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1722865589,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

}
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1918312443,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

}
                });

                importCollection.Add(
                new StringtextArray2MI
                {
                    Id = 1956046262,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(321446412));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614002150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(655209169));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(937962530));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1095006443));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1123737118));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166789781));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1283984742));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384533454));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1577014744));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1626445477));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1648176042));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722865589));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918312443));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1956046262));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtextarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(StringtextArray2M),
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
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_stringtextarray2m m
LEFT JOIN public.binary_stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(StringtextArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<StringtextArray2M>(15);

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 18221643,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1384533454
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 81761369,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

},

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 937962530
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 258562317,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1123737118
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 259254539,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 263820543,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1283984742
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 319337871,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

},

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1722865589
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 472872725,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 492361001,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

},

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 614002150
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 610140601,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 648918175,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 770740392,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1918312443
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 890404210,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1095006443
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1017776286,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1090844698,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

},

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 321446412
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1097081023,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 655209169
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18221643));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1384533454));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81761369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(937962530));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258562317));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123737118));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259254539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263820543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283984742));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1326407436,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

},

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1166789781
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1356031885,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1427648511,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1956046262
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1583878482,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1606157362,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1618996726,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1735637826,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

},

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1577014744
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1822040991,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

},

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1648176042
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1918345451,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1939271010,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1943311186,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

},
                    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1973645907,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray2MI 
                    {
                        Id = 1626445477
                    }

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 1991342478,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 2095994294,
                    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray2M
                {
                    Id = 2108839067,
                    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18221643));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1384533454));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81761369));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(937962530));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258562317));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1123737118));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259254539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263820543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1283984742));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319337871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1722865589));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(472872725));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(492361001));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(614002150));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610140601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(648918175));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(770740392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1918312443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890404210));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095006443));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017776286));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1090844698));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(321446412));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097081023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655209169));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1326407436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1166789781));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1356031885));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1427648511));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1956046262));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1583878482));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606157362));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618996726));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735637826));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1577014744));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822040991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1648176042));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918345451));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939271010));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1943311186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973645907));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1626445477));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1991342478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095994294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108839067));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtextarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(StringtextArray2M),
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
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,StringtextArray2M>(30);

                expected.Add(
                    18221643,
                    new StringtextArray2M
                    {
                        Id = 18221643,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1384533454,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

}
                        }

                    }
                );

                expected.Add(
                    81761369,
                    new StringtextArray2M
                    {
                        Id = 81761369,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 937962530,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    258562317,
                    new StringtextArray2M
                    {
                        Id = 258562317,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1123737118,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

}
                        }

                    }
                );

                expected.Add(
                    259254539,
                    new StringtextArray2M
                    {
                        Id = 259254539,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    263820543,
                    new StringtextArray2M
                    {
                        Id = 263820543,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1283984742,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

}
                        }

                    }
                );

                expected.Add(
                    319337871,
                    new StringtextArray2M
                    {
                        Id = 319337871,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1722865589,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

}
                        }

                    }
                );

                expected.Add(
                    472872725,
                    new StringtextArray2M
                    {
                        Id = 472872725,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    492361001,
                    new StringtextArray2M
                    {
                        Id = 492361001,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 614002150,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    610140601,
                    new StringtextArray2M
                    {
                        Id = 610140601,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    648918175,
                    new StringtextArray2M
                    {
                        Id = 648918175,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    770740392,
                    new StringtextArray2M
                    {
                        Id = 770740392,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1918312443,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

}
                        }

                    }
                );

                expected.Add(
                    890404210,
                    new StringtextArray2M
                    {
                        Id = 890404210,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1095006443,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

}
                        }

                    }
                );

                expected.Add(
                    1017776286,
                    new StringtextArray2M
                    {
                        Id = 1017776286,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1090844698,
                    new StringtextArray2M
                    {
                        Id = 1090844698,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 321446412,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1097081023,
                    new StringtextArray2M
                    {
                        Id = 1097081023,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 655209169,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

}
                        }

                    }
                );

                expected.Add(
                    1326407436,
                    new StringtextArray2M
                    {
                        Id = 1326407436,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1166789781,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1356031885,
                    new StringtextArray2M
                    {
                        Id = 1356031885,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1427648511,
                    new StringtextArray2M
                    {
                        Id = 1427648511,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1956046262,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

}
                        }

                    }
                );

                expected.Add(
                    1583878482,
                    new StringtextArray2M
                    {
                        Id = 1583878482,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1606157362,
                    new StringtextArray2M
                    {
                        Id = 1606157362,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1618996726,
                    new StringtextArray2M
                    {
                        Id = 1618996726,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1735637826,
                    new StringtextArray2M
                    {
                        Id = 1735637826,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1577014744,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1822040991,
                    new StringtextArray2M
                    {
                        Id = 1822040991,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1648176042,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1918345451,
                    new StringtextArray2M
                    {
                        Id = 1918345451,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1939271010,
                    new StringtextArray2M
                    {
                        Id = 1939271010,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943311186,
                    new StringtextArray2M
                    {
                        Id = 1943311186,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1973645907,
                    new StringtextArray2M
                    {
                        Id = 1973645907,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1626445477,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1991342478,
                    new StringtextArray2M
                    {
                        Id = 1991342478,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2095994294,
                    new StringtextArray2M
                    {
                        Id = 2095994294,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2108839067,
                    new StringtextArray2M
                    {
                        Id = 2108839067,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,StringtextArray2M>(30);

                expected.Add(
                    18221643,
                    new StringtextArray2M
                    {
                        Id = 18221643,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"fjwbjqexldftrulsydfbupsuyi",

"pgxqnggopdnja",

"e",

"nebnwcns",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1384533454,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

}
                        }

                    }
                );

                expected.Add(
                    81761369,
                    new StringtextArray2M
                    {
                        Id = 81761369,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uokwugavbmhynsycgkooupiitsc",

"ki",

"kcsnuwjfjto",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tbveaqtsmitacrhrrsgdhtv",

"xxxryyyrifnapkankaqoudkoksopc",

"lyymeoy",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 937962530,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    258562317,
                    new StringtextArray2M
                    {
                        Id = 258562317,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpsxuep",

"f",

"",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1123737118,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

}
                        }

                    }
                );

                expected.Add(
                    259254539,
                    new StringtextArray2M
                    {
                        Id = 259254539,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"oqskdpeii",

"vuhlpcutdwtapcnitbvhepvhhek",

"hlaqsamfhwwalfp",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    263820543,
                    new StringtextArray2M
                    {
                        Id = 263820543,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ubdbwfchxsdvyy",

"angqfomcmrosefcefvx",

"gwkdfasoardh",

"hx",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1283984742,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

}
                        }

                    }
                );

                expected.Add(
                    319337871,
                    new StringtextArray2M
                    {
                        Id = 319337871,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"lfifs",

"mglwfkpili",

"koeulmwvhad",

"",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eje",

"pudiciquayxtuah",

"bakcnsdx",

"qmogamjjne",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1722865589,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

}
                        }

                    }
                );

                expected.Add(
                    472872725,
                    new StringtextArray2M
                    {
                        Id = 472872725,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"",

"brhx",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ekpnoalkugayqfrusjiyvbwt",

"qdunsydiixnjpkrviibf",

"ifsjndsuvidlphyqlwswxy",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    492361001,
                    new StringtextArray2M
                    {
                        Id = 492361001,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"gndntbkmqpebxhebxynulynt",

"dixnuafaoqliomrlvvabnli",

"ljjkyhbadicax",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffrcvqdlecwmbagfdvxw",

"thm",

"b",

"goejajtvwohsugdlqgxu",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 614002150,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    610140601,
                    new StringtextArray2M
                    {
                        Id = 610140601,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ucjdvvirpxgway",

"yyjld",

"wtbqmtnvvanq",

"yupgbcdfske",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bkyxjdjojeyyagffrbeiijphrrwr",

"umpwmxtgnhuiq",

"sxfmajmcidqhephkqumkwdthouy",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    648918175,
                    new StringtextArray2M
                    {
                        Id = 648918175,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"jwdhffhoiqmikogcuylncyg",

"wvmhjwftx",

"usxyabsgntioyvqfpmvi",

"cfocofursejulpakdgobcm",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"omqpxbwmetgnpcftacdvxy",

"xyhshvoawpmlqyonatsvohbc",

"tuyikxhjjyki",

"vflwvmqqmwfgo",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    770740392,
                    new StringtextArray2M
                    {
                        Id = 770740392,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"hukpdutetrtkpujmlkvxgbouc",

"",

"vh",

"nnuertgwagsauw",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1918312443,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

}
                        }

                    }
                );

                expected.Add(
                    890404210,
                    new StringtextArray2M
                    {
                        Id = 890404210,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wwbfnkeekbpntspdyqklqj",

"jvevesrgqxuytewtxuqpbyxygf",

"rvxdkwcrngpnsqeocbbxlxllq",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1095006443,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

}
                        }

                    }
                );

                expected.Add(
                    1017776286,
                    new StringtextArray2M
                    {
                        Id = 1017776286,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"nsybfhojhyx",

"kcndqdkmprdvecrhpvxrbqofonlo",

"lxrr",

"u",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1090844698,
                    new StringtextArray2M
                    {
                        Id = 1090844698,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"lsdrlurvjtaqfew",

"je",

"fhqoqwofxxpuvdmb",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rftafjaggboqxroh",

"invuswxmcdsvcactauic",

"wcdqauprk",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 321446412,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1097081023,
                    new StringtextArray2M
                    {
                        Id = 1097081023,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qbitpbdhnuug",

"",

"grtfujclhkhiexskovlibgdfyajqh",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 655209169,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

}
                        }

                    }
                );

                expected.Add(
                    1326407436,
                    new StringtextArray2M
                    {
                        Id = 1326407436,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ggtiiohqymdgfkdywixvmrtgliw",

"pgyqdebqxqvpjewxcmrrrurnwseu",

"ksidvd",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"biwoxqywwlpxyivdawbkoeyol",

"gjotrniogtmjunkomccctsqtaqo",

"tmttyxhkpqamnqwidokxhrvmlrpt",

"obfmu",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1166789781,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1356031885,
                    new StringtextArray2M
                    {
                        Id = 1356031885,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"aevdgipvmvfpgknukond",

"omnbbiv",

"afblulsfkauoeuvunhxfjjbetnuum",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"qlkvqylucnwypagw",

"a",

"c",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1427648511,
                    new StringtextArray2M
                    {
                        Id = 1427648511,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vepmhnjphnulmslg",

"edt",

"aqgcogylglqqtjjsrwpkwdxytcfpb",

"qspkefmsowfxmqcctlxnwn",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1956046262,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

},
                            NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

}
                        }

                    }
                );

                expected.Add(
                    1583878482,
                    new StringtextArray2M
                    {
                        Id = 1583878482,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"unntolyjngnongtioig",

"bmawncvkdirvkloagsgsnqosblsr",

"xdkemwdhaocl",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1606157362,
                    new StringtextArray2M
                    {
                        Id = 1606157362,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ydsnqvjttgnnudtcrxwdlxcmhqy",

"otfn",

"",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1618996726,
                    new StringtextArray2M
                    {
                        Id = 1618996726,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"fthklcy",

"vabmrtdamwnwldqh",

"guptxwkyavrcmfnxw",

"pcopnvvcnawnjtkkwvsjuqioequof",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bbsifrmkijayqwfxkwedrkd",

"gpkqbncepwiqsrk",

"ytu",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1735637826,
                    new StringtextArray2M
                    {
                        Id = 1735637826,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"pduisgohgcvqwufch",

"dqusijw",

"xincixkmjxwcivweeb",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hodiwdanuqeqnmevstfgoshxuqwd",

"crtdvxeyxbebi",

"",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1577014744,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1822040991,
                    new StringtextArray2M
                    {
                        Id = 1822040991,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"nqxplqqiyxvfvjflwm",

"boqbs",

"vtgtgpltprnmmxoffyprahb",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cbks",

"keevtkjqshagwc",

"nlkhputi",

},

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1648176042,
                            Value = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1918345451,
                    new StringtextArray2M
                    {
                        Id = 1918345451,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iorfsoxshaahrxpjjuor",

"hquqmugjcmtwjsosxjywuk",

"dciaupwjulyjtbgv",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1939271010,
                    new StringtextArray2M
                    {
                        Id = 1939271010,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uqvvakfkjxhclulhmpmqxpsuopfe",

"dylfkfum",

"mpehchpq",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1943311186,
                    new StringtextArray2M
                    {
                        Id = 1943311186,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ekmnonspgjsyiln",

"nvjf",

"xjxmwttcpdkjoyfbimvsgtnhjal",

"bhlxhbnlfp",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"bc",

"cwmetmehpvnwiryxjay",

"ewkchrhvslvglsdgicvedupuiw",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1973645907,
                    new StringtextArray2M
                    {
                        Id = 1973645907,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wkdss",

"scgyurtaoslvm",

"owafc",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray2MI
                        {
                            Id = 1626445477,
                            Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1991342478,
                    new StringtextArray2M
                    {
                        Id = 1991342478,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"ikxdvajmchpitnohuqitelgg",

"dhadewnbmfukwkjuxrtmrpamsrn",

"lvafqdkc",

"fobvlblgysddjqek",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2095994294,
                    new StringtextArray2M
                    {
                        Id = 2095994294,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mgdhxthsy",

"uhokshxuagjhybogpgwcfacn",

"knmspvlyotme",

"akboflsswbbadcwetkkioryu",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2108839067,
                    new StringtextArray2M
                    {
                        Id = 2108839067,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"bguwednxtrdtwhglyyjcqvnbltx",

"dxfedniqjyukbckbvdgfhgockmm",

"kdqfyflnfaulpjtfawdxrjc",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.String>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(StringtextArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,StringtextArray2MI>(15);

                expected.Add(
                    321446412,
                    new StringtextArray2MI
                    {
                        Id = 321446412,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    614002150,
                    new StringtextArray2MI
                    {
                        Id = 614002150,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    655209169,
                    new StringtextArray2MI
                    {
                        Id = 655209169,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

}
                    }
                );

                expected.Add(
                    937962530,
                    new StringtextArray2MI
                    {
                        Id = 937962530,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1095006443,
                    new StringtextArray2MI
                    {
                        Id = 1095006443,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

}
                    }
                );

                expected.Add(
                    1123737118,
                    new StringtextArray2MI
                    {
                        Id = 1123737118,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

}
                    }
                );

                expected.Add(
                    1166789781,
                    new StringtextArray2MI
                    {
                        Id = 1166789781,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1283984742,
                    new StringtextArray2MI
                    {
                        Id = 1283984742,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

}
                    }
                );

                expected.Add(
                    1384533454,
                    new StringtextArray2MI
                    {
                        Id = 1384533454,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

}
                    }
                );

                expected.Add(
                    1577014744,
                    new StringtextArray2MI
                    {
                        Id = 1577014744,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1626445477,
                    new StringtextArray2MI
                    {
                        Id = 1626445477,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1648176042,
                    new StringtextArray2MI
                    {
                        Id = 1648176042,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1722865589,
                    new StringtextArray2MI
                    {
                        Id = 1722865589,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

}
                    }
                );

                expected.Add(
                    1918312443,
                    new StringtextArray2MI
                    {
                        Id = 1918312443,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

}
                    }
                );

                expected.Add(
                    1956046262,
                    new StringtextArray2MI
                    {
                        Id = 1956046262,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

}
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,StringtextArray2MI>(15);

                expected.Add(
                    321446412,
                    new StringtextArray2MI
                    {
                        Id = 321446412,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"hjyvdfpasfi",

"kjeqcajxif",

"s",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    614002150,
                    new StringtextArray2MI
                    {
                        Id = 614002150,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"iquygweuuvxjjpmfueviqioys",

"xvm",

"oqvurnrghaiyxxmtnxuddyqpcgg",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    655209169,
                    new StringtextArray2MI
                    {
                        Id = 655209169,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"scegruwofydhmdvcu",

"opqgwxjdepwtmbjceipwqsd",

"ec",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pqhhgngepvlfbewwjiolyoykdnhxp",

"kom",

"sdbkdfvfppxm",

"",

}
                    }
                );

                expected.Add(
                    937962530,
                    new StringtextArray2MI
                    {
                        Id = 937962530,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"yemdbagcgihldlrpbgldlbiy",

"nrweae",

"dwrpsbhfttfe",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1095006443,
                    new StringtextArray2MI
                    {
                        Id = 1095006443,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"rvfnbh",

"kshsxmaoxduvnwwpwyhhjilj",

"hgfataisxttu",

"dnbwubpklfjuhibuthylcsedvreki",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"simhahjqeyitktbaceuyndojl",

"chmsvbcccqiksckpbhadrsemuv",

"qvputortgbsiicpcp",

}
                    }
                );

                expected.Add(
                    1123737118,
                    new StringtextArray2MI
                    {
                        Id = 1123737118,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"eauceqrxbslurdlxspggyptheewe",

"ebbwmmfuxhwxnxyfndikkqvphiomf",

"pxr",

"uajyhedkkgpmshedghdx",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ukopnamkbfherqgfhewxfgjb",

"settrwlflrdcyjyobucqu",

"mvnpqthkwujsvjk",

"ceyyct",

}
                    }
                );

                expected.Add(
                    1166789781,
                    new StringtextArray2MI
                    {
                        Id = 1166789781,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"kcjasfaal",

"oaxeagjutmufpwgiqlyahtjvcw",

"senoxneiboaoqmdyjhrjtvjuex",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1283984742,
                    new StringtextArray2MI
                    {
                        Id = 1283984742,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yjfnmmpnwbworxqgau",

"gfrlhhrennfcjyjbfgxaucmb",

"dhhcrfbuljeymminedns",

"llxew",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jfsjkpeexygcvjlxevetrbyyes",

"ivciwxbpgollqmqaijm",

"lrmwmwqimpctfte",

"uldbloscurbhtlknejwby",

}
                    }
                );

                expected.Add(
                    1384533454,
                    new StringtextArray2MI
                    {
                        Id = 1384533454,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"djayvhcd",

"j",

"layettwmgv",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"t",

"biar",

"atkgrghccjrnephsxpv",

}
                    }
                );

                expected.Add(
                    1577014744,
                    new StringtextArray2MI
                    {
                        Id = 1577014744,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"qiiohbotyfkg",

"vvflsvkhkbwobupeclodcceuxwphl",

"gi",

"tlrkatj",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1626445477,
                    new StringtextArray2MI
                    {
                        Id = 1626445477,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ieaqienislnabeeyi",

"gomfrwfcrdogjpoorcfrqprla",

"e",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1648176042,
                    new StringtextArray2MI
                    {
                        Id = 1648176042,
                        Value = 
new System.Collections.Generic.List<System.String>(4)
{
"gb",

"dvxavvabso",

"edweqojyqh",

"yfmy",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1722865589,
                    new StringtextArray2MI
                    {
                        Id = 1722865589,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vnhtfwnojm",

"wwhemgsxeh",

"fqc",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"oynd",

"sf",

"rprayvdfrhgmdyh",

"uosgvdpytehkw",

}
                    }
                );

                expected.Add(
                    1918312443,
                    new StringtextArray2MI
                    {
                        Id = 1918312443,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uofirfqakiboxfkx",

"vtxdipogd",

"yutblposdcfcpsjh",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"bvm",

"jumjewwbepuf",

"ukitrwvretjlbythmgmeudndet",

"b",

}
                    }
                );

                expected.Add(
                    1956046262,
                    new StringtextArray2MI
                    {
                        Id = 1956046262,
                        Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vfdhwhposgievthkqekkinqhrdk",

"ihmsgpwju",

"flptqrekl",

},
                        NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"holjamsvhaaborqxtx",

"or",

"swsgyfhobjpwdv",

"bebjvpmbiblhn",

}
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}

