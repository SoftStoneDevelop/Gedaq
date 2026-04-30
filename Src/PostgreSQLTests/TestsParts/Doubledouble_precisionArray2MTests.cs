

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47939546309642345d,

0.664477403889366d,

0.8118278921145285d,

0.9514338713415015d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18820103303482072d,

0.5321836518463028d,

0.39610812187309785d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.30046676612883294d,

0.8807849084201504d,

0.9031554118014263d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.049800524332684226d,

0.22072210372219003d,

0.3482385451975045d,

0.6435484135728539d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12909480434409826d,

0.3154506813763499d,

0.24353793869954155d,

0.3883027961466967d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5600615891437024d,

0.020035860597000243d,

0.6279607820717054d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2670998582296895d,

0.9538919055141711d,

0.10930646745609296d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.17118043876506783d,

0.9628430339377528d,

0.8129500258053981d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5251933668834802d,

0.6084631152310832d,

0.9235607016333822d,

0.11048246481726764d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.25419070965182045d,

0.7683187440029374d,

0.9508707030114888d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3226574598076576d,

0.6516445911029244d,

0.7684611719421418d,

0.638680848992236d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7295368695550514d,

0.12722467144515703d,

0.027952678051938018d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7483754325355482d,

0.29933521640707583d,

0.020198850212466368d,

0.6001016044772365d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9388612955393504d,

0.7204095854559734d,

0.8941218005814284d,

0.287204288871334d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2620962877318207d,

0.07556219693515642d,

0.719501051198838d,

0.06352434168052712d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09044292885335037d,

0.19645492490629268d,

0.2711396970932439d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8373551258070211d,

0.01918552243091287d,

0.32395374156218426d,

0.9785101221389704d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8512119642571884d,

0.18910412067019589d,

0.4107943727035981d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9563862473375173d,

0.14205690791422243d,

0.1068976900087848d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9128559312223938d,

0.6582377667040967d,

0.3976527967316925d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5234985997683351d,

0.8363832717113779d,

0.3025829752854926d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4867622365215306d,

0.7471623769439343d,

0.9604018914107777d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.41859040443289985d,

0.6294545878663028d,

0.3665534106429388d,

0.22648359435350063d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8232861877165787d,

0.6947983059936297d,

0.8767113282993001d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9938818965695642d,

0.8288848144554318d,

0.8770081948956978d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9749836864711143d,

0.6502208089315789d,

0.1452555413553671d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7545177031992647d,

0.6539401601976522d,

0.8406769380581813d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23738451681585604d,

0.019940914134501386d,

0.3584347692530624d,

0.4909108480420892d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8744265504254225d,

0.9672297660648361d,

0.7809646810675309d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9987930929454276d,

0.16766282287825207d,

0.091067156090477d,

0.46029288972021987d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.746547778287683d,

0.9540194883626443d,

0.7292278329303409d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.915922632660868d,

0.07138665265474708d,

0.6456379446282782d,

0.7324057300397439d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4922199492822309d,

0.4617853577302079d,

0.5866866543965794d,

0.6167839824943798d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3372076685164277d,

0.1296023386474089d,

0.5005955405442489d,

0.5421512383798947d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10655727923005054d,

0.4391234704571353d,

0.889205262292042d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7158795255564679d,

0.8209796168902574d,

0.5891412385885693d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7259407910420289d,

0.964705254145777d,

0.34261842600059367d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9682135176973093d,

0.7347768440908048d,

0.4731099853755002d,

0.7496630920241482d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5102691490739226d,

0.6508854978146573d,

0.26147262027437745d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3337215206610187d,

0.840434245357187d,

0.7186879734186948d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2349540666089548d,

0.5299858904614448d,

0.6478396525715721d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.025414830876246297d,

0.7494418970131916d,

0.9762807681781354d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6099492015796207d,

0.6951456918556768d,

0.23728206078572012d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07187572799594222d,

0.9434229980356744d,

0.4870654529823598d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9572068668139972d,

