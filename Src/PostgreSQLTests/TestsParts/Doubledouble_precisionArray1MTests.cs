

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
new System.Double[3]
{
0.4966234284600861d,
0.5757196015089209d,
0.7732725610944984d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.3102747092994058d,
0.2816028297561103d,
0.4142146653034866d,
0.8185188630595367d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 7,
    Value = 
new System.Double[4]
{
0.13525837410611774d,
0.04158290406122278d,
0.9955342713888151d,
0.4004753141375088d,
},
    NullableValue = 
new System.Double[3]
{
0.9696253309008576d,
0.24496004172663377d,
0.7249560485973192d,
},
},
    NullableValue = 
new System.Double[3]
{
0.220823241721407d,
0.06842190976128038d,
0.5301081891759939d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 7,
    Value = 
new System.Double[4]
{
0.32816722590036673d,
0.022304911435363173d,
0.26700998986211555d,
0.3300618152602258d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7446934150954928d,
0.8440197456426579d,
0.39984261667834864d,
0.29608158505505544d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 10,
    Value = 
new System.Double[3]
{
0.0981263031033649d,
0.3395304278732796d,
0.34701484911260516d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 13,
    Value = 
new System.Double[3]
{
0.844030646525422d,
0.9808419075530331d,
0.43679264340411206d,
},
    NullableValue = 
new System.Double[4]
{
0.9231392614038344d,
0.9441701308649871d,
0.9240439829371188d,
0.09544161049671918d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 11,
    Value = 
new System.Double[3]
{
0.7298422528120688d,
0.46170457487783745d,
0.6753070186656085d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 19,
    Value = 
new System.Double[3]
{
0.22917897066554493d,
0.08509566848967054d,
0.8793755982279566d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 16,
    Value = 
new System.Double[3]
{
0.6195651948462226d,
0.5015652599052448d,
0.45181414550845533d,
},
    NullableValue = 
new System.Double[4]
{
0.9274109647760368d,
0.11783139086475602d,
0.3279211346216552d,
0.05229781826210589d,
},
},
    NullableValue = 
new System.Double[3]
{
0.7788248056905973d,
0.3280832629207132d,
0.39097077010739256d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 21,
    Value = 
new System.Double[3]
{
0.2734988098872184d,
0.9893462899609644d,
0.2962060890435928d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 26,
    Value = 
new System.Double[4]
{
0.4090319987188754d,
0.9193500355516327d,
0.41404110337429334d,
0.3694041867817708d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 24,
    Value = 
new System.Double[4]
{
0.13371904810630508d,
0.5308653936646084d,
0.9360976378098148d,
0.1162282167292803d,
},
    NullableValue = 
new System.Double[4]
{
0.34702128627286866d,
0.13156127595666334d,
0.5782794849742168d,
0.3617466264158996d,
},
},
    NullableValue = 
new System.Double[3]
{
0.059170561483023576d,
0.2170348004643664d,
0.6001461038477784d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 35,
    Value = 
new System.Double[4]
{
0.5549808051914213d,
0.7111421032711986d,
0.4207240177144673d,
0.36898783494258913d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.44071105550137735d,
0.332556640092752d,
0.4372160181504212d,
0.10426146313750428d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 44,
    Value = 
new System.Double[3]
{
0.8750413501392553d,
0.0670733250172193d,
0.9047236488979409d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.727209633511917d,
0.7372832048527481d,
0.3269643443223377d,
},
    NullableValue = 
new System.Double[4]
{
0.40227842002358116d,
0.3849092818811618d,
0.7198758717787642d,
0.7710702386607489d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 50,
    Value = 
new System.Double[4]
{
0.12291796331703875d,
0.612462586004873d,
0.6490799094484103d,
0.4250528713550189d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 54,
    Value = 
new System.Double[3]
{
0.6755034172131914d,
0.7400259065721333d,
0.5812852650094047d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 40,
    Value = 
new System.Double[3]
{
0.8153497725450461d,
0.5637171166799193d,
0.20999564017930517d,
},
    NullableValue = 
new System.Double[4]
{
0.9692801181715499d,
0.5412316922498539d,
0.32333542495080936d,
0.3544437584900473d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 57,
    Value = 
new System.Double[3]
{
0.30984366844730993d,
0.4268588550896013d,
0.8264166942563065d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.3107636631280736d,
0.453676000155266d,
0.6213444666737924d,
0.39844258506769126d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 48,
    Value = 
new System.Double[4]
{
0.7876048918327891d,
0.2719219177508013d,
0.6812479592058017d,
0.04616733553723307d,
},
    NullableValue = 
new System.Double[3]
{
0.5552350903196429d,
0.5072787572175921d,
0.1895226588514647d,
},
},
    NullableValue = 
new System.Double[4]
{
0.6188233484146913d,
0.7055153519621298d,
0.6087314852515798d,
0.43414082895367323d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 66,
    Value = 
new System.Double[4]
{
0.9204527102471339d,
0.8277615129968618d,
0.08781201012291273d,
0.06670020996130399d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 69,
    Value = 
new System.Double[3]
{
0.7650662270573048d,
0.26690386966350244d,
0.3637629778517696d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 57,
    Value = 
new System.Double[3]
{
0.1033799915367829d,
0.9039960196243216d,
0.359013974435215d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.3008001269584233d,
0.946819358122391d,
0.6332850924955149d,
0.36919074892885195d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 72,
    Value = 
new System.Double[4]
{
0.5454221515435178d,
0.4435551844138741d,
0.6300099774294441d,
0.7378944946653913d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 76,
    Value = 
new System.Double[3]
{
0.16169803340310918d,
0.23181162407467204d,
0.3409709763263803d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 58,
    Value = 
new System.Double[4]
{
0.622619948899047d,
0.422160048798783d,
0.6043527061000774d,
0.9254138698220162d,
},
    NullableValue = 
new System.Double[4]
{
0.3766378170011111d,
0.4994184068274261d,
0.3510528709420764d,
0.07253386320274913d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8332547946729404d,
0.03898190906607557d,
0.7083337875356198d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 85,
    Value = 
new System.Double[3]
{
0.5985360404856263d,
0.8837096073239267d,
0.21857884497656843d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 89,
    Value = 
new System.Double[3]
{
0.03880469779190676d,
0.5671395544480535d,
0.7504522980965626d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.8475355406382781d,
0.5289852179702289d,
0.3679120492631426d,
0.12287295422438815d,
},
    NullableValue = 
new System.Double[4]
{
0.13247039077103606d,
0.8683272114583612d,
0.5340453939129544d,
0.005313672182162499d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 92,
    Value = 
new System.Double[3]
{
0.7631380988830997d,
0.7472816223585835d,
0.11922445801506798d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8268730538752169d,
0.8222144527931285d,
0.730319111727011d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 96,
    Value = 
new System.Double[3]
{
0.8420523840261623d,
0.11454240610871302d,
0.5171031223706419d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 68,
    Value = 
new System.Double[3]
{
0.3699037980525003d,
0.6704699531095667d,
0.7228854969706761d,
},
    NullableValue = 
new System.Double[4]
{
0.8565040369906786d,
0.5995442827308025d,
0.5426146901338013d,
0.034027819492761346d,
},
},
    NullableValue = 
new System.Double[4]
{
0.7512570669004079d,
0.39114904838448683d,
0.5317009785329564d,
0.20212896130683078d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 102,
    Value = 
new System.Double[4]
{
0.15686325025227854d,
0.8392731971136806d,
0.9459222281277171d,
0.24327858177137884d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 110,
    Value = 
new System.Double[4]
{
0.5533027764909619d,
0.21590407466074935d,
0.9980218782537127d,
0.5645810661131543d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 77,
    Value = 
new System.Double[3]
{
0.9591174044348554d,
0.8664782130471443d,
0.795771488161286d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.3820906539556398d,
0.31588919670226023d,
0.536855417831104d,
0.9415551496731588d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 113,
    Value = 
new System.Double[3]
{
0.9742763683050213d,
0.2819893958631928d,
0.9772431450155187d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3722862024993199d,
0.11399654351276056d,
0.4708618881964044d,
0.257451014670118d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 115,
    Value = 
new System.Double[4]
{
0.1786691718249681d,
0.12419329342409902d,
0.6578061647878869d,
0.41526700931457605d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 81,
    Value = 
new System.Double[3]
{
0.9951509906505279d,
0.3008109639723654d,
0.8006707032284038d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 124,
    Value = 
new System.Double[4]
{
0.9321774044350447d,
0.5136383038707976d,
0.9919287445452456d,
0.9522342902644616d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 128,
    Value = 
new System.Double[4]
{
0.8362674617283492d,
0.10959704104962953d,
0.35122161851231537d,
0.12743616362350485d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 86,
    Value = 
new System.Double[4]
{
0.019361716923742556d,
0.13997072503730346d,
0.8358681751661997d,
0.23639610742504946d,
},
    NullableValue = 
new System.Double[3]
{
0.4247979840006114d,
0.6075602873083124d,
0.9998930618582788d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8277635841412135d,
0.8497387447179139d,
0.9111035309291233d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 130,
    Value = 
new System.Double[3]
{
0.15803167300273846d,
0.8349893565819243d,
0.6986676670011931d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 132,
    Value = 
new System.Double[4]
{
0.4657022987576176d,
0.5858980062119471d,
0.11179961465917465d,
0.7093856526738396d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 88,
    Value = 
new System.Double[4]
{
0.4407068123369171d,
0.4446467303242836d,
0.9788155735224279d,
0.29128093363653695d,
},
    NullableValue = 
new System.Double[4]
{
0.9472956740137162d,
0.6920661631067716d,
0.13082781922083597d,
0.7861357462124757d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 141,
    Value = 
new System.Double[4]
{
0.7015135919886623d,
0.6484470447670989d,
0.22504270688954942d,
0.745791095380225d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.6425404699541538d,
0.39219601535660764d,
0.9212578150272634d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 150,
    Value = 
new System.Double[3]
{
0.7706226732984652d,
0.8380519869494629d,
0.9294936386762122d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 96,
    Value = 
new System.Double[3]
{
0.9712118647048822d,
0.4584772244360835d,
0.308900207501867d,
},
    NullableValue = 
new System.Double[3]
{
0.6557283257580482d,
0.013469321879127416d,
0.2491147034949458d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 153,
    Value = 
new System.Double[3]
{
0.6272989897871453d,
0.721917865682007d,
0.6544672200793007d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7051677754036073d,
0.25431450512644427d,
0.843785960081773d,
0.5179845378984432d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 160,
    Value = 
new System.Double[4]
{
0.15939376525415894d,
0.6533150767582525d,
0.3241301353932098d,
0.04273055267964676d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 102,
    Value = 
new System.Double[4]
{
0.6363889569652542d,
0.5730515783461655d,
0.8511990469531023d,
0.9734541225150326d,
},
    NullableValue = 
new System.Double[3]
{
0.03335838454882367d,
0.564532837557333d,
0.6738471398388377d,
},
},
    NullableValue = 
new System.Double[4]
{
0.033645773039801985d,
0.4089482380141398d,
0.6899520766322035d,
0.3502819203939772d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 162,
    Value = 
new System.Double[3]
{
0.9868610300773601d,
0.7872373737188858d,
0.47045651315554593d,
},
    ModelInner = null,
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.7788248056905973d,
0.3280832629207132d,
0.39097077010739256d,
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.059170561483023576d,
0.2170348004643664d,
0.6001461038477784d,
}));
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
new System.Double[4]
{
0.44071105550137735d,
0.332556640092752d,
0.4372160181504212d,
0.10426146313750428d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 150, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 69, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 110, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 89, 110))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 44, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[34], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[34], false);
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

                Assert.That(models, Has.Count.EqualTo(19));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI), typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                await ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

