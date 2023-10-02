

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
    internal partial interface IStringArraytextArray
    {
    }
    
    internal partial class StringArraytextArray : IStringArraytextArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray1mi(
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
            asPartInterface: typeof(IStringArraytextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
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
INSERT INTO public.stringtextarray1mi(
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
            queryMapType: typeof(StringtextArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
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

                changedRows =  ((IStringArraytextArray)this).InsertModelInner(connection, 1941793093, 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringArraytextArray)this).InsertModelInner(connection, 1774224246, 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

}, 
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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

                changedRows = await ((IStringArraytextArray)this).InsertModelInnerAsync(connection, 659984255, 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringArraytextArray)this).InsertModelInnerAsync(connection, 1982220787, 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

}, 
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

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

                id =  ((IStringArraytextArray)this).InsertModelInnerReturning(connection, 186045298, 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

}, 
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

});
                Assert.That(id, Is.EqualTo(186045298));

                id =  ((IStringArraytextArray)this).InsertModelInnerReturning(connection, 1952240378, 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

}, null);
                Assert.That(id, Is.EqualTo(1952240378));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 556499630, 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

}, 
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

});
                Assert.That(id, Is.EqualTo(556499630));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 728009250, 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

}, 
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

});
                Assert.That(id, Is.EqualTo(728009250));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 354029252, 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

}, null);
                Assert.That(id, Is.EqualTo(354029252));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 1013321782, 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

}, 
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

"",

});
                Assert.That(id, Is.EqualTo(1013321782));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 1142671571, 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

}, null);
                Assert.That(id, Is.EqualTo(1142671571));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 1686809878, 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

}, 
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

});
                Assert.That(id, Is.EqualTo(1686809878));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 1591154332, 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

}, 
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

});
                Assert.That(id, Is.EqualTo(1591154332));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 1218420758, 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

}, 
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

});
                Assert.That(id, Is.EqualTo(1218420758));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, 2077733773, 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

}, 
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

});
                Assert.That(id, Is.EqualTo(2077733773));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray1m(
	id,
    value,
    nullablevalue,
    stringtextarray1mi_id
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
            asPartInterface: typeof(IStringArraytextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextarray1mi_id", 
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

                changedRows =  ((IStringArraytextArray)this).InsertModel(connection, 435538494, 
new System.String[3]
{
"uc",

"rbwux",

"y",

}, 
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringArraytextArray)this).InsertModel(connection, 1634956267, 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

}, 
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

}, 1941793093);
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

                changedRows = await ((IStringArraytextArray)this).InsertModelAsync(connection, 1083051525, 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringArraytextArray)this).InsertModelAsync(connection, 1358771853, 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

}, null, 1774224246);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[] nullable = null;

                nullable =  ((IStringArraytextArray)this).ScalarInsertModelReturning(connection, 1458689494, 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

}, 
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

}));

                nullable =  ((IStringArraytextArray)this).ScalarInsertModelReturning(connection, 1556006550, 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

}, 
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

}, 659984255);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

}));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[] nullable = null;

                nullable = await ((IStringArraytextArray)this).ScalarInsertModelReturningAsync(connection, 765745174, 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

}, 
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

}));

                nullable = await ((IStringArraytextArray)this).ScalarInsertModelReturningAsync(connection, 1591488978, 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

}, null, 1982220787);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray1m(
	id,
    value,
    nullablevalue,
    stringtextarray1mi_id
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
    stringtextarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(StringtextArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextarray1mi_id", 
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
                List<StringtextArray1M> models = null;
                StringtextArray1M model = null;

                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, 1795996085, 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

"u",

}, 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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

                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, 1138971227, 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

}, 
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

}, 186045298).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1138971227));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

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
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(186045298));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, 372944064, 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(372944064));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

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

                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, 1765694086, 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

}, null, 1952240378).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextArray1M> models = null;
                StringtextArray1M model = null;

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 906019819, 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906019819));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1516292486, 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

}, 
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

}, 556499630).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 971505078, 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

"",

}, 
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971505078));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

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
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 2099760343, 
new System.String[3]
{
"nfujqy",

"",

"pr",

}, null, 728009250).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1888538551, 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

}, 
new System.String[3]
{
"teay",

"psjroictr",

"vml",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 2111004478, 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

}, null, 354029252).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1434414446, 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1503157483, 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

}, null, 1013321782).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1325603064, 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

}, 
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 633323258, 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

}, 
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

}, 1142671571).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633323258));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

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
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1142671571));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 22955107, 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

}, 
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22955107));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

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
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1191490084, 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

}, 
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

}, 1686809878).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1325756329, 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1910636045, 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

}, 
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

}, 1591154332).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 848969540, 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

}, 
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(848969540));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

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
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1682634133, 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

}, 
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

}, 1218420758).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 803365058, 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(803365058));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

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

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, 1502743302, 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

}, 
new System.String[3]
{
"p",

"",

"rgqrnkanw",

}, 2077733773).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
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
FROM public.stringtextarray1m m
LEFT JOIN public.stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(StringtextArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)
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
                var models =  ((IStringArraytextArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22955107));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

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
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

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
                Assert.That(model.Id, Is.EqualTo(372944064));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(435538494));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uc",

"rbwux",

