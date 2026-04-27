

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 3,
    Value = 
new System.Int64[3]
{
8487773555660354126L,
6282607712068074116L,
4168024698014345370L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 5,
    Value = 
new System.Int64[4]
{
7437819988671058621L,
3134676633911787224L,
5065102669183731961L,
985297952896826644L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 3,
    Value = 
new System.Int64[4]
{
2291179063964269449L,
7869192218320252421L,
8196488739903399802L,
7816436474147015569L,
},
    NullableValue = 
new System.Int64[3]
{
7316936228294894038L,
5247638814475229665L,
8887034191849106060L,
},
},
    NullableValue = 
new System.Int64[4]
{
5386456333676058044L,
3207794530277471658L,
2000043176533715587L,
4049622192116783611L,
},
},
            new Int64bigintArray1M
{
    Id = 7,
    Value = 
new System.Int64[4]
{
4105469642964949370L,
8500420165045077954L,
5241124997163532201L,
8209207501665535758L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 8,
    Value = 
new System.Int64[4]
{
4977970139657481075L,
6341422539571986036L,
800273419758953326L,
6997937049257071002L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 11,
    Value = 
new System.Int64[4]
{
8703432471752528245L,
4111680760223121248L,
3774261916931391575L,
1351219828693861829L,
},
    NullableValue = 
new System.Int64[4]
{
7966697908029208861L,
8243126674267071369L,
6895776098160871852L,
4658196621396779613L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 15,
    Value = 
new System.Int64[4]
{
3083564076723088797L,
5141948436989613699L,
1252414120655924756L,
1649069119203756374L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 23,
    Value = 
new System.Int64[4]
{
2559148229974467701L,
6793876123713864196L,
305062916105986011L,
166570130243388281L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 15,
    Value = 
new System.Int64[4]
{
1236900026563602740L,
401426417949662504L,
7431351570404696835L,
7153361673228957895L,
},
    NullableValue = 
new System.Int64[4]
{
581337098523111451L,
5031857580913369643L,
4798265628934652031L,
3561137418935570913L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 32,
    Value = 
new System.Int64[3]
{
2239603702377915087L,
5661472234998514885L,
4805966555209568693L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
857220287081791632L,
7205537375065926798L,
3479431108655793973L,
1662259116373805915L,
},
},
            new Int64bigintArray1M
{
    Id = 37,
    Value = 
new System.Int64[3]
{
7429793842129770779L,
8353772121463339560L,
881181297096808938L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 16,
    Value = 
new System.Int64[4]
{
4464489535891309321L,
209009459304533194L,
549219501852916976L,
5177676965136810185L,
},
    NullableValue = 
new System.Int64[3]
{
701077257340874783L,
7900809043210327583L,
3277456229353181326L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 42,
    Value = 
new System.Int64[3]
{
8782051764614373260L,
3452667771433311284L,
6651662704418260521L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4400450898252984302L,
3676977090179885577L,
4360028165651155113L,
},
},
            new Int64bigintArray1M
{
    Id = 45,
    Value = 
new System.Int64[3]
{
1510675463700952030L,
400103265757190959L,
8125511052713628613L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 20,
    Value = 
new System.Int64[4]
{
1902578021426317815L,
3345225387368602432L,
4943039857102663028L,
7000491735230899089L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 48,
    Value = 
new System.Int64[4]
{
6741185385737296500L,
1165086019574845269L,
8028682195952012899L,
7225705940659941961L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 52,
    Value = 
new System.Int64[3]
{
8177333531240798575L,
2030351188618858653L,
734951306216451537L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 28,
    Value = 
new System.Int64[4]
{
7650431373444447803L,
9055803664556211098L,
6920755550476353312L,
1296435010980356719L,
},
    NullableValue = 
new System.Int64[4]
{
7130500204285488592L,
2973499295233043542L,
2436257342796459360L,
6310678872239682512L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 53,
    Value = 
new System.Int64[3]
{
8835300790650374264L,
3829258385010258729L,
6911300773253567048L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 61,
    Value = 
new System.Int64[4]
{
3296793865390042965L,
6341991674992688042L,
7908835242608671990L,
1168203148714910614L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 35,
    Value = 
new System.Int64[4]
{
1553967640976205009L,
175229148895244606L,
265816591650282232L,
8333913158311695770L,
},
    NullableValue = 
new System.Int64[4]
{
1605372210470851474L,
7030421109735999061L,
9096334484437773850L,
7549030259809631622L,
},
},
    NullableValue = 
new System.Int64[4]
{
6484676950511031506L,
5500538618069979356L,
1739458568836254835L,
2447168068858567351L,
},
},
            new Int64bigintArray1M
{
    Id = 66,
    Value = 
new System.Int64[3]
{
2338655093236942981L,
3975844243873042837L,
5676632311717494007L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2075568935520506320L,
8658810301690579701L,
7432075916481633236L,
},
},
            new Int64bigintArray1M
{
    Id = 69,
    Value = 
new System.Int64[4]
{
901745847070592171L,
3098935965216585385L,
1870657276365727164L,
2013465307131158123L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 42,
    Value = 
new System.Int64[3]
{
7123859573501179397L,
3107921830247091549L,
8035983789215954087L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 75,
    Value = 
new System.Int64[3]
{
7372964922774674923L,
3364861662139869688L,
321209842675145116L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 82,
    Value = 
new System.Int64[4]
{
3945046641153495695L,
3291538343808534772L,
2226620177805891258L,
3614733007507249230L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 49,
    Value = 
new System.Int64[3]
{
9045923243105895124L,
6948734191440264462L,
8083961356268411535L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1753773668698638969L,
5454385977690747220L,
3002898853666824449L,
1877567611692105339L,
},
},
            new Int64bigintArray1M
{
    Id = 88,
    Value = 
new System.Int64[3]
{
720481211523133261L,
7082611823733044192L,
509793720835252957L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
2653418801061394786L,
4945554944007365968L,
2942660832111392934L,
4029865001693881133L,
},
},
            new Int64bigintArray1M
{
    Id = 93,
    Value = 
new System.Int64[3]
{
4837314292912228300L,
5143603095306261306L,
237328660215543021L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 55,
    Value = 
new System.Int64[3]
{
2418811124788699212L,
3449699907995751330L,
5329438077545629505L,
},
    NullableValue = 
new System.Int64[3]
{
5383153960704930978L,
4110587903489088635L,
4770095728307888027L,
},
},
    NullableValue = 
new System.Int64[3]
{
5993083091233293498L,
5874559360128313726L,
1585840845491314596L,
},
},
            new Int64bigintArray1M
{
    Id = 101,
    Value = 
new System.Int64[3]
{
1407103815496623663L,
466820680422521331L,
3848190639193981317L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1511585404748830227L,
3322813411255709182L,
2931839944276549320L,
8917013404505149329L,
},
},
            new Int64bigintArray1M
{
    Id = 104,
    Value = 
new System.Int64[4]
{
7699151308701850926L,
1790394760980772108L,
4166246095003038307L,
5935871659339336678L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 56,
    Value = 
new System.Int64[3]
{
5318497684136848257L,
8634875499741569233L,
9187048439635120896L,
},
    NullableValue = 
new System.Int64[4]
{
1690040913196402103L,
6371861289914025947L,
5586330763878095223L,
1375484111774027673L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 113,
    Value = 
new System.Int64[4]
{
8590672602454277327L,
4739692853240959876L,
2970485827318737412L,
4267288049000809321L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 114,
    Value = 
new System.Int64[4]
{
3530776586556765157L,
5447684355278962807L,
7605877370183038300L,
6888137069244122395L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 58,
    Value = 
new System.Int64[4]
{
8559568805114871967L,
1957404719790393273L,
337600146940893353L,
122448010565919059L,
},
    NullableValue = 
new System.Int64[3]
{
4465252625592476960L,
4614158398145915203L,
3501457766681419322L,
},
},
    NullableValue = 
new System.Int64[4]
{
1637355900915410612L,
2540011414039763519L,
6156903330475914613L,
7669497305572936199L,
},
},
            new Int64bigintArray1M
{
    Id = 118,
    Value = 
new System.Int64[3]
{
6164573689746608258L,
8585329280229792067L,
4202927760608419724L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 121,
    Value = 
new System.Int64[4]
{
5032791303318619764L,
6933987874466282363L,
1038255849804057422L,
1105414633487915172L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 65,
    Value = 
new System.Int64[4]
{
6569292421567496691L,
2649407755800721605L,
738086493908703680L,
4264019105050976001L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2208749677096533575L,
510438378210846686L,
2822693745178320052L,
},
},
            new Int64bigintArray1M
{
    Id = 130,
    Value = 
new System.Int64[3]
{
3934395699828941223L,
2524869892804304647L,
3260155981488713615L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 132,
    Value = 
new System.Int64[3]
{
2552883854338424131L,
2173037078645558601L,
7950561140806666442L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 71,
    Value = 
new System.Int64[4]
{
5976926066910098551L,
5708453663173151836L,
4425634638622769561L,
6714290786712304424L,
},
    NullableValue = 
new System.Int64[4]
{
5452937638832024689L,
4960614538763152938L,
4707914811694021416L,
2037161975036030129L,
},
},
    NullableValue = 
new System.Int64[4]
{
1763747773057411782L,
3168281601327555292L,
4475238885472980094L,
2485645304065494174L,
},
},
            new Int64bigintArray1M
{
    Id = 139,
    Value = 
new System.Int64[4]
{
1123856607540175380L,
2393227181147130375L,
8747958158468658963L,
4765957640205714887L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
618955183369829612L,
3089630399831456143L,
1523044397033812662L,
4699875707253742273L,
},
},
            new Int64bigintArray1M
{
    Id = 141,
    Value = 
new System.Int64[3]
{
2962216579440442639L,
8850835696070417169L,
2812844392371365683L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 75,
    Value = 
new System.Int64[3]
{
1583609081639803344L,
2711324310727528962L,
436422076791364085L,
},
    NullableValue = 
new System.Int64[4]
{
8393912576939549121L,
107330901628252707L,
608635975523758734L,
5516957787040339567L,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
857220287081791632L,
7205537375065926798L,
3479431108655793973L,
1662259116373805915L,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                System.Int64[] nullable = null;
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
4400450898252984302L,
3676977090179885577L,
4360028165651155113L,
}));
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintArray1M.AssertModel(models[0],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[29], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintArray1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 118, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 66, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 118, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 118, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[29], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 69, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintArray1M.AssertModel(models[0],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintArray1M.AssertModel(models[0],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Int64bigintArray1M.AssertModel(models[0],_testData[21], false);Int64bigintArray1M.AssertModel(models[1],_testData[22], false);Int64bigintArray1M.AssertModel(models[2],_testData[23], false);Int64bigintArray1M.AssertModel(models[3],_testData[24], false);Int64bigintArray1M.AssertModel(models[4],_testData[25], false);Int64bigintArray1M.AssertModel(models[5],_testData[26], false);Int64bigintArray1M.AssertModel(models[6],_testData[27], false);Int64bigintArray1M.AssertModel(models[7],_testData[28], false);Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Int64bigintArray1M.AssertModel(models[0],_testData[27], false);Int64bigintArray1M.AssertModel(models[1],_testData[28], false);Int64bigintArray1M.AssertModel(models[2],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigintArray1M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintArray1M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[27],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[28],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

