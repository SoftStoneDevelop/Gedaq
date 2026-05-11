

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxboxE0M[] _testData = new NpgsqlBoxboxE0M[]
        {
            new NpgsqlBoxboxE0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.504664669893461d,right: 0.5182718026795957d,bottom: 0.3221108084756573d,left: 0.14971032494434133d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1266713730040746d,right: 0.7429926448258561d,bottom: 0.04870555665988374d,left: 0.6483115673533061d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6980929298292913d,right: 0.9321676783382428d,bottom: 0.43166644608758675d,left: 0.5110385239520964d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.989767277333459d,right: 0.9117197840652386d,bottom: 0.7722104117976609d,left: 0.6458491465214999d),
},
            new NpgsqlBoxboxE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6649874222570927d,right: 0.7733010895605206d,bottom: 0.3926062701477574d,left: 0.08505849310898139d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6002207348102719d,right: 0.9173037483460418d,bottom: 0.06455210440629722d,left: 0.08048920963072603d),
},
            new NpgsqlBoxboxE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.19743397238529037d,right: 0.6778779451232099d,bottom: 0.01858786198641249d,left: 0.4881948858645232d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6093551994433126d,right: 0.830054164801514d,bottom: 0.3623608163845138d,left: 0.3972656492998671d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9612911772461821d,right: 0.30987906351434236d,bottom: 0.29715286789846396d,left: 0.12436672859368636d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8667704283980951d,right: 0.7231675215576886d,bottom: 0.2444897114515463d,left: 0.2196037435765239d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.358075159896444d,right: 0.44887866957867806d,bottom: 0.2215076543824075d,left: 0.4375914555664182d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6302951637266655d,right: 0.044195780348168734d,bottom: 0.027439930510333665d,left: 0.025092495743531118d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7875312340209555d,right: 0.8056266365655995d,bottom: 0.6486843008957597d,left: 0.21980879444071755d),
},
            new NpgsqlBoxboxE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3286283573024411d,right: 0.979442751851608d,bottom: 0.17263680594277575d,left: 0.5002564735577559d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6637829490408845d,right: 0.6936087022163274d,bottom: 0.4597902245484765d,left: 0.36701888672440364d),
},
            new NpgsqlBoxboxE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8817557178430009d,right: 0.9009614627210254d,bottom: 0.14833832371397326d,left: 0.5569507517065045d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9637156580155847d,right: 0.7203720161272607d,bottom: 0.3507610180097769d,left: 0.47763633838454533d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8622843616111235d,right: 0.98326854196115d,bottom: 0.054528495170817814d,left: 0.059540429019839136d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.768251758367815d,right: 0.8348961487782521d,bottom: 0.25596969297991146d,left: 0.31431491217363994d),
},
            new NpgsqlBoxboxE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9270550800018994d,right: 0.38248915814513473d,bottom: 0.06132839984977323d,left: 0.21822407216569428d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8901097277583341d,right: 0.54712598284031d,bottom: 0.6216725874847913d,left: 0.41050547505732893d),
},
            new NpgsqlBoxboxE0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.34898292939646314d,right: 0.855666069537077d,bottom: 0.10318594589986096d,left: 0.7202988515989293d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1942271428756026d,right: 0.6157687959252129d,bottom: 0.17498212684352077d,left: 0.5469529046863512d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8765165492429877d,right: 0.7986262317017149d,bottom: 0.2012775757653189d,left: 0.6085954464543581d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.29321451189934566d,right: 0.9604395343956468d,bottom: 0.14387936092334064d,left: 0.6676649391271114d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8501878337604939d,right: 0.9309435016798064d,bottom: 0.7275802958095106d,left: 0.21666000275711672d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7594531400511724d,right: 0.7232000389818738d,bottom: 0.6730877951144196d,left: 0.3037611789955149d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2669752561754186d,right: 0.32365451224124564d,bottom: 0.2045013103244141d,left: 0.29209419747115695d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9518177422124374d,right: 0.4200507653901483d,bottom: 0.1497233175816609d,left: 0.1637108808042096d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.44727162068475834d,right: 0.4148224314035144d,bottom: 0.26813067672151525d,left: 0.041510015852714965d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5029590133305814d,right: 0.8595023867621887d,bottom: 0.3943123930445227d,left: 0.29039816529314777d),
},
            new NpgsqlBoxboxE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8165058638557982d,right: 0.7848324590492199d,bottom: 0.10276862121335895d,left: 0.20124612349968563d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.18901488264701205d,right: 0.8440149182214928d,bottom: 0.0017204382770301674d,left: 0.30860759034179164d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.47712114374423d,right: 0.5999287830613584d,bottom: 0.1361843817951468d,left: 0.2415395541199311d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.35967319327528335d,right: 0.747678852965486d,bottom: 0.3079939130865208d,left: 0.1680261059186725d),
},
            new NpgsqlBoxboxE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5416475804227381d,right: 0.8275002634845456d,bottom: 0.30453868765573056d,left: 0.4410334860842846d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3258554181107596d,right: 0.15879236451579515d,bottom: 0.28093124668246816d,left: 0.1339217880822029d),
},
            new NpgsqlBoxboxE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8986921914050154d,right: 0.6257802160148298d,bottom: 0.277615456873315d,left: 0.31137437246458755d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5760987892904983d,right: 0.9157195426239266d,bottom: 0.48094570120626057d,left: 0.2665182718787402d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9039607970705396d,right: 0.6084784940548544d,bottom: 0.8890712367194478d,left: 0.15191092221635905d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5591341459321604d,right: 0.5333855982835968d,bottom: 0.06051290899614714d,left: 0.29965240636185975d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5745448348824156d,right: 0.7074838482494469d,bottom: 0.46820764294698947d,left: 0.5816982999855769d),
},
            new NpgsqlBoxboxE0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9437670560371508d,right: 0.9690943077953776d,bottom: 0.7596903378815225d,left: 0.3507671648997971d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6800256660477096d,right: 0.7739528496294017d,bottom: 0.6616086316769328d,left: 0.20831061982109678d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6100214937883541d,right: 0.8002033016414356d,bottom: 0.33190217742270056d,left: 0.6108401383761607d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.16115528372069843d,right: 0.7410010151147168d,bottom: 0.06297647873667389d,left: 0.07642812454433257d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6437798801594822d,right: 0.6767707615934153d,bottom: 0.16547504643092237d,left: 0.30224816137490274d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9552906835835535d,right: 0.8861672082262458d,bottom: 0.7174719816471946d,left: 0.4990586486260542d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4442449924225559d,right: 0.36476668152134406d,bottom: 0.2689635521518775d,left: 0.09135552452756746d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2663910016795219d,right: 0.8240934315190248d,bottom: 0.18249752331870817d,left: 0.5528597221720903d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.41644014261973317d,right: 0.5490403387245922d,bottom: 0.02407286839460432d,left: 0.4188116069462251d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.41209536507000566d,right: 0.7787237342342453d,bottom: 0.01183561407439182d,left: 0.40347357468191547d),
},
            new NpgsqlBoxboxE0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6176271511199042d,right: 0.6987373648413763d,bottom: 0.2962554551972304d,left: 0.5152715094841267d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4065009151097516d,right: 0.09939444318164736d,bottom: 0.31154350913455786d,left: 0.01293505225619096d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.30694043417995287d,right: 0.5772792723138364d,bottom: 0.2777635065396089d,left: 0.03513260806815888d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9506759449397731d,right: 0.5457394282894245d,bottom: 0.8263747873393665d,left: 0.17023267984217527d),
},
            new NpgsqlBoxboxE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8257080825661776d,right: 0.87475746790625d,bottom: 0.3512662490988805d,left: 0.7423310604539274d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7064973318425817d,right: 0.7920086966136721d,bottom: 0.47887519890318253d,left: 0.15964536856339018d),
},
            new NpgsqlBoxboxE0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5496779428834973d,right: 0.8679672262526732d,bottom: 0.1879832172614595d,left: 0.3880039473613732d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7418335053946815d,right: 0.8221965603083922d,bottom: 0.36431493611685395d,left: 0.201709890937242d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3339626549991611d,right: 0.5553403220322255d,bottom: 0.13049543372156747d,left: 0.1885387766908463d),
},
            new NpgsqlBoxboxE0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6702823349760244d,right: 0.785925826158841d,bottom: 0.6456059287826528d,left: 0.25383518902983293d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9449937392163018d,right: 0.9091142807711389d,bottom: 0.23823955071447833d,left: 0.2507260320481792d),
},
            new NpgsqlBoxboxE0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7721431807822291d,right: 0.7990935914836232d,bottom: 0.3396062134961809d,left: 0.1265205475723462d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.21654109492850415d,right: 0.3771368302451923d,bottom: 0.036905939417622324d,left: 0.35052908224358337d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7711145708757629d,right: 0.7871910815035267d,bottom: 0.09397784568080525d,left: 0.027005048515220675d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3256692718041786d,right: 0.7067832300912131d,bottom: 0.3115804635565117d,left: 0.6365477516092393d),
},
            new NpgsqlBoxboxE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8301952019051668d,right: 0.8765295370264876d,bottom: 0.35689175253834915d,left: 0.5941822521798928d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5051657933593721d,right: 0.5839257745359655d,bottom: 0.39596904353875917d,left: 0.5595632260548289d),
},
            new NpgsqlBoxboxE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.38502760118368917d,right: 0.9431197029036843d,bottom: 0.16409647090333268d,left: 0.31089163000574604d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6089418943644488d,right: 0.8235209071924219d,bottom: 0.5834295875755184d,left: 0.30761968180055654d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9609008844405637d,right: 0.4011704699040607d,bottom: 0.29586767197173214d,left: 0.08186302898327658d),
},
            new NpgsqlBoxboxE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8582607441105693d,right: 0.40962477998295355d,bottom: 0.8384344406716977d,left: 0.08824981928896425d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.937943542382999d,right: 0.4642688533456265d,bottom: 0.37971532678076736d,left: 0.2592940162669217d),
},
            new NpgsqlBoxboxE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8168326808930543d,right: 0.8134930368106946d,bottom: 0.1750623307813981d,left: 0.7232784585535217d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7523130241321144d,right: 0.6178152256634406d,bottom: 0.0819625803235996d,left: 0.22802063358782365d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4418388005864129d,right: 0.4988129840542094d,bottom: 0.35004607891358985d,left: 0.3621983011406321d),
},
            new NpgsqlBoxboxE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6483290862988845d,right: 0.9787548084852925d,bottom: 0.486350693117499d,left: 0.1263605193212346d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.810308889845936d,right: 0.8415713465294817d,bottom: 0.7795195826101802d,left: 0.3136477160662432d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7875312340209555d,right: 0.8056266365655995d,bottom: 0.6486843008957597d,left: 0.21980879444071755d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6637829490408845d,right: 0.6936087022163274d,bottom: 0.4597902245484765d,left: 0.36701888672440364d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.768251758367815d,right: 0.8348961487782521d,bottom: 0.25596969297991146d,left: 0.31431491217363994d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8901097277583341d,right: 0.54712598284031d,bottom: 0.6216725874847913d,left: 0.41050547505732893d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxboxe0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxboxe0mi_id", 
                methodParametrName: "npgsqlboxboxe0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 4, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 113, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 128, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 123, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 131, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 113, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[9], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[10], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[11], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[12], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[13], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[14], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[15], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[16], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[17], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[18], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[19], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[20], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[14],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[15],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[16],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[17],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[18],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[19],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[20],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[21],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[22],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[23],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[24],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.504664669893461d,right: 0.5182718026795957d,bottom: 0.3221108084756573d,left: 0.14971032494434133d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1266713730040746d,right: 0.7429926448258561d,bottom: 0.04870555665988374d,left: 0.6483115673533061d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6980929298292913d,right: 0.9321676783382428d,bottom: 0.43166644608758675d,left: 0.5110385239520964d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.989767277333459d,right: 0.9117197840652386d,bottom: 0.7722104117976609d,left: 0.6458491465214999d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6649874222570927d,right: 0.7733010895605206d,bottom: 0.3926062701477574d,left: 0.08505849310898139d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6002207348102719d,right: 0.9173037483460418d,bottom: 0.06455210440629722d,left: 0.08048920963072603d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19743397238529037d,right: 0.6778779451232099d,bottom: 0.01858786198641249d,left: 0.4881948858645232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6093551994433126d,right: 0.830054164801514d,bottom: 0.3623608163845138d,left: 0.3972656492998671d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9612911772461821d,right: 0.30987906351434236d,bottom: 0.29715286789846396d,left: 0.12436672859368636d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8667704283980951d,right: 0.7231675215576886d,bottom: 0.2444897114515463d,left: 0.2196037435765239d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.358075159896444d,right: 0.44887866957867806d,bottom: 0.2215076543824075d,left: 0.4375914555664182d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6302951637266655d,right: 0.044195780348168734d,bottom: 0.027439930510333665d,left: 0.025092495743531118d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7875312340209555d,right: 0.8056266365655995d,bottom: 0.6486843008957597d,left: 0.21980879444071755d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3286283573024411d,right: 0.979442751851608d,bottom: 0.17263680594277575d,left: 0.5002564735577559d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6637829490408845d,right: 0.6936087022163274d,bottom: 0.4597902245484765d,left: 0.36701888672440364d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8817557178430009d,right: 0.9009614627210254d,bottom: 0.14833832371397326d,left: 0.5569507517065045d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9637156580155847d,right: 0.7203720161272607d,bottom: 0.3507610180097769d,left: 0.47763633838454533d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8622843616111235d,right: 0.98326854196115d,bottom: 0.054528495170817814d,left: 0.059540429019839136d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.768251758367815d,right: 0.8348961487782521d,bottom: 0.25596969297991146d,left: 0.31431491217363994d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9270550800018994d,right: 0.38248915814513473d,bottom: 0.06132839984977323d,left: 0.21822407216569428d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8901097277583341d,right: 0.54712598284031d,bottom: 0.6216725874847913d,left: 0.41050547505732893d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34898292939646314d,right: 0.855666069537077d,bottom: 0.10318594589986096d,left: 0.7202988515989293d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1942271428756026d,right: 0.6157687959252129d,bottom: 0.17498212684352077d,left: 0.5469529046863512d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8765165492429877d,right: 0.7986262317017149d,bottom: 0.2012775757653189d,left: 0.6085954464543581d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29321451189934566d,right: 0.9604395343956468d,bottom: 0.14387936092334064d,left: 0.6676649391271114d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8501878337604939d,right: 0.9309435016798064d,bottom: 0.7275802958095106d,left: 0.21666000275711672d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7594531400511724d,right: 0.7232000389818738d,bottom: 0.6730877951144196d,left: 0.3037611789955149d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2669752561754186d,right: 0.32365451224124564d,bottom: 0.2045013103244141d,left: 0.29209419747115695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9518177422124374d,right: 0.4200507653901483d,bottom: 0.1497233175816609d,left: 0.1637108808042096d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44727162068475834d,right: 0.4148224314035144d,bottom: 0.26813067672151525d,left: 0.041510015852714965d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5029590133305814d,right: 0.8595023867621887d,bottom: 0.3943123930445227d,left: 0.29039816529314777d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8165058638557982d,right: 0.7848324590492199d,bottom: 0.10276862121335895d,left: 0.20124612349968563d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18901488264701205d,right: 0.8440149182214928d,bottom: 0.0017204382770301674d,left: 0.30860759034179164d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47712114374423d,right: 0.5999287830613584d,bottom: 0.1361843817951468d,left: 0.2415395541199311d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35967319327528335d,right: 0.747678852965486d,bottom: 0.3079939130865208d,left: 0.1680261059186725d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5416475804227381d,right: 0.8275002634845456d,bottom: 0.30453868765573056d,left: 0.4410334860842846d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3258554181107596d,right: 0.15879236451579515d,bottom: 0.28093124668246816d,left: 0.1339217880822029d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8986921914050154d,right: 0.6257802160148298d,bottom: 0.277615456873315d,left: 0.31137437246458755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5760987892904983d,right: 0.9157195426239266d,bottom: 0.48094570120626057d,left: 0.2665182718787402d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9039607970705396d,right: 0.6084784940548544d,bottom: 0.8890712367194478d,left: 0.15191092221635905d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5591341459321604d,right: 0.5333855982835968d,bottom: 0.06051290899614714d,left: 0.29965240636185975d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5745448348824156d,right: 0.7074838482494469d,bottom: 0.46820764294698947d,left: 0.5816982999855769d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9437670560371508d,right: 0.9690943077953776d,bottom: 0.7596903378815225d,left: 0.3507671648997971d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6800256660477096d,right: 0.7739528496294017d,bottom: 0.6616086316769328d,left: 0.20831061982109678d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6100214937883541d,right: 0.8002033016414356d,bottom: 0.33190217742270056d,left: 0.6108401383761607d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16115528372069843d,right: 0.7410010151147168d,bottom: 0.06297647873667389d,left: 0.07642812454433257d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6437798801594822d,right: 0.6767707615934153d,bottom: 0.16547504643092237d,left: 0.30224816137490274d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9552906835835535d,right: 0.8861672082262458d,bottom: 0.7174719816471946d,left: 0.4990586486260542d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4442449924225559d,right: 0.36476668152134406d,bottom: 0.2689635521518775d,left: 0.09135552452756746d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2663910016795219d,right: 0.8240934315190248d,bottom: 0.18249752331870817d,left: 0.5528597221720903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41644014261973317d,right: 0.5490403387245922d,bottom: 0.02407286839460432d,left: 0.4188116069462251d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41209536507000566d,right: 0.7787237342342453d,bottom: 0.01183561407439182d,left: 0.40347357468191547d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6176271511199042d,right: 0.6987373648413763d,bottom: 0.2962554551972304d,left: 0.5152715094841267d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4065009151097516d,right: 0.09939444318164736d,bottom: 0.31154350913455786d,left: 0.01293505225619096d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30694043417995287d,right: 0.5772792723138364d,bottom: 0.2777635065396089d,left: 0.03513260806815888d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9506759449397731d,right: 0.5457394282894245d,bottom: 0.8263747873393665d,left: 0.17023267984217527d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8257080825661776d,right: 0.87475746790625d,bottom: 0.3512662490988805d,left: 0.7423310604539274d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7064973318425817d,right: 0.7920086966136721d,bottom: 0.47887519890318253d,left: 0.15964536856339018d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5496779428834973d,right: 0.8679672262526732d,bottom: 0.1879832172614595d,left: 0.3880039473613732d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7418335053946815d,right: 0.8221965603083922d,bottom: 0.36431493611685395d,left: 0.201709890937242d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3339626549991611d,right: 0.5553403220322255d,bottom: 0.13049543372156747d,left: 0.1885387766908463d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6702823349760244d,right: 0.785925826158841d,bottom: 0.6456059287826528d,left: 0.25383518902983293d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9449937392163018d,right: 0.9091142807711389d,bottom: 0.23823955071447833d,left: 0.2507260320481792d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7721431807822291d,right: 0.7990935914836232d,bottom: 0.3396062134961809d,left: 0.1265205475723462d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21654109492850415d,right: 0.3771368302451923d,bottom: 0.036905939417622324d,left: 0.35052908224358337d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7711145708757629d,right: 0.7871910815035267d,bottom: 0.09397784568080525d,left: 0.027005048515220675d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3256692718041786d,right: 0.7067832300912131d,bottom: 0.3115804635565117d,left: 0.6365477516092393d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8301952019051668d,right: 0.8765295370264876d,bottom: 0.35689175253834915d,left: 0.5941822521798928d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5051657933593721d,right: 0.5839257745359655d,bottom: 0.39596904353875917d,left: 0.5595632260548289d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38502760118368917d,right: 0.9431197029036843d,bottom: 0.16409647090333268d,left: 0.31089163000574604d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6089418943644488d,right: 0.8235209071924219d,bottom: 0.5834295875755184d,left: 0.30761968180055654d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9609008844405637d,right: 0.4011704699040607d,bottom: 0.29586767197173214d,left: 0.08186302898327658d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8582607441105693d,right: 0.40962477998295355d,bottom: 0.8384344406716977d,left: 0.08824981928896425d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.937943542382999d,right: 0.4642688533456265d,bottom: 0.37971532678076736d,left: 0.2592940162669217d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8168326808930543d,right: 0.8134930368106946d,bottom: 0.1750623307813981d,left: 0.7232784585535217d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7523130241321144d,right: 0.6178152256634406d,bottom: 0.0819625803235996d,left: 0.22802063358782365d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4418388005864129d,right: 0.4988129840542094d,bottom: 0.35004607891358985d,left: 0.3621983011406321d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6483290862988845d,right: 0.9787548084852925d,bottom: 0.486350693117499d,left: 0.1263605193212346d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.810308889845936d,right: 0.8415713465294817d,bottom: 0.7795195826101802d,left: 0.3136477160662432d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.504664669893461d,right: 0.5182718026795957d,bottom: 0.3221108084756573d,left: 0.14971032494434133d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1266713730040746d,right: 0.7429926448258561d,bottom: 0.04870555665988374d,left: 0.6483115673533061d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6980929298292913d,right: 0.9321676783382428d,bottom: 0.43166644608758675d,left: 0.5110385239520964d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.989767277333459d,right: 0.9117197840652386d,bottom: 0.7722104117976609d,left: 0.6458491465214999d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6649874222570927d,right: 0.7733010895605206d,bottom: 0.3926062701477574d,left: 0.08505849310898139d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6002207348102719d,right: 0.9173037483460418d,bottom: 0.06455210440629722d,left: 0.08048920963072603d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19743397238529037d,right: 0.6778779451232099d,bottom: 0.01858786198641249d,left: 0.4881948858645232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6093551994433126d,right: 0.830054164801514d,bottom: 0.3623608163845138d,left: 0.3972656492998671d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9612911772461821d,right: 0.30987906351434236d,bottom: 0.29715286789846396d,left: 0.12436672859368636d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8667704283980951d,right: 0.7231675215576886d,bottom: 0.2444897114515463d,left: 0.2196037435765239d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.358075159896444d,right: 0.44887866957867806d,bottom: 0.2215076543824075d,left: 0.4375914555664182d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6302951637266655d,right: 0.044195780348168734d,bottom: 0.027439930510333665d,left: 0.025092495743531118d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7875312340209555d,right: 0.8056266365655995d,bottom: 0.6486843008957597d,left: 0.21980879444071755d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3286283573024411d,right: 0.979442751851608d,bottom: 0.17263680594277575d,left: 0.5002564735577559d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6637829490408845d,right: 0.6936087022163274d,bottom: 0.4597902245484765d,left: 0.36701888672440364d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8817557178430009d,right: 0.9009614627210254d,bottom: 0.14833832371397326d,left: 0.5569507517065045d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9637156580155847d,right: 0.7203720161272607d,bottom: 0.3507610180097769d,left: 0.47763633838454533d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8622843616111235d,right: 0.98326854196115d,bottom: 0.054528495170817814d,left: 0.059540429019839136d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.768251758367815d,right: 0.8348961487782521d,bottom: 0.25596969297991146d,left: 0.31431491217363994d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9270550800018994d,right: 0.38248915814513473d,bottom: 0.06132839984977323d,left: 0.21822407216569428d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8901097277583341d,right: 0.54712598284031d,bottom: 0.6216725874847913d,left: 0.41050547505732893d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34898292939646314d,right: 0.855666069537077d,bottom: 0.10318594589986096d,left: 0.7202988515989293d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1942271428756026d,right: 0.6157687959252129d,bottom: 0.17498212684352077d,left: 0.5469529046863512d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8765165492429877d,right: 0.7986262317017149d,bottom: 0.2012775757653189d,left: 0.6085954464543581d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29321451189934566d,right: 0.9604395343956468d,bottom: 0.14387936092334064d,left: 0.6676649391271114d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8501878337604939d,right: 0.9309435016798064d,bottom: 0.7275802958095106d,left: 0.21666000275711672d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7594531400511724d,right: 0.7232000389818738d,bottom: 0.6730877951144196d,left: 0.3037611789955149d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2669752561754186d,right: 0.32365451224124564d,bottom: 0.2045013103244141d,left: 0.29209419747115695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9518177422124374d,right: 0.4200507653901483d,bottom: 0.1497233175816609d,left: 0.1637108808042096d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44727162068475834d,right: 0.4148224314035144d,bottom: 0.26813067672151525d,left: 0.041510015852714965d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5029590133305814d,right: 0.8595023867621887d,bottom: 0.3943123930445227d,left: 0.29039816529314777d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8165058638557982d,right: 0.7848324590492199d,bottom: 0.10276862121335895d,left: 0.20124612349968563d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18901488264701205d,right: 0.8440149182214928d,bottom: 0.0017204382770301674d,left: 0.30860759034179164d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47712114374423d,right: 0.5999287830613584d,bottom: 0.1361843817951468d,left: 0.2415395541199311d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35967319327528335d,right: 0.747678852965486d,bottom: 0.3079939130865208d,left: 0.1680261059186725d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5416475804227381d,right: 0.8275002634845456d,bottom: 0.30453868765573056d,left: 0.4410334860842846d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3258554181107596d,right: 0.15879236451579515d,bottom: 0.28093124668246816d,left: 0.1339217880822029d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8986921914050154d,right: 0.6257802160148298d,bottom: 0.277615456873315d,left: 0.31137437246458755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5760987892904983d,right: 0.9157195426239266d,bottom: 0.48094570120626057d,left: 0.2665182718787402d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9039607970705396d,right: 0.6084784940548544d,bottom: 0.8890712367194478d,left: 0.15191092221635905d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5591341459321604d,right: 0.5333855982835968d,bottom: 0.06051290899614714d,left: 0.29965240636185975d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5745448348824156d,right: 0.7074838482494469d,bottom: 0.46820764294698947d,left: 0.5816982999855769d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9437670560371508d,right: 0.9690943077953776d,bottom: 0.7596903378815225d,left: 0.3507671648997971d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6800256660477096d,right: 0.7739528496294017d,bottom: 0.6616086316769328d,left: 0.20831061982109678d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6100214937883541d,right: 0.8002033016414356d,bottom: 0.33190217742270056d,left: 0.6108401383761607d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.16115528372069843d,right: 0.7410010151147168d,bottom: 0.06297647873667389d,left: 0.07642812454433257d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6437798801594822d,right: 0.6767707615934153d,bottom: 0.16547504643092237d,left: 0.30224816137490274d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9552906835835535d,right: 0.8861672082262458d,bottom: 0.7174719816471946d,left: 0.4990586486260542d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4442449924225559d,right: 0.36476668152134406d,bottom: 0.2689635521518775d,left: 0.09135552452756746d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2663910016795219d,right: 0.8240934315190248d,bottom: 0.18249752331870817d,left: 0.5528597221720903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41644014261973317d,right: 0.5490403387245922d,bottom: 0.02407286839460432d,left: 0.4188116069462251d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41209536507000566d,right: 0.7787237342342453d,bottom: 0.01183561407439182d,left: 0.40347357468191547d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6176271511199042d,right: 0.6987373648413763d,bottom: 0.2962554551972304d,left: 0.5152715094841267d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4065009151097516d,right: 0.09939444318164736d,bottom: 0.31154350913455786d,left: 0.01293505225619096d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30694043417995287d,right: 0.5772792723138364d,bottom: 0.2777635065396089d,left: 0.03513260806815888d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9506759449397731d,right: 0.5457394282894245d,bottom: 0.8263747873393665d,left: 0.17023267984217527d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8257080825661776d,right: 0.87475746790625d,bottom: 0.3512662490988805d,left: 0.7423310604539274d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7064973318425817d,right: 0.7920086966136721d,bottom: 0.47887519890318253d,left: 0.15964536856339018d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5496779428834973d,right: 0.8679672262526732d,bottom: 0.1879832172614595d,left: 0.3880039473613732d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7418335053946815d,right: 0.8221965603083922d,bottom: 0.36431493611685395d,left: 0.201709890937242d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3339626549991611d,right: 0.5553403220322255d,bottom: 0.13049543372156747d,left: 0.1885387766908463d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6702823349760244d,right: 0.785925826158841d,bottom: 0.6456059287826528d,left: 0.25383518902983293d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9449937392163018d,right: 0.9091142807711389d,bottom: 0.23823955071447833d,left: 0.2507260320481792d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7721431807822291d,right: 0.7990935914836232d,bottom: 0.3396062134961809d,left: 0.1265205475723462d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21654109492850415d,right: 0.3771368302451923d,bottom: 0.036905939417622324d,left: 0.35052908224358337d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7711145708757629d,right: 0.7871910815035267d,bottom: 0.09397784568080525d,left: 0.027005048515220675d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3256692718041786d,right: 0.7067832300912131d,bottom: 0.3115804635565117d,left: 0.6365477516092393d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8301952019051668d,right: 0.8765295370264876d,bottom: 0.35689175253834915d,left: 0.5941822521798928d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5051657933593721d,right: 0.5839257745359655d,bottom: 0.39596904353875917d,left: 0.5595632260548289d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38502760118368917d,right: 0.9431197029036843d,bottom: 0.16409647090333268d,left: 0.31089163000574604d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6089418943644488d,right: 0.8235209071924219d,bottom: 0.5834295875755184d,left: 0.30761968180055654d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9609008844405637d,right: 0.4011704699040607d,bottom: 0.29586767197173214d,left: 0.08186302898327658d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8582607441105693d,right: 0.40962477998295355d,bottom: 0.8384344406716977d,left: 0.08824981928896425d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.937943542382999d,right: 0.4642688533456265d,bottom: 0.37971532678076736d,left: 0.2592940162669217d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8168326808930543d,right: 0.8134930368106946d,bottom: 0.1750623307813981d,left: 0.7232784585535217d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7523130241321144d,right: 0.6178152256634406d,bottom: 0.0819625803235996d,left: 0.22802063358782365d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4418388005864129d,right: 0.4988129840542094d,bottom: 0.35004607891358985d,left: 0.3621983011406321d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6483290862988845d,right: 0.9787548084852925d,bottom: 0.486350693117499d,left: 0.1263605193212346d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.810308889845936d,right: 0.8415713465294817d,bottom: 0.7795195826101802d,left: 0.3136477160662432d))));

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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxboxe0m m
LEFT JOIN public.binary_npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI), typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