"y",

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
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

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
                Assert.That(model.Id, Is.EqualTo(633323258));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

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
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1142671571));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                Assert.That(model.Id, Is.EqualTo(765745174));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

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
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

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
                Assert.That(model.Id, Is.EqualTo(803365058));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

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
                Assert.That(model.Id, Is.EqualTo(848969540));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

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
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

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
                Assert.That(model.Id, Is.EqualTo(906019819));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

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
                Assert.That(model.Id, Is.EqualTo(971505078));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

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
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

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
                Assert.That(model.Id, Is.EqualTo(1083051525));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

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
                Assert.That(model.Id, Is.EqualTo(1138971227));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

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
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(186045298));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

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
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

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
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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
                Assert.That(model.Id, Is.EqualTo(1458689494));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

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
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

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
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringArraytextArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22955107));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

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
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

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
                Assert.That(model.Id, Is.EqualTo(372944064));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(435538494));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uc",

"rbwux",

"y",

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
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

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
                Assert.That(model.Id, Is.EqualTo(633323258));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

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
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1142671571));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                Assert.That(model.Id, Is.EqualTo(765745174));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

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
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

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
                Assert.That(model.Id, Is.EqualTo(803365058));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

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
                Assert.That(model.Id, Is.EqualTo(848969540));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

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
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

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
                Assert.That(model.Id, Is.EqualTo(906019819));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

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
                Assert.That(model.Id, Is.EqualTo(971505078));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

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
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

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
                Assert.That(model.Id, Is.EqualTo(1083051525));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

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
                Assert.That(model.Id, Is.EqualTo(1138971227));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

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
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(186045298));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

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
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

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
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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
                Assert.That(model.Id, Is.EqualTo(1458689494));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

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
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

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
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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
FROM public.stringtextarray1m m
LEFT JOIN public.stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(StringtextArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)
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
                var models =  ((IStringArraytextArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22955107));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

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
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

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
                Assert.That(model.Id, Is.EqualTo(372944064));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(435538494));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uc",

"rbwux",

"y",

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
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

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
                Assert.That(model.Id, Is.EqualTo(633323258));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

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
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1142671571));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                Assert.That(model.Id, Is.EqualTo(765745174));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

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
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

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
                Assert.That(model.Id, Is.EqualTo(803365058));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

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
                Assert.That(model.Id, Is.EqualTo(848969540));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

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
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

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
                Assert.That(model.Id, Is.EqualTo(906019819));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

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
                Assert.That(model.Id, Is.EqualTo(971505078));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

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
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

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
                Assert.That(model.Id, Is.EqualTo(1083051525));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

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
                Assert.That(model.Id, Is.EqualTo(1138971227));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

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
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(186045298));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

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
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

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
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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
                Assert.That(model.Id, Is.EqualTo(1458689494));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

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
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

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
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringArraytextArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22955107));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

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
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

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
                Assert.That(model.Id, Is.EqualTo(372944064));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(435538494));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uc",

"rbwux",

"y",

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
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

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
                Assert.That(model.Id, Is.EqualTo(633323258));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

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
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1142671571));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                Assert.That(model.Id, Is.EqualTo(765745174));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

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
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

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
                Assert.That(model.Id, Is.EqualTo(803365058));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

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
                Assert.That(model.Id, Is.EqualTo(848969540));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

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
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

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
                Assert.That(model.Id, Is.EqualTo(906019819));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

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
                Assert.That(model.Id, Is.EqualTo(971505078));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

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
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

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
                Assert.That(model.Id, Is.EqualTo(1083051525));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

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
                Assert.That(model.Id, Is.EqualTo(1138971227));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

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
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(186045298));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

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
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

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
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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
                Assert.That(model.Id, Is.EqualTo(1458689494));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

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
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

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
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringArraytextArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringArraytextArray)this).SetDbConnectionSelectModelParametrs(cmd, 1191490084);
                var models =  ((IStringArraytextArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(18));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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
                Assert.That(model.Id, Is.EqualTo(1458689494));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

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
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

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
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

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
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

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
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringArraytextArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringArraytextArray)this).SetDbConnectionSelectModelParametrs(cmd, 1458689494);
                var models = await ((IStringArraytextArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

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
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

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
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

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
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

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
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

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
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)
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
                 foreach(var batchResult in ((IStringArraytextArray)this).DbConnectionSelectModelBatch(connection, 1138971227, 1765694086))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

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
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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
                Assert.That(model.Id, Is.EqualTo(1458689494));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

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
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

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

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

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
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

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
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

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
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

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
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

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
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

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
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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
                await foreach(var batchResult in ((IStringArraytextArray)this).DbConnectionSelectModelBatchAsync(connection, 1458689494, 1888538551))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

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
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

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
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

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
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

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
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

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
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(3));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

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
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

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
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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
COPY public.binary_stringtextarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(StringtextArray1MI),
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
FROM public.binary_stringtextarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(StringtextArray1MI),
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

                var importCollection = new List<StringtextArray1MI>(7);

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 186045298,
                    Value = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

},
                    NullableValue = 
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 354029252,
                    Value = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 556499630,
                    Value = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

},
                    NullableValue = 
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 659984255,
                    Value = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 728009250,
                    Value = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

},
                    NullableValue = 
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1013321782,
                    Value = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

},
                    NullableValue = 
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