0.5902648651704299d,

0.5188121311782702d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7697107547241422d,

0.8620332545621383d,

0.7522418873168935d,

0.4094380837771121d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3035703264056544d,

0.14264195815533542d,

0.10362398560247643d,

0.9720693108250182d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11460006177746163d,

0.9425248731701015d,

0.7414789196439326d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28119425003708653d,

0.5948324250219194d,

0.6134150099100576d,

0.7746608548782349d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11509862849734775d,

0.6292353097523259d,

0.910694846113006d,

0.8423982272467107d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39850323270584265d,

0.45858871808543844d,

0.7497432871563715d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2530353720641825d,

0.5174378127591934d,

0.5979794727788681d,

0.3047114052703854d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7986728832881823d,

0.46518797154590497d,

0.5898556991105582d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09574573552304366d,

0.4448073759064989d,

0.743874901410554d,

0.8200866888546025d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.44441985105975346d,

0.008599715450794965d,

0.9414262704517377d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16275158572922788d,

0.15821844757578285d,

0.05289567933439476d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3384355949786635d,

0.9327742098930195d,

0.714971736701053d,

0.5923427207590104d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.038488896254074256d,

0.5115667079555498d,

0.3074806729454945d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4298166204300774d,

0.4023352740885595d,

0.5898668015270115d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13967055063371747d,

0.9240158462882424d,

0.11041312074305698d,

0.34408637008396625d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6732265330444416d,

0.18295980743801887d,

0.747577843979579d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6844790410527237d,

0.3367052023180419d,

0.5830244894828821d,

0.859680218246792d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9782379229483881d,

0.9150808130223254d,

0.7837183680279001d,

0.8876114666433494d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5916411025375884d,

0.9652701726910027d,

0.15278274208305254d,

0.5630219565562852d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7481625834394622d,

0.6902327760979599d,

0.21244303038978252d,

0.27616720470410294d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.769289793341508d,

0.5447897301011498d,

0.6936636262119723d,

0.7652816378609306d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8368767300122224d,

0.30568050671438196d,

0.7231657869710526d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8183489134018693d,

0.9348537683083943d,

0.41329584304316325d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.44550286472877576d,

0.08928051402736592d,

0.005816068547201625d,

0.47817722971194143d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.45632247937254d,

0.6190408262006448d,

0.37821416346762293d,

0.720771845299113d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7409564204127018d,

0.8858246682894919d,

0.7452966620142999d,

0.9069517904991957d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9406276969520722d,

0.9447435519462299d,

0.5784158257209202d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8373161791723682d,

0.2593405768447179d,

0.03265769466809554d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10837317999860818d,

0.7360390510267996d,

0.4208723393176512d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09282822558119586d,

0.5725265759104624d,

0.0005609634331564806d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7539628101155289d,

0.8866719157441726d,

0.652990758059529d,

0.6699556453619853d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4502530484968754d,

0.17473418844983213d,

0.3349484952999129d,

0.49777737714354897d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4265186182019016d,

0.28945298141173503d,

0.6128811470093111d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7461311951736462d,

0.3616844101901521d,

0.8635831290430375d,

0.6192361469951323d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9991562017148748d,

0.6438588488779706d,

0.39165554602007946d,

0.3618319263361621d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7454192093890685d,

0.8972507263363589d,

0.9834239645491248d,

0.2771891197472772d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180963405452537d,

0.46393079299138806d,

0.39386991980041974d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05399482272433076d,

0.5114525532507698d,

0.6452114130886925d,

0.11820758809659637d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6100571208838254d,

0.031084504327390627d,

0.5685057544782255d,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 67, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 12, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 43, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 61, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 158, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 93, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);Doubledouble_precisionArray2M.AssertModel(models[29],_testData[30], false);Doubledouble_precisionArray2M.AssertModel(models[30],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[31],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[32],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[30], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI), typeof(Doubledouble_precisionArray2MI)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                await ((IDoubleListdouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                ((IDoubleListdouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

