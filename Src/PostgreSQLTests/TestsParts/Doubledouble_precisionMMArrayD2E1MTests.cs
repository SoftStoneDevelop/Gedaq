

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD2
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD2 : IDoubleMArraydouble_precisionMMArrayD2
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD2E1M[] _testData = new Doubledouble_precisionMMArrayD2E1M[]
        {
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 4,
    Value = 
new System.Double[,] { {
0.5709916268160748d,
0.2409523545205574d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 6,
    Value = 
new System.Double[,] { {
0.8647760264486651d,
0.17958003546141765d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Double[,] { {
0.48778828701078114d,
0.5938765026583731d, } },
    NullableValue = 
new System.Double[,] { {
0.8783192975106905d,
0.48264618498341894d, } },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Double[,] { {
0.17749015666481005d,
0.2160586791997975d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.3344542148559755d,
0.03206694464282622d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Double[,] { {
0.4460262732475463d,
0.5133381759324425d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Double[,] { {
0.7854876855118715d,
0.1928444199860826d, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Double[,] { {
0.134064553860191d,
0.9948116933832363d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Double[,] { {
0.9405809531379378d,
0.3937029911518155d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Double[,] { {
0.17510808671788003d,
0.9186204675957127d, } },
    NullableValue = 
new System.Double[,] { {
0.12366134213933155d,
0.8476204635127031d, } },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Double[,] { {
0.26404968166418674d,
0.30418830255982754d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Double[,] { {
0.8468743466302616d,
0.8534131121576386d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Double[,] { {
0.0481741789129736d,
0.28028151893165965d, } },
    NullableValue = 
new System.Double[,] { {
0.6960337403294488d,
0.6050445288703304d, } },
},
    NullableValue = 
new System.Double[,] { {
0.7382189198869187d,
0.3580722255071901d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Double[,] { {
0.18675647514139682d,
0.782495573362094d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.8141395931814863d,
0.6589892489346032d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Double[,] { {
0.031687751404894104d,
0.039220230869026484d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Double[,] { {
0.21805002763118286d,
0.847572767127986d, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Double[,] { {
0.28117932765521536d,
0.5631867635047794d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.8300482879480189d,
0.2061457489303239d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Double[,] { {
0.12430393823397357d,
0.02075608211752722d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Double[,] { {
0.03679856519398339d,
0.8861361616973146d, } },
    NullableValue = 
new System.Double[,] { {
0.33272245638388465d,
0.413965615923811d, } },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Double[,] { {
0.430106032091628d,
0.7218672583508502d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.07934151078253637d,
0.6034695888557816d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Double[,] { {
0.6069625796265307d,
0.24652258625381762d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Double[,] { {
0.8283920330310738d,
0.2358094110165041d, } },
    NullableValue = 
new System.Double[,] { {
0.85249828167143d,
0.7347111796245124d, } },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Double[,] { {
0.06684718586527827d,
0.6670602677995822d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Double[,] { {
0.9845745651192803d,
0.6700708942243174d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Double[,] { {
0.5259696483312217d,
0.8183364754013867d, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Double[,] { {
0.44333785008324567d,
0.00021458655998007892d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Double[,] { {
0.28674041721886645d,
0.6183873095840559d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Double[,] { {
0.846790958447072d,
0.32686650099565273d, } },
    NullableValue = 
new System.Double[,] { {
0.6258384771834996d,
0.9323661775135036d, } },
},
    NullableValue = 
new System.Double[,] { {
0.5243076127694221d,
0.08592139967379686d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Double[,] { {
0.7908279977817856d,
0.08067012567603415d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.2154291982505927d,
0.07720527237633024d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Double[,] { {
0.22897400609927765d,
0.7164849050032086d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Double[,] { {
0.8273902666567995d,
0.2628088823357807d, } },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { {
0.9957212328241075d,
0.05799495745879146d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Double[,] { {
0.42097780092975745d,
0.38481544794830136d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Double[,] { {
0.6074304388718202d,
0.28209262338064955d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Double[,] { {
0.8646483309982975d,
0.7618561980029316d, } },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { {
0.8028576707931453d,
0.09296624017118116d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Double[,] { {
0.3973799846241748d,
0.2639751438868365d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Double[,] { {
0.9491939765348428d,
0.4445882498332363d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Double[,] { {
0.06089339298418084d,
0.0725066913077832d, } },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { {
0.15362233714702345d,
0.10750970009463279d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Double[,] { {
0.22194925053626313d,
0.9634355448981228d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Double[,] { {
0.942360991775002d,
0.7846913505578879d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Double[,] { {
0.8159527783356483d,
0.07365576941563867d, } },
    NullableValue = 
new System.Double[,] { {
0.11391256961308383d,
0.4600678762762238d, } },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Double[,] { {
0.5380825683872731d,
0.5795171673099249d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.9332965986421012d,
0.9632830610609274d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Double[,] { {
0.12353593870144286d,
0.09767813448120066d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Double[,] { {
0.8178953680986941d,
0.9366098054101604d, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Double[,] { {
0.889780497745528d,
0.8038358984017099d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Double[,] { {
0.6552274078121421d,
0.19122782466842214d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Double[,] { {
0.3764372062352017d,
0.3608446157764217d, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Double[,] { {
0.9036240816749347d,
0.5230519755331199d, } },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Double[,] { {
0.9859818019263151d,
0.00829682261123077d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Double[,] { {
0.28906292090876184d,
0.7398017009523329d, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Double[,] { {
0.30287382109056915d,
0.3368038390442659d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.1579114500890848d,
0.4224812881957809d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Double[,] { {
0.0400348172769216d,
0.5850086875635563d, } },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Double[,] { {
0.24722813921690978d,
0.2712090861633788d, } },
    NullableValue = 
new System.Double[,] { {
0.04915444963120119d,
0.6026847453276827d, } },
},
    NullableValue = 
new System.Double[,] { {
0.056358714231599105d,
0.057008594519391d, } },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Double[,] { {
0.2210522450263338d,
0.9323779792251291d, } },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { {
0.5403217205585545d,
0.6647650834453299d, } },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { {
0.7382189198869187d,
0.3580722255071901d, } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                System.Double[,] nullable = null;
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { {
0.8141395931814863d,
0.6589892489346032d, } }));
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[,] nullable = null;
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { {
0.8300482879480189d,
0.2061457489303239d, } }));
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 128, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 113, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 110, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 4, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 61, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 119, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 128, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
FROM public.binary_doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI), typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