"",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1142671571,
                    Value = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(186045298));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(354029252));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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
                Assert.That(model.Id, Is.EqualTo(556499630));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

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
                Assert.That(model.Id, Is.EqualTo(659984255));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(728009250));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

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
                Assert.That(model.Id, Is.EqualTo(1013321782));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1142671571));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                new StringtextArray1MI
                {
                    Id = 1218420758,
                    Value = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

},
                    NullableValue = 
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1591154332,
                    Value = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

},
                    NullableValue = 
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1686809878,
                    Value = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

},
                    NullableValue = 
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1774224246,
                    Value = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

},
                    NullableValue = 
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1941793093,
                    Value = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1952240378,
                    Value = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

},
                    NullableValue = null
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 1982220787,
                    Value = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

},
                    NullableValue = 
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

}
                });

                importCollection.Add(
                new StringtextArray1MI
                {
                    Id = 2077733773,
                    Value = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

},
                    NullableValue = 
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(186045298));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(354029252));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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
                Assert.That(model.Id, Is.EqualTo(556499630));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

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
                Assert.That(model.Id, Is.EqualTo(659984255));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(728009250));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

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
                Assert.That(model.Id, Is.EqualTo(1013321782));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1142671571));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                Assert.That(model.Id, Is.EqualTo(1218420758));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

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
                Assert.That(model.Id, Is.EqualTo(1591154332));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

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
                Assert.That(model.Id, Is.EqualTo(1686809878));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1774224246));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941793093));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1952240378));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982220787));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

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
                Assert.That(model.Id, Is.EqualTo(2077733773));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
COPY public.binary_stringtextarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtextarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(StringtextArray1M),
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
FROM public.binary_stringtextarray1m m
LEFT JOIN public.binary_stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(StringtextArray1M),
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

                var importCollection = new List<StringtextArray1M>(15);

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 22955107,
                    Value = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

},
                    NullableValue = 
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 372944064,
                    Value = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 435538494,
                    Value = 
new System.String[3]
{
"uc",

"rbwux",

"y",

},
                    NullableValue = 
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 633323258,
                    Value = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

},
                    NullableValue = 
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1142671571
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 765745174,
                    Value = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

},
                    NullableValue = 
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 803365058,
                    Value = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 848969540,
                    Value = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

},
                    NullableValue = 
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 906019819,
                    Value = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 971505078,
                    Value = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

"",

},
                    NullableValue = 
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1083051525,
                    Value = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1138971227,
                    Value = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

},
                    NullableValue = 
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 186045298
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1191490084,
                    Value = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

},
                    NullableValue = 
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1686809878
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1325603064,
                    Value = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

},
                    NullableValue = 
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1325756329,
                    Value = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1358771853,
                    Value = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1774224246
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22955107));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

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
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

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
                Assert.That(model.Id, Is.EqualTo(372944064));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

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

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(435538494));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uc",

"rbwux",

"y",

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
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

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
                Assert.That(model.Id, Is.EqualTo(633323258));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

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
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1142671571));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                Assert.That(model.Id, Is.EqualTo(765745174));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

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
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

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
                Assert.That(model.Id, Is.EqualTo(803365058));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

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
                Assert.That(model.Id, Is.EqualTo(848969540));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

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
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

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
                Assert.That(model.Id, Is.EqualTo(906019819));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

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
                Assert.That(model.Id, Is.EqualTo(971505078));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

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
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

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
                Assert.That(model.Id, Is.EqualTo(1083051525));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

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
                Assert.That(model.Id, Is.EqualTo(1138971227));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

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
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(186045298));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

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
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

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
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                new StringtextArray1M
                {
                    Id = 1434414446,
                    Value = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1458689494,
                    Value = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

},
                    NullableValue = 
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1502743302,
                    Value = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

},
                    NullableValue = 
new System.String[3]
{
"p",

"",

"rgqrnkanw",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 2077733773
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1503157483,
                    Value = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1013321782
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1516292486,
                    Value = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

},
                    NullableValue = 
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 556499630
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1556006550,
                    Value = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

},
                    NullableValue = 
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 659984255
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1591488978,
                    Value = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1982220787
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1634956267,
                    Value = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

},
                    NullableValue = 
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1941793093
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1682634133,
                    Value = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

},
                    NullableValue = 
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1218420758
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1765694086,
                    Value = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1952240378
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1795996085,
                    Value = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

"u",

},
                    NullableValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1888538551,
                    Value = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

},
                    NullableValue = 
new System.String[3]
{
"teay",

"psjroictr",

"vml",

},

                    ModelInner = null

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 1910636045,
                    Value = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

},
                    NullableValue = 
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

},

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 1591154332
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 2099760343,
                    Value = 
new System.String[3]
{
"nfujqy",

"",

"pr",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 728009250
                    }

                });

                importCollection.Add(
                new StringtextArray1M
                {
                    Id = 2111004478,
                    Value = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

},
                    NullableValue = null,

                    ModelInner = new StringtextArray1MI 
                    {
                        Id = 354029252
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(22955107));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

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
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

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
                Assert.That(model.Id, Is.EqualTo(372944064));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

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


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(435538494));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uc",

"rbwux",

