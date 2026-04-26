

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2699019446777296125L),
new System.Numerics.BigInteger(8407775463952367349L),
new System.Numerics.BigInteger(6140761060268352575L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2687692723807680162L),
new System.Numerics.BigInteger(1073414986709147775L),
new System.Numerics.BigInteger(1960331060110460779L),
},
},
            new BigIntegernumericArray1M
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(468852634274730409L),
new System.Numerics.BigInteger(762967438562107546L),
new System.Numerics.BigInteger(7360392106328207738L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5168562069921072561L),
new System.Numerics.BigInteger(3611186192632288559L),
new System.Numerics.BigInteger(9078598017202939681L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(322261466064287774L),
new System.Numerics.BigInteger(2773086801821400051L),
new System.Numerics.BigInteger(7223831440577262515L),
new System.Numerics.BigInteger(901628682125966628L),
},
},
            new BigIntegernumericArray1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(29952335576197804L),
new System.Numerics.BigInteger(3430563503849654542L),
new System.Numerics.BigInteger(4223739212299896988L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8967292657990151800L),
new System.Numerics.BigInteger(2392298640346775613L),
new System.Numerics.BigInteger(5526181869075598883L),
},
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(639227679610788423L),
new System.Numerics.BigInteger(7399579146081367598L),
new System.Numerics.BigInteger(2970494057922827494L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 11,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4925474173262913348L),
new System.Numerics.BigInteger(5143482845038566226L),
new System.Numerics.BigInteger(2935531198739190891L),
new System.Numerics.BigInteger(4730897023763471650L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8636797411278975533L),
new System.Numerics.BigInteger(1506549957608831056L),
new System.Numerics.BigInteger(9019920676824076368L),
new System.Numerics.BigInteger(9132427041324504035L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(86092238702520788L),
new System.Numerics.BigInteger(178484916589943850L),
new System.Numerics.BigInteger(7911376228084184492L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8346154476944445833L),
new System.Numerics.BigInteger(6078122180078453125L),
new System.Numerics.BigInteger(573827860293644001L),
},
},
            new BigIntegernumericArray1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8370185990240728154L),
new System.Numerics.BigInteger(6800764870716918141L),
new System.Numerics.BigInteger(5857970382266213800L),
new System.Numerics.BigInteger(4342447831629560655L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6202662238224681835L),
new System.Numerics.BigInteger(8369187276739674117L),
new System.Numerics.BigInteger(1769663456367192031L),
new System.Numerics.BigInteger(8811483813201256006L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1219550373707559776L),
new System.Numerics.BigInteger(5809192278286750887L),
new System.Numerics.BigInteger(2257678649062447671L),
},
},
            new BigIntegernumericArray1M
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8913945936455831494L),
new System.Numerics.BigInteger(4684873963365102788L),
new System.Numerics.BigInteger(4337665833100660144L),
new System.Numerics.BigInteger(1733007931496544441L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4050201578472889864L),
new System.Numerics.BigInteger(5141410503032614353L),
new System.Numerics.BigInteger(9211815311806330532L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5308283893236214410L),
new System.Numerics.BigInteger(6731165416380680395L),
new System.Numerics.BigInteger(7060010978370533377L),
new System.Numerics.BigInteger(6171107004014348726L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(65316600685929002L),
new System.Numerics.BigInteger(8205897746810269259L),
new System.Numerics.BigInteger(7169235948421274648L),
new System.Numerics.BigInteger(460726072276793550L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4141450826491590794L),
new System.Numerics.BigInteger(7709009369781902264L),
new System.Numerics.BigInteger(7648931766142581346L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7554272911462549461L),
new System.Numerics.BigInteger(2366598046546126440L),
new System.Numerics.BigInteger(9146402249269999767L),
new System.Numerics.BigInteger(8461780793315007889L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8415137208676992764L),
new System.Numerics.BigInteger(3808826812054423668L),
new System.Numerics.BigInteger(4141393653967637754L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(297144960610957846L),
new System.Numerics.BigInteger(3706633969258570303L),
new System.Numerics.BigInteger(4104388656931131941L),
new System.Numerics.BigInteger(576075310747951134L),
},
},
            new BigIntegernumericArray1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8422689181624713840L),
