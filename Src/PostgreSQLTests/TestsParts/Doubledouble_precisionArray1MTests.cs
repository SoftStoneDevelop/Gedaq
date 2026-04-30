

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
    internal partial interface IDoubleArraydouble_precisionArray
    {
    }
    
    internal partial class DoubleArraydouble_precisionArray : IDoubleArraydouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray1M[] _testData = new Doubledouble_precisionArray1M[]
        {
            new Doubledouble_precisionArray1M
{
    Id = 3,
    Value = 
new System.Double[4]
{
0.33529371589014034d,
0.3890677282514542d,
0.8287669752811473d,
0.658213549948558d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 5,
    Value = 
new System.Double[4]
{
0.024671631607695588d,
0.5994357219267464d,
0.05212028060189855d,
0.33340737807737864d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[3]
{
0.5094141426747392d,
0.3477744987516149d,
0.19533858704281404d,
},
    NullableValue = 
new System.Double[4]
{
0.3208911982244932d,
0.7386938117181161d,
0.3533325805752091d,
0.5482729640037719d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 10,
    Value = 
new System.Double[4]
{
0.09647014977865065d,
0.50981549526209d,
0.6446803104047759d,
0.9833094285572419d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3074205700020525d,
0.49127670182539485d,
0.2930091954263052d,
0.14605467085716228d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 14,
    Value = 
new System.Double[4]
{
0.03302390785064713d,
0.503944937114928d,
0.1075914669670407d,
0.4525351998433781d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 14,
    Value = 
new System.Double[3]
{
0.7224856706116025d,
0.4450957999033346d,
0.506542908592399d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 19,
    Value = 
new System.Double[3]
{
0.32876584470632264d,
0.626616292001123d,
0.04187323356604733d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8444093583037042d,
0.5109671046379973d,
0.37397194653318666d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 23,
    Value = 
new System.Double[4]
{
0.08367553120956217d,
0.5421323349330729d,
0.1355016813288623d,
0.24972503590983197d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 15,
    Value = 
new System.Double[3]
{
0.2552345881428473d,
0.41307865789466647d,
0.616154545305561d,
},
    NullableValue = 
new System.Double[4]
{
0.7678990205820937d,
0.3765905275262764d,
0.6685993077093613d,
0.4569371336910196d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 27,
    Value = 
new System.Double[3]
{
0.40193785006772154d,
0.798229926925033d,
0.14317824173701832d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.4348348551636253d,
0.9559095338944336d,
0.06088591034890256d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.24276647451657385d,
0.9709579000659839d,
0.9467657195364217d,
0.43066472806581946d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 19,
    Value = 
new System.Double[3]
{
0.5927981379795791d,
0.45001440064932874d,
0.4566512146273026d,
},
    NullableValue = 
new System.Double[3]
{
0.2667463264777119d,
0.12968277271983053d,
0.804802628467724d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 34,
    Value = 
new System.Double[3]
{
0.5710589109046614d,
0.4853517032410709d,
0.1546413000442215d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.22437048873311716d,
0.6238767084501845d,
0.31074180466455137d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 39,
    Value = 
new System.Double[4]
{
0.5098981964905627d,
0.2147775420414384d,
0.215271884719469d,
0.8531194919105767d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 25,
    Value = 
new System.Double[4]
{
0.9294730163946432d,
0.8656928221037027d,
0.9427471580468978d,
0.9589329271887399d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.8734546229882046d,
0.15975524832114563d,
0.48998871507587627d,
0.40412286568040345d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 47,
    Value = 
new System.Double[4]
{
0.8413926720557608d,
0.909829340462733d,
0.1382799135814622d,
0.5817395509159187d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.013847847519156797d,
0.42044573033481225d,
0.43600346291441083d,
0.579417448308822d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 49,
    Value = 
new System.Double[4]
{
0.7694704219092746d,
0.4704600551246956d,
0.3696790571167309d,
0.7243824917562821d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 31,
    Value = 
new System.Double[3]
{
0.3532126394204178d,
0.4107061060972266d,
0.4770907106365089d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.5889721524806614d,
0.21583236622844626d,
0.4978954073323095d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 56,
    Value = 
new System.Double[3]
{
0.11142096870802765d,
0.3618102967817657d,
0.32053588692092294d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.5392726091975075d,
0.6023466191694259d,
0.30170933634179764d,
0.8957084056105763d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 59,
    Value = 
new System.Double[4]
{
0.5522023331070532d,
0.38247598909146585d,
0.7360131485079928d,
0.894654491509576d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 33,
    Value = 
new System.Double[4]
{
0.398402326653319d,
0.6125845086883142d,
0.34804919354976205d,
0.32826693397838613d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.420356726002593d,
0.47687469009022354d,
0.9575919611322283d,
0.9185110296220688d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 64,
    Value = 
new System.Double[3]
{
0.08244211665356793d,
0.8298512915934052d,
0.337062098565468d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3844838566044724d,
0.9940201493555882d,
0.6395938650817519d,
0.5852072602672455d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.054761920773899075d,
0.47017596538511197d,
0.9135540140623182d,
0.914705004644175d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 37,
    Value = 
new System.Double[4]
{
0.497882760865892d,
0.4036071523483491d,
0.3912011407392505d,
0.07217998522455615d,
},
    NullableValue = 
new System.Double[3]
{
0.6868120994038732d,
0.8216582009231237d,
0.0404757889012185d,
},
},
    NullableValue = 
new System.Double[3]
{
0.5001591414724261d,
0.6861166445853937d,
0.047655547606777704d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 72,
    Value = 
new System.Double[4]
{
0.04663225202814303d,
0.578751158112368d,
0.48311884899616364d,
0.7833784605023293d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 81,
    Value = 
new System.Double[3]
{
0.3830842198144975d,
0.13257850986877628d,
0.7872054659702241d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 41,
    Value = 
new System.Double[4]
{
0.06562901107553776d,
0.6420774148362844d,
0.8455701414191371d,
0.1060058805539712d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 85,
    Value = 
new System.Double[4]
{
0.767888164806531d,
0.23990544065434416d,
0.40641336336225753d,
0.6139038798867031d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 93,
    Value = 
new System.Double[4]
{
0.8550094857197962d,
0.8849296805361565d,
0.1033650193479847d,
0.052371885456177436d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 47,
    Value = 
new System.Double[3]
{
0.009550615099748638d,
0.23804809532003324d,
0.43502012840147086d,
},
    NullableValue = 
new System.Double[3]
{
0.40139746428013956d,
0.06672113878362951d,
0.2214843621582201d,
},
},
    NullableValue = 
new System.Double[4]
{
0.8772096988017574d,
0.7673214230734196d,
0.3597860921267778d,
0.7010835033871753d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 94,
    Value = 
new System.Double[4]
{
0.576121238086758d,
0.07834629624065426d,
0.8982759301360315d,
0.5538061754738488d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 99,
    Value = 
new System.Double[4]
{
0.5652474556212106d,
0.6777530320606443d,
0.5248791134800023d,
0.18424250370311035d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 53,
    Value = 
new System.Double[3]
{
0.4459031274998322d,
0.8499760885369718d,
0.62861362575982d,
},
    NullableValue = 
new System.Double[3]
{
0.43978974278085836d,
0.25333638949694715d,
0.3189833638714613d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 107,
    Value = 
new System.Double[3]
{
0.9459917199805791d,
0.1084130174528456d,
0.8419062112795731d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 109,
    Value = 
new System.Double[4]
{
0.5517418074719623d,
0.14730899871056757d,
0.9217372734031922d,
0.7590382677184859d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 58,
    Value = 
new System.Double[3]
{
0.6121806085125006d,
0.5409934099093863d,
0.5158756039650504d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 111,
    Value = 
new System.Double[4]
{
0.8754575887858516d,
0.7210769268260762d,
0.8058226362051506d,
0.07431965781318295d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 120,
    Value = 
new System.Double[3]
{
0.05645645930036469d,
0.48645713729801376d,
0.8654579313684957d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 62,
    Value = 
new System.Double[3]
{
0.7351455312100195d,
0.5840311043558438d,
0.43448839811124507d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 122,
    Value = 
new System.Double[4]
{
0.3814010768423053d,
0.3795950926588958d,
0.35431737080866077d,
0.30677879818190434d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.048659869535863653d,
0.2935937703735517d,
0.09046580898431944d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 125,
    Value = 
new System.Double[3]
{
0.2552648107947034d,
0.22844859440873833d,
0.5566921395208809d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 70,
    Value = 
new System.Double[4]
{
0.5515307466232072d,
0.7347060218922663d,
0.8109814397249371d,
0.12892742802727175d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 130,
    Value = 
new System.Double[4]
{
0.5459975295731077d,
0.2733810735641544d,
0.009598357196586194d,
0.8921172206033672d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 134,
    Value = 
new System.Double[3]
{
0.3680569319650634d,
0.03943306739900332d,
0.6751173928159058d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 75,
    Value = 
new System.Double[3]
{
0.1541376001098328d,
0.8835613936127528d,
0.08363248230643727d,
},
    NullableValue = 
new System.Double[4]
{
0.7128949652082441d,
0.44032856593941494d,
0.7987363138893696d,
0.18206464779054876d,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
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

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.8444093583037042d,
0.5109671046379973d,
0.37397194653318666d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.4348348551636253d,
0.9559095338944336d,
0.06088591034890256d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                System.Double[] nullable = null;
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.22437048873311716d,
0.6238767084501845d,
0.31074180466455137d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.8734546229882046d,
0.15975524832114563d,
0.48998871507587627d,
0.40412286568040345d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.013847847519156797d,
0.42044573033481225d,
0.43600346291441083d,
0.579417448308822d,
}));
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.5889721524806614d,
0.21583236622844626d,
0.4978954073323095d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[29], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 49, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 47, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 3, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 107, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 5, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 94, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
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
                await using var cmd = await ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray1m m
LEFT JOIN public.binary_doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray1M>(15);

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
                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