"y",

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
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

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
                Assert.That(model.Id, Is.EqualTo(633323258));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

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
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1142671571));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

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
                Assert.That(model.Id, Is.EqualTo(765745174));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

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
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

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
                Assert.That(model.Id, Is.EqualTo(803365058));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

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
                Assert.That(model.Id, Is.EqualTo(848969540));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

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
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

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
                Assert.That(model.Id, Is.EqualTo(906019819));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

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
                Assert.That(model.Id, Is.EqualTo(971505078));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

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
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

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
                Assert.That(model.Id, Is.EqualTo(1083051525));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

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
                Assert.That(model.Id, Is.EqualTo(1138971227));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

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
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(186045298));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

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
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

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
                Assert.That(model.Id, Is.EqualTo(1191490084));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

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
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1686809878));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

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
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

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
                Assert.That(model.Id, Is.EqualTo(1325603064));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

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
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

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
                Assert.That(model.Id, Is.EqualTo(1325756329));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

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
                Assert.That(model.Id, Is.EqualTo(1358771853));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1774224246));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

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
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

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
                Assert.That(model.Id, Is.EqualTo(1434414446));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

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
                Assert.That(model.Id, Is.EqualTo(1458689494));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

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
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

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
                Assert.That(model.Id, Is.EqualTo(1502743302));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

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
new System.String[3]
{
"p",

"",

"rgqrnkanw",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2077733773));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

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
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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
                Assert.That(model.Id, Is.EqualTo(1503157483));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1013321782));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

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
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

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


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516292486));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

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
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(556499630));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

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
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1556006550));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

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
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(659984255));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

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
                Assert.That(model.Id, Is.EqualTo(1591488978));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982220787));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

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
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634956267));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

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
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1941793093));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

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
                Assert.That(model.Id, Is.EqualTo(1682634133));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

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
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1218420758));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

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
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1765694086));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952240378));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

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


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1795996085));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

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

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

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
                Assert.That(model.Id, Is.EqualTo(1888538551));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

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
new System.String[3]
{
"teay",

"psjroictr",

"vml",

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


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910636045));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

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
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1591154332));

                {
                    var expectEnumerValue = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

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
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2099760343));
                {
                    var expectEnumerValue = 
new System.String[3]
{
"nfujqy",

"",

"pr",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(728009250));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

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
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2111004478));
                {
                    var expectEnumerValue = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(354029252));

                {
                    var expectEnumerValue = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

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


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtextarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(StringtextArray1M),
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

                var expected = new Dictionary<System.Int32,StringtextArray1M>(30);

                expected.Add(
                    22955107,
                    new StringtextArray1M
                    {
                        Id = 22955107,
                        Value = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

},
                        NullableValue = 
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    372944064,
                    new StringtextArray1M
                    {
                        Id = 372944064,
                        Value = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    435538494,
                    new StringtextArray1M
                    {
                        Id = 435538494,
                        Value = 
new System.String[3]
{
"uc",

"rbwux",

"y",

},
                        NullableValue = 
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    633323258,
                    new StringtextArray1M
                    {
                        Id = 633323258,
                        Value = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

},
                        NullableValue = 
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1142671571,
                            Value = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    765745174,
                    new StringtextArray1M
                    {
                        Id = 765745174,
                        Value = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

},
                        NullableValue = 
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    803365058,
                    new StringtextArray1M
                    {
                        Id = 803365058,
                        Value = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    848969540,
                    new StringtextArray1M
                    {
                        Id = 848969540,
                        Value = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

},
                        NullableValue = 
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    906019819,
                    new StringtextArray1M
                    {
                        Id = 906019819,
                        Value = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    971505078,
                    new StringtextArray1M
                    {
                        Id = 971505078,
                        Value = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

"",

},
                        NullableValue = 
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1083051525,
                    new StringtextArray1M
                    {
                        Id = 1083051525,
                        Value = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1138971227,
                    new StringtextArray1M
                    {
                        Id = 1138971227,
                        Value = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

},
                        NullableValue = 
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 186045298,
                            Value = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

},
                            NullableValue = 
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

}
                        }

                    }
                );

                expected.Add(
                    1191490084,
                    new StringtextArray1M
                    {
                        Id = 1191490084,
                        Value = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

},
                        NullableValue = 
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1686809878,
                            Value = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

},
                            NullableValue = 
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

}
                        }

                    }
                );

                expected.Add(
                    1325603064,
                    new StringtextArray1M
                    {
                        Id = 1325603064,
                        Value = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

},
                        NullableValue = 
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1325756329,
                    new StringtextArray1M
                    {
                        Id = 1325756329,
                        Value = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1358771853,
                    new StringtextArray1M
                    {
                        Id = 1358771853,
                        Value = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1774224246,
                            Value = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

},
                            NullableValue = 
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

}
                        }

                    }
                );

                expected.Add(
                    1434414446,
                    new StringtextArray1M
                    {
                        Id = 1434414446,
                        Value = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1458689494,
                    new StringtextArray1M
                    {
                        Id = 1458689494,
                        Value = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

},
                        NullableValue = 
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1502743302,
                    new StringtextArray1M
                    {
                        Id = 1502743302,
                        Value = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

},
                        NullableValue = 
new System.String[3]
{
"p",

"",

"rgqrnkanw",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 2077733773,
                            Value = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

},
                            NullableValue = 
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

}
                        }

                    }
                );

                expected.Add(
                    1503157483,
                    new StringtextArray1M
                    {
                        Id = 1503157483,
                        Value = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1013321782,
                            Value = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

},
                            NullableValue = 
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

"",

}
                        }

                    }
                );

                expected.Add(
                    1516292486,
                    new StringtextArray1M
                    {
                        Id = 1516292486,
                        Value = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

},
                        NullableValue = 
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 556499630,
                            Value = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

},
                            NullableValue = 
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

}
                        }

                    }
                );

                expected.Add(
                    1556006550,
                    new StringtextArray1M
                    {
                        Id = 1556006550,
                        Value = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

},
                        NullableValue = 
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 659984255,
                            Value = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1591488978,
                    new StringtextArray1M
                    {
                        Id = 1591488978,
                        Value = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1982220787,
                            Value = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

},
                            NullableValue = 
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

}
                        }

                    }
                );

                expected.Add(
                    1634956267,
                    new StringtextArray1M
                    {
                        Id = 1634956267,
                        Value = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

},
                        NullableValue = 
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1941793093,
                            Value = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1682634133,
                    new StringtextArray1M
                    {
                        Id = 1682634133,
                        Value = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

},
                        NullableValue = 
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1218420758,
                            Value = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

},
                            NullableValue = 
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

}
                        }

                    }
                );

                expected.Add(
                    1765694086,
                    new StringtextArray1M
                    {
                        Id = 1765694086,
                        Value = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1952240378,
                            Value = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1795996085,
                    new StringtextArray1M
                    {
                        Id = 1795996085,
                        Value = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

"u",

},
                        NullableValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1888538551,
                    new StringtextArray1M
                    {
                        Id = 1888538551,
                        Value = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

},
                        NullableValue = 
new System.String[3]
{
"teay",

"psjroictr",

"vml",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1910636045,
                    new StringtextArray1M
                    {
                        Id = 1910636045,
                        Value = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

},
                        NullableValue = 
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1591154332,
                            Value = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

},
                            NullableValue = 
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

}
                        }

                    }
                );

                expected.Add(
                    2099760343,
                    new StringtextArray1M
                    {
                        Id = 2099760343,
                        Value = 
new System.String[3]
{
"nfujqy",

"",

"pr",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 728009250,
                            Value = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

},
                            NullableValue = 
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

}
                        }

                    }
                );

                expected.Add(
                    2111004478,
                    new StringtextArray1M
                    {
                        Id = 2111004478,
                        Value = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 354029252,
                            Value = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

},
                            NullableValue = null
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
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

                var expected = new Dictionary<System.Int32,StringtextArray1M>(30);

                expected.Add(
                    22955107,
                    new StringtextArray1M
                    {
                        Id = 22955107,
                        Value = 
new System.String[4]
{
"gdtlbxrpnytgxgyrct",

"jbwpmlgaedbsjtnircaj",

"jpnwxiphmkwtpaqksn",

"ykgqkafvynxdmnam",

},
                        NullableValue = 
new System.String[3]
{
"v",

"awvxsvejpvvoagshuwluvtoc",

"vkjgyuffyhrpkpkguyrrqxunh",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    372944064,
                    new StringtextArray1M
                    {
                        Id = 372944064,
                        Value = 
new System.String[4]
{
"opsmwb",

"plinqhunpshdkawrbeldxgp",

"nq",

"dkhqndlldr",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    435538494,
                    new StringtextArray1M
                    {
                        Id = 435538494,
                        Value = 
new System.String[3]
{
"uc",

"rbwux",

"y",

},
                        NullableValue = 
new System.String[3]
{
"uiipcffqcqbxwvqffnv",

"td",

"qctcrbhtnxkmlwrcukiddgllnb",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    633323258,
                    new StringtextArray1M
                    {
                        Id = 633323258,
                        Value = 
new System.String[4]
{
"bhftdt",

"wthe",

"mscsjysrqckyonwypdkw",

"djmi",

},
                        NullableValue = 
new System.String[3]
{
"wfh",

"unebnjsjbgiikeehxkq",

"rcbputkenkbxilpbpfsughxjkcev",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1142671571,
                            Value = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    765745174,
                    new StringtextArray1M
                    {
                        Id = 765745174,
                        Value = 
new System.String[4]
{
"jgusjwrxinxwjeetqcjew",

"xnunbhfset",

"doymmsdiq",

"x",

},
                        NullableValue = 
new System.String[3]
{
"frogavk",

"lwovdrbxtufrgotet",

"amesqtp",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    803365058,
                    new StringtextArray1M
                    {
                        Id = 803365058,
                        Value = 
new System.String[3]
{
"veysmtsoigdfqbhtf",

"oaaanddluneoprmehbxiqkgmsojdn",

"nlejwrhiidgtndyflsnivfijrsn",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    848969540,
                    new StringtextArray1M
                    {
                        Id = 848969540,
                        Value = 
new System.String[3]
{
"nhivbbiqh",

"tayocxkvt",

"cjwqisbf",

},
                        NullableValue = 
new System.String[4]
{
"unhgmxsexggsyddvlurrrxd",

"iaxhjtdokfwyfhrkmpfvusahrrdpc",

"yybibcvhsfjslawyqttcywr",

"fseybljdwyddwnoyipdccoynot",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    906019819,
                    new StringtextArray1M
                    {
                        Id = 906019819,
                        Value = 
new System.String[4]
{
"ohjhikpurms",

"tvyhdilwtvtihjdtymbqnwekxml",

"ag",

"fismgeppycxeyyiv",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    971505078,
                    new StringtextArray1M
                    {
                        Id = 971505078,
                        Value = 
new System.String[4]
{
"jjmpttlhnwpqyoeucqeaqdoouxthh",

"ykqxlouvpixusogkdkluvenr",

"rmoogpvp",

"",

},
                        NullableValue = 
new System.String[4]
{
"bhtcicspnvmhocwlcvnfr",

"dkleqsmyiaoyfcddvlwhnmh",

"yrghwqrfoew",

"otdtofbcplhkvosoxyqinsqsa",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1083051525,
                    new StringtextArray1M
                    {
                        Id = 1083051525,
                        Value = 
new System.String[4]
{
"qswubofhew",

"",

"ly",

"dooeic",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1138971227,
                    new StringtextArray1M
                    {
                        Id = 1138971227,
                        Value = 
new System.String[3]
{
"vojiotnljhvnwptttuvf",

"qbuhiqovqn",

"majbfnqeuhux",

},
                        NullableValue = 
new System.String[3]
{
"",

"ligfluouefgt",

"sqlqgaocde",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 186045298,
                            Value = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

},
                            NullableValue = 
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

}
                        }

                    }
                );

                expected.Add(
                    1191490084,
                    new StringtextArray1M
                    {
                        Id = 1191490084,
                        Value = 
new System.String[4]
{
"pvslnoqfhxbjgjgvtewjfxwjtwh",

"viojbqsjtuoukjxpdvrdlmi",

"apbldssonggxwy",

"immajhigbodsxlqvhjcsne",

},
                        NullableValue = 
new System.String[4]
{
"gqmfcswakhbj",

"xgtfeqduujbwfxrsrvbguls",

"iwjw",

"gmoorsnfcmhcnocxtytdvh",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1686809878,
                            Value = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

},
                            NullableValue = 
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

}
                        }

                    }
                );

                expected.Add(
                    1325603064,
                    new StringtextArray1M
                    {
                        Id = 1325603064,
                        Value = 
new System.String[3]
{
"rcpiwjlbjmrcqnirflwegilyxqorl",

"lpveju",

"kheiwyavxiamnxjekgdnm",

},
                        NullableValue = 
new System.String[4]
{
"sjduibot",

"otskfaicmfyben",

"mywqli",

"rxbyw",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1325756329,
                    new StringtextArray1M
                    {
                        Id = 1325756329,
                        Value = 
new System.String[3]
{
"o",

"odoxomuvqxsmaub",

"kxqgtiohqlirnxbfqxgaafmwqk",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1358771853,
                    new StringtextArray1M
                    {
                        Id = 1358771853,
                        Value = 
new System.String[4]
{
"nuqvvlorbcyshmseloixk",

"dpeswyxqknyelccosmusvse",

"plblehlsgmirodpl",

"prgiwfptasohcbnclvjbiecbi",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1774224246,
                            Value = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

},
                            NullableValue = 
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

}
                        }

                    }
                );

                expected.Add(
                    1434414446,
                    new StringtextArray1M
                    {
                        Id = 1434414446,
                        Value = 
new System.String[3]
{
"bjkuvwpmxdurf",

"ugppgws",

"khaignjdja",

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1458689494,
                    new StringtextArray1M
                    {
                        Id = 1458689494,
                        Value = 
new System.String[4]
{
"lvlxtwi",

"ukqywiaepgruougvjijehs",

"nqyhduilnyatarwu",

"uxfegeml",

},
                        NullableValue = 
new System.String[3]
{
"aiwrbyakixojvgoclhwkbmc",

"aanreblrlbtiof",

"ueoduovwribqnohmovxpukqath",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1502743302,
                    new StringtextArray1M
                    {
                        Id = 1502743302,
                        Value = 
new System.String[4]
{
"nnbcqogu",

"cexiycmuiovcyhyvoh",

"ascymocdauxfd",

"agojjkbuxgdmucmchwvpcryrhwp",

},
                        NullableValue = 
new System.String[3]
{
"p",

"",

"rgqrnkanw",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 2077733773,
                            Value = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

},
                            NullableValue = 
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

}
                        }

                    }
                );

                expected.Add(
                    1503157483,
                    new StringtextArray1M
                    {
                        Id = 1503157483,
                        Value = 
new System.String[4]
{
"opktwbhee",

"fbreyabyxnf",

"ytrhwhxmslnpsdublykianqn",

"phvmyqmeipyixnjrtpbuip",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1013321782,
                            Value = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

},
                            NullableValue = 
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

"",

}
                        }

                    }
                );

                expected.Add(
                    1516292486,
                    new StringtextArray1M
                    {
                        Id = 1516292486,
                        Value = 
new System.String[3]
{
"i",

"kfysdkchqwfeflswktu",

"mpom",

},
                        NullableValue = 
new System.String[3]
{
"",

"ffhmuvedmchwcpgposralwaikh",

"kydxlsecsulyyntcdbtbrklscpgoo",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 556499630,
                            Value = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

},
                            NullableValue = 
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

}
                        }

                    }
                );

                expected.Add(
                    1556006550,
                    new StringtextArray1M
                    {
                        Id = 1556006550,
                        Value = 
new System.String[3]
{
"mpgxctajfsjrrmkpculea",

"fodftqjhjxrnuuqmplbpblnbrkx",

"ipjrbmrqiwvlmuicuvwqomaubuol",

},
                        NullableValue = 
new System.String[4]
{
"jtpkxvmmdrfhogkqhbdx",

"yxnmcsaeskkrhramisuqwimvkgkhv",

"siplwaaicvnrrgvabrvyfj",

"vymapttqshouijtmoysk",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 659984255,
                            Value = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1591488978,
                    new StringtextArray1M
                    {
                        Id = 1591488978,
                        Value = 
new System.String[3]
{
"ciblmaxclnrajycxsu",

"btpvmjniqbaj",

"wnvvyygfqvtueensfijqixr",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1982220787,
                            Value = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

},
                            NullableValue = 
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

}
                        }

                    }
                );

                expected.Add(
                    1634956267,
                    new StringtextArray1M
                    {
                        Id = 1634956267,
                        Value = 
new System.String[3]
{
"fnruehgbxgodjlkubpna",

"mpupkfadmnxtgvtjpejns",

"hqwxrerql",

},
                        NullableValue = 
new System.String[4]
{
"qeqnywjqyjqvqbwjfxbjaqeahr",

"ws",

"wbnlttuqiginweddhegdiffwjpi",

"wicrjqxlebuviohaqkkcrbhvil",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1941793093,
                            Value = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1682634133,
                    new StringtextArray1M
                    {
                        Id = 1682634133,
                        Value = 
new System.String[4]
{
"ofrgkkvxlabgoc",

"pwxjiofwhhndxdgnda",

"",

"inysvlphewqpkuchunqohthwj",

},
                        NullableValue = 
new System.String[3]
{
"uorptuarrktnsxeaglylpwrnylf",

"onbqm",

"xjupglrofoxbwtk",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1218420758,
                            Value = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

},
                            NullableValue = 
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

}
                        }

                    }
                );

                expected.Add(
                    1765694086,
                    new StringtextArray1M
                    {
                        Id = 1765694086,
                        Value = 
new System.String[4]
{
"qokchbpmmfngbhlqi",

"futnwabrgeoja",

"ugghmqaqf",

"ewqolqtjdpahyhvqtbnwbe",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1952240378,
                            Value = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1795996085,
                    new StringtextArray1M
                    {
                        Id = 1795996085,
                        Value = 
new System.String[3]
{
"uvxfnwdujuignlfdhsvarevuplaa",

"ettryvbu",

"u",

},
                        NullableValue = 
new System.String[3]
{
"fcft",

"yuwufwkudraadxuqglaeryms",

"htxcrxakdqau",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1888538551,
                    new StringtextArray1M
                    {
                        Id = 1888538551,
                        Value = 
new System.String[3]
{
"dsufbwvsaltknbitxw",

"ashaplwwjpesuibasqnxslmqola",

"tdnbfmejpwfdpvgolejrpbfvqsmw",

},
                        NullableValue = 
new System.String[3]
{
"teay",

"psjroictr",

"vml",

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1910636045,
                    new StringtextArray1M
                    {
                        Id = 1910636045,
                        Value = 
new System.String[3]
{
"nqwlexgejviipclsywcdjdwb",

"qfhopidwctryty",

"cdkegqisugtxrxbnqxjb",

},
                        NullableValue = 
new System.String[4]
{
"iiynyucccoasicldbwhqpq",

"cogaalhoewhajwcelvayac",

"slsiwufbeosxmxlcc",

"rqajvdrcwnkrmfqhstlv",

},

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 1591154332,
                            Value = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

},
                            NullableValue = 
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

}
                        }

                    }
                );

                expected.Add(
                    2099760343,
                    new StringtextArray1M
                    {
                        Id = 2099760343,
                        Value = 
new System.String[3]
{
"nfujqy",

"",

"pr",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 728009250,
                            Value = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

},
                            NullableValue = 
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

}
                        }

                    }
                );

                expected.Add(
                    2111004478,
                    new StringtextArray1M
                    {
                        Id = 2111004478,
                        Value = 
new System.String[4]
{
"pvhabcpwh",

"dnpddoxociecfntgtksk",

"hcyksdixgwuowdx",

"rbdplcsbcvelljytplxctwenhd",

},
                        NullableValue = null,

                        ModelInner = new StringtextArray1MI
                        {
                            Id = 354029252,
                            Value = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

},
                            NullableValue = null
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.String[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(StringtextArray1MI),
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

                var expected = new Dictionary<System.Int32,StringtextArray1MI>(15);

                expected.Add(
                    186045298,
                    new StringtextArray1MI
                    {
                        Id = 186045298,
                        Value = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

},
                        NullableValue = 
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

}
                    }
                );

                expected.Add(
                    354029252,
                    new StringtextArray1MI
                    {
                        Id = 354029252,
                        Value = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    556499630,
                    new StringtextArray1MI
                    {
                        Id = 556499630,
                        Value = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

},
                        NullableValue = 
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

}
                    }
                );

                expected.Add(
                    659984255,
                    new StringtextArray1MI
                    {
                        Id = 659984255,
                        Value = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    728009250,
                    new StringtextArray1MI
                    {
                        Id = 728009250,
                        Value = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

},
                        NullableValue = 
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

}
                    }
                );

                expected.Add(
                    1013321782,
                    new StringtextArray1MI
                    {
                        Id = 1013321782,
                        Value = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

},
                        NullableValue = 
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

"",

}
                    }
                );

                expected.Add(
                    1142671571,
                    new StringtextArray1MI
                    {
                        Id = 1142671571,
                        Value = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1218420758,
                    new StringtextArray1MI
                    {
                        Id = 1218420758,
                        Value = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

},
                        NullableValue = 
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

}
                    }
                );

                expected.Add(
                    1591154332,
                    new StringtextArray1MI
                    {
                        Id = 1591154332,
                        Value = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

},
                        NullableValue = 
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

}
                    }
                );

                expected.Add(
                    1686809878,
                    new StringtextArray1MI
                    {
                        Id = 1686809878,
                        Value = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

},
                        NullableValue = 
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

}
                    }
                );

                expected.Add(
                    1774224246,
                    new StringtextArray1MI
                    {
                        Id = 1774224246,
                        Value = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

},
                        NullableValue = 
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

}
                    }
                );

                expected.Add(
                    1941793093,
                    new StringtextArray1MI
                    {
                        Id = 1941793093,
                        Value = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1952240378,
                    new StringtextArray1MI
                    {
                        Id = 1952240378,
                        Value = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1982220787,
                    new StringtextArray1MI
                    {
                        Id = 1982220787,
                        Value = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

},
                        NullableValue = 
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

}
                    }
                );

                expected.Add(
                    2077733773,
                    new StringtextArray1MI
                    {
                        Id = 2077733773,
                        Value = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

},
                        NullableValue = 
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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

                var expected = new Dictionary<System.Int32,StringtextArray1MI>(15);

                expected.Add(
                    186045298,
                    new StringtextArray1MI
                    {
                        Id = 186045298,
                        Value = 
new System.String[4]
{
"wyqochly",

"vttxwuhouxvw",

"rqrbsiwgxnnq",

"vpjscxuudjhdhtnvu",

},
                        NullableValue = 
new System.String[4]
{
"qpqihfmervfotfocrjrra",

"jttcpihis",

"ilriuw",

"byrp",

}
                    }
                );

                expected.Add(
                    354029252,
                    new StringtextArray1MI
                    {
                        Id = 354029252,
                        Value = 
new System.String[4]
{
"aujeuvksnvfg",

"ltw",

"",

"rwdaxyheoanvdabvfnpgtmbmbtc",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    556499630,
                    new StringtextArray1MI
                    {
                        Id = 556499630,
                        Value = 
new System.String[4]
{
"vqwyialchlnulrpgvsdxk",

"elhqupkksgsbylg",

"wbhaiyf",

"danmhiyqdqdlieh",

},
                        NullableValue = 
new System.String[3]
{
"cptjtymaakmsastwxexj",

"kbavrsgbhhacdowqifuflya",

"ljuhchgllkwldhsqjxeqpgjt",

}
                    }
                );

                expected.Add(
                    659984255,
                    new StringtextArray1MI
                    {
                        Id = 659984255,
                        Value = 
new System.String[3]
{
"mfsyvouegvvy",

"bhk",

"sqlkmxnmt",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    728009250,
                    new StringtextArray1MI
                    {
                        Id = 728009250,
                        Value = 
new System.String[4]
{
"unuagoerukroxoylgcbqmbnsmdj",

"kgpiefpwxtntghbpex",

"",

"icumwqmifxeddfpw",

},
                        NullableValue = 
new System.String[3]
{
"",

"hxamwbquwrbjrjjqnbjxj",

"yjbtbwcgmaowfxiyhba",

}
                    }
                );

                expected.Add(
                    1013321782,
                    new StringtextArray1MI
                    {
                        Id = 1013321782,
                        Value = 
new System.String[3]
{
"ikr",

"apcwfelldhvldxobr",

"a",

},
                        NullableValue = 
new System.String[3]
{
"dxtivexgtreidapgrbucpdjshkbkn",

"oagsbaimfilmidlfysxryuejbp",

"",

}
                    }
                );

                expected.Add(
                    1142671571,
                    new StringtextArray1MI
                    {
                        Id = 1142671571,
                        Value = 
new System.String[4]
{
"",

"icsasfbxikfdwjcrd",

"svjgeuwfyibtrmapp",

"tvtctlbioy",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1218420758,
                    new StringtextArray1MI
                    {
                        Id = 1218420758,
                        Value = 
new System.String[4]
{
"reegqpgktmxv",

"ehoupxejkkdjio",

"vdiaipthnlbupueyca",

"dweprwttssaxg",

},
                        NullableValue = 
new System.String[3]
{
"qqdnjcwpftkiusc",

"mch",

"doyvvkaw",

}
                    }
                );

                expected.Add(
                    1591154332,
                    new StringtextArray1MI
                    {
                        Id = 1591154332,
                        Value = 
new System.String[3]
{
"wtcnjmsaglpldke",

"pwtrdmjfvyqwodmwhrgeb",

"gpsgiopqstcanucqqwl",

},
                        NullableValue = 
new System.String[3]
{
"fypmhmeqmncredjd",

"",

"ymnhemn",

}
                    }
                );

                expected.Add(
                    1686809878,
                    new StringtextArray1MI
                    {
                        Id = 1686809878,
                        Value = 
new System.String[4]
{
"fwbcbnytisslusg",

"wwgvwudjwrssjdmchjcfwivhld",

"yo",

"ccevfpwbjllexdlxivdgamyuuo",

},
                        NullableValue = 
new System.String[3]
{
"tjjboiv",

"t",

"yebl",

}
                    }
                );

                expected.Add(
                    1774224246,
                    new StringtextArray1MI
                    {
                        Id = 1774224246,
                        Value = 
new System.String[3]
{
"aujmcnm",

"xynhkvkdpwbiypltwwfdcat",

"avdqjttfjncnofdreih",

},
                        NullableValue = 
new System.String[4]
{
"yyybbqtfob",

"uvtsyjehqcjntij",

"fllvaro",

"msldnbanaufibc",

}
                    }
                );

                expected.Add(
                    1941793093,
                    new StringtextArray1MI
                    {
                        Id = 1941793093,
                        Value = 
new System.String[4]
{
"xqhicwjqf",

"lncafaehsijafmmxghh",

"lluribkxwvbvhyjaldgaqplyllr",

"eeolsrygyerlpwuyjkgsln",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1952240378,
                    new StringtextArray1MI
                    {
                        Id = 1952240378,
                        Value = 
new System.String[4]
{
"nawgywmwqjnupfrcsesm",

"gopfxtpxasnhlqqydgyfqklnqhga",

"ndmrofpabale",

"reassnybbs",

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1982220787,
                    new StringtextArray1MI
                    {
                        Id = 1982220787,
                        Value = 
new System.String[3]
{
"tttuyjvwehcwphclhxhfxquijib",

"asddfbikilsfehi",

"",

},
                        NullableValue = 
new System.String[4]
{
"ftdubeoeattnsxrjotse",

"yuqeqmpm",

"twpxtsiwvwutxfndgaujv",

"pfuxf",

}
                    }
                );

                expected.Add(
                    2077733773,
                    new StringtextArray1MI
                    {
                        Id = 2077733773,
                        Value = 
new System.String[4]
{
"xgxkuullocmunuwnjovcd",

"qlgwefmlepb",

"huvuytl",

"ydwmsf",

},
                        NullableValue = 
new System.String[4]
{
"irplmml",

"uvgv",

"thfghlleivwwsrteswe",

"htjlen",

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