new System.Numerics.BigInteger(4618392497079832182L),
new System.Numerics.BigInteger(9014778168990631121L),
new System.Numerics.BigInteger(5724492586472478029L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2625495630711382513L),
new System.Numerics.BigInteger(6062113187474408434L),
new System.Numerics.BigInteger(560901288796600530L),
new System.Numerics.BigInteger(2925454188301380751L),
},
},
            new BigIntegernumericArray1M
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7387872580647018255L),
new System.Numerics.BigInteger(8807027665799566598L),
new System.Numerics.BigInteger(1555482705113937629L),
new System.Numerics.BigInteger(6765250831074413807L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8380698831042777672L),
new System.Numerics.BigInteger(5869119114251502983L),
new System.Numerics.BigInteger(6625366997335351788L),
new System.Numerics.BigInteger(9107506037083024984L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1119924970654917510L),
new System.Numerics.BigInteger(3144284284672615706L),
new System.Numerics.BigInteger(4104908898371873286L),
new System.Numerics.BigInteger(27092861747905668L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7387472485321142483L),
new System.Numerics.BigInteger(4392221838370272852L),
new System.Numerics.BigInteger(3000381019942188538L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7139170459524426992L),
new System.Numerics.BigInteger(9062301653609445389L),
new System.Numerics.BigInteger(4460920950781943386L),
},
},
            new BigIntegernumericArray1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(501833010428849114L),
new System.Numerics.BigInteger(3149990854060188676L),
new System.Numerics.BigInteger(4481707898784713109L),
new System.Numerics.BigInteger(3247493931371722893L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2187247939598954061L),
new System.Numerics.BigInteger(5860869081469558139L),
new System.Numerics.BigInteger(5503195686693043282L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5040793730502856347L),
new System.Numerics.BigInteger(322949848357119383L),
new System.Numerics.BigInteger(4814968665818762131L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3740076504759389204L),
new System.Numerics.BigInteger(4209189089519890758L),
new System.Numerics.BigInteger(456713666684045494L),
},
},
            new BigIntegernumericArray1M
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7791366850383495448L),
new System.Numerics.BigInteger(1857703505868194851L),
new System.Numerics.BigInteger(4083890397942750432L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5179680291863373505L),
new System.Numerics.BigInteger(7308045604236633230L),
new System.Numerics.BigInteger(3535142798232456035L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7749346311577989166L),
new System.Numerics.BigInteger(5603225102460115602L),
new System.Numerics.BigInteger(8217691094166238940L),
new System.Numerics.BigInteger(7228589843437428835L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4369987644130118636L),
new System.Numerics.BigInteger(6697638553182709322L),
new System.Numerics.BigInteger(8973422891859437889L),
},
},
            new BigIntegernumericArray1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4616120515101744091L),
new System.Numerics.BigInteger(4852852595407767347L),
new System.Numerics.BigInteger(7153147463751743083L),
new System.Numerics.BigInteger(9110365135477451418L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2146384498065685841L),
new System.Numerics.BigInteger(6206745892433183871L),
new System.Numerics.BigInteger(7267110410789912680L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1340935315330474826L),
new System.Numerics.BigInteger(242036272725068868L),
new System.Numerics.BigInteger(2639987515909995932L),
new System.Numerics.BigInteger(1370278046235179000L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2260984626220352856L),
new System.Numerics.BigInteger(4928529165970438612L),
new System.Numerics.BigInteger(5631325349220181594L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8705489909945464161L),
new System.Numerics.BigInteger(819028125556444895L),
new System.Numerics.BigInteger(7173718531678762662L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 90,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6649748713100707795L),
new System.Numerics.BigInteger(8953054866828786208L),
new System.Numerics.BigInteger(6318846514927637771L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3860858359210674992L),
new System.Numerics.BigInteger(679397741224992659L),
new System.Numerics.BigInteger(2240364861955968357L),
new System.Numerics.BigInteger(5436733025604060140L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7767318995100608107L),
new System.Numerics.BigInteger(3406973533923064690L),
new System.Numerics.BigInteger(8674615252886583292L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7649698636985386141L),
new System.Numerics.BigInteger(3161235520850741290L),
new System.Numerics.BigInteger(1956384811547285454L),
new System.Numerics.BigInteger(2630018137834420145L),
},
},
            new BigIntegernumericArray1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2131243927097382500L),
