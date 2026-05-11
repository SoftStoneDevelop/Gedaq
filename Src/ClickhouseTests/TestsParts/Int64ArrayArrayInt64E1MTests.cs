

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IInt64MArrayArrayArrayInt64
    {
    }
    
    internal partial class Int64MArrayArrayArrayInt64 : IInt64MArrayArrayArrayInt64
    {


#region TestData

        private readonly Int64ArrayArrayInt64E1M[] _testData = new Int64ArrayArrayInt64E1M[]
        {
            new Int64ArrayArrayInt64E1M
{
    Id = 9,
    Value = 
new System.Int64[,] { {
6664301649758688843L,
1823644330908538761L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 3,
    Value = 
new System.Int64[,] { {
6398808198799301311L,
5687675879882838363L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
7925740877364694609L,
1023731927742199312L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 14,
    Value = 
new System.Int64[,] { {
7394774743988225190L,
7536461186228455536L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 8,
    Value = 
new System.Int64[,] { {
5777985832029802302L,
5490192621283203698L, } },
    NullableValue = 
new System.Int64[,] { {
2113281587980427884L,
3218909474349009666L, } },
},
    NullableValue = 
new System.Int64[,] { {
8061909905427535809L,
264980439892236L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 15,
    Value = 
new System.Int64[,] { {
6413544685545441356L,
3758693078888672597L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 9,
    Value = 
new System.Int64[,] { {
5080080059275772405L,
7042165249050414847L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
3004546367317864920L,
1962053530844215028L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 17,
    Value = 
new System.Int64[,] { {
6726034879292914902L,
2906289908988215721L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 15,
    Value = 
new System.Int64[,] { {
5899382715463546723L,
5403579244429504072L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 21,
    Value = 
new System.Int64[,] { {
7424644471078212903L,
3608869500641166580L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 16,
    Value = 
new System.Int64[,] { {
1389722816973839457L,
114582698685311123L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
8373554398381985459L,
1705419705393450238L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 25,
    Value = 
new System.Int64[,] { {
5443863711865427282L,
8192279976456511465L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 21,
    Value = 
new System.Int64[,] { {
2529950967914649114L,
5954291753888687901L, } },
    NullableValue = 
new System.Int64[,] { {
586463448884174868L,
8966790760999745682L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 26,
    Value = 
new System.Int64[,] { {
8323038324867517942L,
4325436521903372910L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 28,
    Value = 
new System.Int64[,] { {
3792769766998404668L,
8461646799161020408L, } },
    NullableValue = 
new System.Int64[,] { {
413541563174400667L,
537863662417712738L, } },
},
    NullableValue = 
new System.Int64[,] { {
931716955081506156L,
4196372504951249808L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 33,
    Value = 
new System.Int64[,] { {
5348891332444135311L,
3011050027839815476L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 35,
    Value = 
new System.Int64[,] { {
5207561396385608692L,
4579164653886170473L, } },
    NullableValue = 
new System.Int64[,] { {
5653773767768794346L,
5150728301610112829L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 40,
    Value = 
new System.Int64[,] { {
201479888528495966L,
8058040627253131422L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 38,
    Value = 
new System.Int64[,] { {
1428181694198894994L,
7002532348944795299L, } },
    NullableValue = 
new System.Int64[,] { {
4721291468241818811L,
6789873656804977545L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 49,
    Value = 
new System.Int64[,] { {
5437534388785593268L,
8591924317921127625L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 45,
    Value = 
new System.Int64[,] { {
1659606865654238717L,
4684607075952736487L, } },
    NullableValue = 
new System.Int64[,] { {
8836125657638782049L,
6018934686565875890L, } },
},
    NullableValue = 
new System.Int64[,] { {
7538085598167989670L,
1003128516748461776L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 54,
    Value = 
new System.Int64[,] { {
5509988412355115327L,
4087858719564100492L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 46,
    Value = 
new System.Int64[,] { {
1423167971066635520L,
8304592697047044697L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
208318082734785568L,
6749519694972763194L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 57,
    Value = 
new System.Int64[,] { {
8508914289007380808L,
5641227437154132279L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 53,
    Value = 
new System.Int64[,] { {
3513058842565309791L,
8322557210665633901L, } },
    NullableValue = 
new System.Int64[,] { {
7196588453017265571L,
6385126444605844171L, } },
},
    NullableValue = 
new System.Int64[,] { {
3241301496033673382L,
1148818347327865029L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 63,
    Value = 
new System.Int64[,] { {
3157645564228038351L,
7913659549572407036L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 58,
    Value = 
new System.Int64[,] { {
767443331016849730L,
4717137137196830302L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 68,
    Value = 
new System.Int64[,] { {
8100712923058825271L,
8854743750302090272L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 64,
    Value = 
new System.Int64[,] { {
8522526288470830513L,
4271259024616632801L, } },
    NullableValue = 
new System.Int64[,] { {
1343033165045436079L,
4028127946658291525L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 76,
    Value = 
new System.Int64[,] { {
555403740909907834L,
2053574812492161444L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 65,
    Value = 
new System.Int64[,] { {
2657570180190777224L,
8232244269574541722L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
6516119587806565682L,
8226965019353213481L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 79,
    Value = 
new System.Int64[,] { {
2216255491094269511L,
7993779027266360098L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 72,
    Value = 
new System.Int64[,] { {
3820167951746977764L,
4583345301160991837L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 81,
    Value = 
new System.Int64[,] { {
2726159172190470658L,
1372223673097710160L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 75,
    Value = 
new System.Int64[,] { {
2459712901459702339L,
2809508868845188087L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
7974641384406018680L,
6886817745739371312L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 83,
    Value = 
new System.Int64[,] { {
6987324068373007486L,
2186042474974620847L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 81,
    Value = 
new System.Int64[,] { {
5103996211501355077L,
5841523791692658690L, } },
    NullableValue = 
new System.Int64[,] { {
8600338075502346808L,
945399866126550672L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 92,
    Value = 
new System.Int64[,] { {
3175758391558032923L,
6897955538820537278L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 88,
    Value = 
new System.Int64[,] { {
7134543106330125891L,
4435245133312261465L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
5811082482337898600L,
1980004086326389223L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 101,
    Value = 
new System.Int64[,] { {
2266152474026242610L,
1584254305285258015L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 97,
    Value = 
new System.Int64[,] { {
6321794365140756462L,
5533958524478014926L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
8438265882812428774L,
7177196320860175927L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 110,
    Value = 
new System.Int64[,] { {
5027641535877615740L,
4854741056564091004L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 102,
    Value = 
new System.Int64[,] { {
6930881789401568952L,
821595577981392939L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 119,
    Value = 
new System.Int64[,] { {
6383279958928098256L,
4231748578707246510L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 106,
    Value = 
new System.Int64[,] { {
6124637793273444405L,
205286417354088864L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
7342970810306425257L,
7202568558395779693L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 125,
    Value = 
new System.Int64[,] { {
727947935647917638L,
8470993020706251138L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 110,
    Value = 
new System.Int64[,] { {
8338355837595850541L,
4339897139397089512L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 134,
    Value = 
new System.Int64[,] { {
5791439878364654475L,
250020577042652400L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 117,
    Value = 
new System.Int64[,] { {
3807411835436994225L,
1687642137593811337L, } },
    NullableValue = 
new System.Int64[,] { {
5036610376688801251L,
478110144264224549L, } },
},
    NullableValue = 
new System.Int64[,] { {
6856758669043361422L,
7647526868345993322L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 141,
    Value = 
new System.Int64[,] { {
6168604858118056707L,
2346203601888093976L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 124,
    Value = 
new System.Int64[,] { {
7211438376444868457L,
4439561083729915560L, } },
    NullableValue = 
new System.Int64[,] { {
1796922574106579032L,
1200241100634684780L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 146,
    Value = 
new System.Int64[,] { {
4078906472943223666L,
5116099291636502690L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 132,
    Value = 
new System.Int64[,] { {
2937646721349564907L,
2405487118856053915L, } },
    NullableValue = 
new System.Int64[,] { {
8547394476028175638L,
4040161220954074304L, } },
},
    NullableValue = 
new System.Int64[,] { {
6934052749075527201L,
283302852566513784L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 150,
    Value = 
new System.Int64[,] { {
366168884545192955L,
4948059861900150363L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 134,
    Value = 
new System.Int64[,] { {
45016050069599034L,
1797629578086771544L, } },
    NullableValue = 
new System.Int64[,] { {
8538849879904180349L,
8285840193926694907L, } },
},
    NullableValue = 
new System.Int64[,] { {
8156593030285883007L,
6893194406352171401L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 157,
    Value = 
new System.Int64[,] { {
5587724086915486176L,
1946054786748723086L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 135,
    Value = 
new System.Int64[,] { {
771759547339933053L,
6205830123173258547L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 159,
    Value = 
new System.Int64[,] { {
2289755413767030901L,
6506922360981239601L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 143,
    Value = 
new System.Int64[,] { {
1659432818280531652L,
7014086077864105949L, } },
    NullableValue = 
new System.Int64[,] { {
7934951472369691933L,
4012331339230331904L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 168,
    Value = 
new System.Int64[,] { {
9047845541143286644L,
2333274315154508336L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 148,
    Value = 
new System.Int64[,] { {
7681241063816973696L,
8897566335709695968L, } },
    NullableValue = 
new System.Int64[,] { {
2193885059716250787L,
1289163858864305303L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 177,
    Value = 
new System.Int64[,] { {
5682091261769795895L,
7426844397429145990L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 157,
    Value = 
new System.Int64[,] { {
6409683146908050525L,
3666734913273642401L, } },
    NullableValue = 
new System.Int64[,] { {
965638829236875130L,
2417459691877582387L, } },
},
    NullableValue = 
new System.Int64[,] { {
8055056978375154926L,
2723701404276043014L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 186,
    Value = 
new System.Int64[,] { {
9073117270422813564L,
5212544684313362429L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 164,
    Value = 
new System.Int64[,] { {
7896437119187135867L,
53675215962826329L, } },
    NullableValue = 
new System.Int64[,] { {
5491337365898554690L,
8325225547329090622L, } },
},
    NullableValue = null,
},
            new Int64ArrayArrayInt64E1M
{
    Id = 191,
    Value = 
new System.Int64[,] { {
1548839509977059706L,
4894996404531415111L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 171,
    Value = 
new System.Int64[,] { {
7730317650606195372L,
2094187626782670972L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
7699400476328618142L,
7025406330919869512L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 199,
    Value = 
new System.Int64[,] { {
2854209109148282314L,
6777724064934409431L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 180,
    Value = 
new System.Int64[,] { {
7715200011073920215L,
789411481536867857L, } },
    NullableValue = 
new System.Int64[,] { {
5273408849794851452L,
2293577973561680300L, } },
},
    NullableValue = 
new System.Int64[,] { {
2302947463523961470L,
4137922112910178042L, } },
},
            new Int64ArrayArrayInt64E1M
{
    Id = 200,
    Value = 
new System.Int64[,] { {
9172041452203593054L,
5144595872523366960L, } },
    ModelInner = new Int64ArrayArrayInt641MI
{
    Id = 182,
    Value = 
new System.Int64[,] { {
4175999378729913388L,
3446539814973764123L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
6702273136614393800L,
3473215954028465863L, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64arrayarrayint64e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayArrayArrayInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IInt64MArrayArrayArrayInt64)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IInt64MArrayArrayArrayInt64)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.int64arrayarrayint64e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64ArrayArrayInt64E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayArrayArrayInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IInt64MArrayArrayArrayInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64ArrayArrayInt64E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IInt64MArrayArrayArrayInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64ArrayArrayInt64E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