new System.Numerics.BigInteger(3209470944130385929L),
new System.Numerics.BigInteger(2110729703600649801L),
new System.Numerics.BigInteger(4682872359873505448L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6038295358693794505L),
new System.Numerics.BigInteger(7095675238667680619L),
new System.Numerics.BigInteger(7318196503640582441L),
},
},
            new BigIntegernumericArray1M
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3284863222153331305L),
new System.Numerics.BigInteger(2113246214290947164L),
new System.Numerics.BigInteger(8962708679854291624L),
new System.Numerics.BigInteger(7916547422873867122L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4169473780644461159L),
new System.Numerics.BigInteger(7654502481811105453L),
new System.Numerics.BigInteger(6951629460912360195L),
new System.Numerics.BigInteger(3327488180669764043L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1838325452795962450L),
new System.Numerics.BigInteger(6703792589750930984L),
new System.Numerics.BigInteger(5038667109764553721L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2535969600537956233L),
new System.Numerics.BigInteger(6925643432961379533L),
new System.Numerics.BigInteger(4332550332165041990L),
},
},
            new BigIntegernumericArray1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3347213624639395931L),
new System.Numerics.BigInteger(5535957246044376654L),
new System.Numerics.BigInteger(5658564554650713463L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1144579678603198008L),
new System.Numerics.BigInteger(5638972359370013325L),
new System.Numerics.BigInteger(6821823178765374032L),
new System.Numerics.BigInteger(3620851835038385507L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5870494242615743241L),
new System.Numerics.BigInteger(318423853539909260L),
new System.Numerics.BigInteger(2645888380759199924L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(218859033407043954L),
new System.Numerics.BigInteger(6693217627616946184L),
new System.Numerics.BigInteger(6554671724955763280L),
new System.Numerics.BigInteger(7018499752738969222L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1414901981658056287L),
new System.Numerics.BigInteger(5258527507683184363L),
new System.Numerics.BigInteger(4206227757024847176L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3112511973013454947L),
new System.Numerics.BigInteger(4221225954762123324L),
new System.Numerics.BigInteger(7690843546818703021L),
},
},
            new BigIntegernumericArray1M
{
    Id = 127,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1039137056064118762L),
new System.Numerics.BigInteger(7026719785153187697L),
new System.Numerics.BigInteger(1116724965137288620L),
new System.Numerics.BigInteger(2550071359757103050L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3714061846808820780L),
new System.Numerics.BigInteger(7406066166566890425L),
new System.Numerics.BigInteger(5941021184420795722L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4247519292557102270L),
new System.Numerics.BigInteger(291737299629022412L),
new System.Numerics.BigInteger(7025441759781438762L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(183386463863301305L),
new System.Numerics.BigInteger(6278830382753098774L),
new System.Numerics.BigInteger(2182837459271846835L),
},
},
            new BigIntegernumericArray1M
{
    Id = 142,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2360796040174018333L),
new System.Numerics.BigInteger(8141493078061048213L),
new System.Numerics.BigInteger(2643985795426388721L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 147,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(718316292574306055L),
new System.Numerics.BigInteger(2576755621037698390L),
new System.Numerics.BigInteger(1158849170322455008L),
new System.Numerics.BigInteger(8318027547691074986L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4118903683633973795L),
new System.Numerics.BigInteger(1825570182496136890L),
new System.Numerics.BigInteger(5416412619748088033L),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 125, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 127, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 99, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 66, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
BigIntegernumericArray1M.AssertModel(models[0],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray1M>(15);

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
                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[14], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[20],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[21],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[22],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[23],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[24],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[25],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[26],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[27],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[28],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

