

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

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.43641505554453774d,right: 0.7058908158139219d,bottom: 0.32862046583190896d,left: 0.49062891755176974d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8997634974127698d,right: 0.3910398712339902d,bottom: 0.8842401866127927d,left: 0.041017080449999965d),
},
            new NpgsqlBoxbox0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6583979775720047d,right: 0.9599109204794039d,bottom: 0.5855247345106024d,left: 0.9198006838190553d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7777202209529341d,right: 0.7894737829127774d,bottom: 0.6268663688636575d,left: 0.7089703062029887d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.801222321684394d,right: 0.3034493069247528d,bottom: 0.028008907600032495d,left: 0.27242404519152874d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6103390742627263d,right: 0.5536786596299806d,bottom: 0.43911423645293235d,left: 0.05504853606974802d),
},
            new NpgsqlBoxbox0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5102563063948053d,right: 0.3172621907637403d,bottom: 0.44750709640962827d,left: 0.29998573630636804d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.09337839112656832d,right: 0.95785493853047d,bottom: 0.08505318850409638d,left: 0.9276002360979616d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.30575223593188217d,right: 0.5577321123949681d,bottom: 0.26629215599194456d,left: 0.30711446223075456d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.26174123265535876d,right: 0.15542562083198608d,bottom: 0.006497510109686244d,left: 0.10930440828787136d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5914300536567747d,right: 0.25121078123788054d,bottom: 0.41298560961633557d,left: 0.2504766213278231d),
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9288897952238135d,right: 0.18095284262660705d,bottom: 0.3202461922734966d,left: 0.13511256804648308d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3158741042913087d,right: 0.323942165355375d,bottom: 0.20807091502652353d,left: 0.0789158446723397d),
},
            new NpgsqlBoxbox0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9182292813335587d,right: 0.5544557917621344d,bottom: 0.24968568822793824d,left: 0.2421261139596821d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.943845380770336d,right: 0.15117952033782533d,bottom: 0.659882621413018d,left: 0.14678891434129737d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3906319638704484d,right: 0.8858086029027366d,bottom: 0.060948680628951535d,left: 0.11611979061140576d),
},
            new NpgsqlBoxbox0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8416790289144416d,right: 0.3787489327268909d,bottom: 0.15557436016989656d,left: 0.25123001788140487d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7347013001076877d,right: 0.955427938723596d,bottom: 0.16799368907072454d,left: 0.8017515462074d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.910632402273235d,right: 0.6981388301234663d,bottom: 0.36781271156177964d,left: 0.10574963538130067d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.46781356724379475d,right: 0.9154238147161866d,bottom: 0.4309362226085971d,left: 0.2744212716111635d),
},
            new NpgsqlBoxbox0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2791090238579794d,right: 0.9036086855378559d,bottom: 0.03436471096045446d,left: 0.13505805459614373d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8351389518349834d,right: 0.7829702306177493d,bottom: 0.5172557557436916d,left: 0.6930011146078836d),
},
            new NpgsqlBoxbox0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.656850664609169d,right: 0.8361730372872913d,bottom: 0.20674173022644227d,left: 0.676026301380624d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.796735941751901d,right: 0.16090856822257427d,bottom: 0.6901766626156829d,left: 0.044114854065957165d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7241209880978601d,right: 0.8378735490937312d,bottom: 0.6559171875952862d,left: 0.4658778372993939d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.22675407475989373d,right: 0.9413074968470821d,bottom: 0.16623822068206162d,left: 0.6779592855892042d),
},
            new NpgsqlBoxbox0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6953544716814908d,right: 0.6833412112089421d,bottom: 0.6356550213384677d,left: 0.5593532056349497d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3980752761716968d,right: 0.9740012993866628d,bottom: 0.18223411132793665d,left: 0.43666028084197817d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3466896586637449d,right: 0.6127938436324593d,bottom: 0.030213788130225128d,left: 0.17466111331041922d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.41791252460213546d,right: 0.9752781784128051d,bottom: 0.25902478132624873d,left: 0.41726688087596653d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3180836679530712d,right: 0.7876198933758296d,bottom: 0.28016928987999157d,left: 0.3749584242278987d),
},
            new NpgsqlBoxbox0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8076666757647246d,right: 0.7196864972715422d,bottom: 0.6861401401094507d,left: 0.48901901877896037d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9449278693852031d,right: 0.8870152714776898d,bottom: 0.5861626393399486d,left: 0.42349045130254914d),
},
            new NpgsqlBoxbox0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4938636965756146d,right: 0.999939732711966d,bottom: 0.1797630671345909d,left: 0.9207307174323118d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9813003134807844d,right: 0.8545405862536518d,bottom: 0.3539591089972882d,left: 0.43116018905173104d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6991251336730332d,right: 0.5370480674223366d,bottom: 0.10906249752256292d,left: 0.4760217121667101d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6135101279013041d,right: 0.6016487933187894d,bottom: 0.3768988161758883d,left: 0.5337542016370046d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.38274709630329684d,right: 0.30136613350587604d,bottom: 0.33022293417291915d,left: 0.06181870766670228d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6588432101288922d,right: 0.9529614474934951d,bottom: 0.0392976266531061d,left: 0.4361391505528912d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5817150680357566d,right: 0.8464491061814471d,bottom: 0.3379094106330772d,left: 0.1701868617863609d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8644193269872471d,right: 0.2550257787359972d,bottom: 0.7928931902325612d,left: 0.08629762456037215d),
},
            new NpgsqlBoxbox0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9332426855411691d,right: 0.798523712972169d,bottom: 0.4262803990045596d,left: 0.5280887550868602d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6968411855959129d,right: 0.32169425750057656d,bottom: 0.1322584038638539d,left: 0.29684011661913523d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.46698760607936796d,right: 0.346624945712402d,bottom: 0.27311006187036047d,left: 0.04271175743871114d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5558379198969031d,right: 0.5182980243662818d,bottom: 0.5476783710655834d,left: 0.4959677610193851d),
},
            new NpgsqlBoxbox0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8354101397192818d,right: 0.5863245299271452d,bottom: 0.6410517744518384d,left: 0.5288782992613557d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6055263672924268d,right: 0.8732422812721001d,bottom: 0.03377332842919778d,left: 0.5559872927950065d),
},
            new NpgsqlBoxbox0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4341978703582443d,right: 0.8765409572205569d,bottom: 0.01725038248437305d,left: 0.634069629947336d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9307279107865115d,right: 0.6787451521614607d,bottom: 0.7752573806627584d,left: 0.4600353783257176d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6485862243222289d,right: 0.8721717216658048d,bottom: 0.6453900494037256d,left: 0.7821035034521746d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8841567171025797d,right: 0.9885399142876076d,bottom: 0.005764549816204667d,left: 0.16797742519530534d),
},
            new NpgsqlBoxbox0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6378279581285593d,right: 0.8245832366385528d,bottom: 0.1524938765167816d,left: 0.17629704738772067d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6301302394652435d,right: 0.9195226500565563d,bottom: 0.2823216412015297d,left: 0.15005699326771837d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5206755968790987d,right: 0.4208515513423906d,bottom: 0.17030199672018553d,left: 0.31653647056382406d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7276335201832203d,right: 0.5346188279781234d,bottom: 0.4418130024997744d,left: 0.5076056143684894d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5528617448223574d,right: 0.94788552272015d,bottom: 0.010218798927883799d,left: 0.86380585105286d),
},
            new NpgsqlBoxbox0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9461427822918499d,right: 0.7021645845111166d,bottom: 0.47539058213407404d,left: 0.6769020562574415d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8975248135962672d,right: 0.7902025515471495d,bottom: 0.26714019825047364d,left: 0.445894975599591d),
},
            new NpgsqlBoxbox0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.781047274180001d,right: 0.8820276968104984d,bottom: 0.4731906204980758d,left: 0.6208612281320337d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5226496117059803d,right: 0.6666781514687649d,bottom: 0.3170980534055081d,left: 0.20839430347375654d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8315876166897742d,right: 0.40080262011405876d,bottom: 0.16024377147004676d,left: 0.3408394856721264d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6598005461839561d,right: 0.6714272472835389d,bottom: 0.2494271897889132d,left: 0.2194330998393551d),
},
            new NpgsqlBoxbox0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5860215180200232d,right: 0.6895672676335055d,bottom: 0.5724058892748576d,left: 0.08808123276418522d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9914111170762476d,right: 0.8142035443071d,bottom: 0.41587582077480123d,left: 0.6119765780981895d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.596676358197913d,right: 0.6671828576600797d,bottom: 0.0625582518099902d,left: 0.4795203904572104d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6706760913328976d,right: 0.7724537422329921d,bottom: 0.3942358722341912d,left: 0.011304680531329825d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8473373308395642d,right: 0.9721410550628711d,bottom: 0.01779688202786145d,left: 0.32698683806480655d),
},
            new NpgsqlBoxbox0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4055875082832091d,right: 0.933083110828992d,bottom: 0.2089126895989798d,left: 0.6541927196403171d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8363550613907889d,right: 0.686092507928968d,bottom: 0.8132702920974687d,left: 0.32920633520596d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1150700908448461d,right: 0.23605278324641965d,bottom: 0.08162490715084325d,left: 0.04968313994593032d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9554616728729188d,right: 0.7039603503361765d,bottom: 0.44857637848928056d,left: 0.31817090812912396d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4285703354167667d,right: 0.754141257678335d,bottom: 0.38583320346067496d,left: 0.30091418193250996d),
},
            new NpgsqlBoxbox0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17960231513293134d,right: 0.8732236692480345d,bottom: 0.1196903368660972d,left: 0.06269062142863546d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9864726387536892d,right: 0.7065100310834099d,bottom: 0.3804857318730618d,left: 0.531681361962382d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6852092274014966d,right: 0.4717519350069268d,bottom: 0.18756698826165707d,left: 0.01942652021032698d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9765466251764958d,right: 0.6844486646659816d,bottom: 0.07510855896130597d,left: 0.5512576043835236d),
},
            new NpgsqlBoxbox0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.628083307827179d,right: 0.9934660456037265d,bottom: 0.6193005802912183d,left: 0.29482717817704385d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8609153644014977d,right: 0.9112954481587153d,bottom: 0.05885298700310215d,left: 0.02148343783310236d),
},
            new NpgsqlBoxbox0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46891848722662455d,right: 0.7968640555246786d,bottom: 0.0990802250749746d,left: 0.27459877969251434d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8783258020706664d,right: 0.6925824847994598d,bottom: 0.28529925435632586d,left: 0.42994538436412555d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6083331613236422d,right: 0.5986760640524776d,bottom: 0.4510707442508871d,left: 0.046663028929771144d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.32257552394234856d,right: 0.2239358430089179d,bottom: 0.24384328029523572d,left: 0.08462463361343775d),
},
            new NpgsqlBoxbox0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6932253030553129d,right: 0.6328318020719572d,bottom: 0.05073280033030636d,left: 0.21956650060803296d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.903423467135396d,right: 0.698502336802358d,bottom: 0.5758398867607857d,left: 0.08274620210467609d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9831271444500702d,right: 0.1363579157575301d,bottom: 0.32700259716436786d,left: 0.09322500638444309d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.728679875201515d,right: 0.7067727503935566d,bottom: 0.3899735554004131d,left: 0.23900183669215824d),
},
            new NpgsqlBoxbox0M
{
    Id = 177,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5355854603308887d,right: 0.36669588916588935d,bottom: 0.15675372484306627d,left: 0.12934354600623688d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.47043221362726373d,right: 0.7236148565052295d,bottom: 0.11964855221390647d,left: 0.6729237313220301d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
INSERT INTO public.npgsqlboxbox0mi(
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
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
                methodParametrName: "npgsqlboxbox0mi_id", 
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
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3158741042913087d,right: 0.323942165355375d,bottom: 0.20807091502652353d,left: 0.0789158446723397d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3906319638704484d,right: 0.8858086029027366d,bottom: 0.060948680628951535d,left: 0.11611979061140576d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.46781356724379475d,right: 0.9154238147161866d,bottom: 0.4309362226085971d,left: 0.2744212716111635d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8351389518349834d,right: 0.7829702306177493d,bottom: 0.5172557557436916d,left: 0.6930011146078836d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.22675407475989373d,right: 0.9413074968470821d,bottom: 0.16623822068206162d,left: 0.6779592855892042d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3180836679530712d,right: 0.7876198933758296d,bottom: 0.28016928987999157d,left: 0.3749584242278987d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
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
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 160;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[34], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 101, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 62, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 120, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 96, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 81, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[34], false);
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
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 132, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[26],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[27],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[28],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[29],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43641505554453774d,right: 0.7058908158139219d,bottom: 0.32862046583190896d,left: 0.49062891755176974d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8997634974127698d,right: 0.3910398712339902d,bottom: 0.8842401866127927d,left: 0.041017080449999965d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6583979775720047d,right: 0.9599109204794039d,bottom: 0.5855247345106024d,left: 0.9198006838190553d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7777202209529341d,right: 0.7894737829127774d,bottom: 0.6268663688636575d,left: 0.7089703062029887d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.801222321684394d,right: 0.3034493069247528d,bottom: 0.028008907600032495d,left: 0.27242404519152874d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6103390742627263d,right: 0.5536786596299806d,bottom: 0.43911423645293235d,left: 0.05504853606974802d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5102563063948053d,right: 0.3172621907637403d,bottom: 0.44750709640962827d,left: 0.29998573630636804d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.09337839112656832d,right: 0.95785493853047d,bottom: 0.08505318850409638d,left: 0.9276002360979616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30575223593188217d,right: 0.5577321123949681d,bottom: 0.26629215599194456d,left: 0.30711446223075456d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.26174123265535876d,right: 0.15542562083198608d,bottom: 0.006497510109686244d,left: 0.10930440828787136d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5914300536567747d,right: 0.25121078123788054d,bottom: 0.41298560961633557d,left: 0.2504766213278231d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9288897952238135d,right: 0.18095284262660705d,bottom: 0.3202461922734966d,left: 0.13511256804648308d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3158741042913087d,right: 0.323942165355375d,bottom: 0.20807091502652353d,left: 0.0789158446723397d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9182292813335587d,right: 0.5544557917621344d,bottom: 0.24968568822793824d,left: 0.2421261139596821d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.943845380770336d,right: 0.15117952033782533d,bottom: 0.659882621413018d,left: 0.14678891434129737d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3906319638704484d,right: 0.8858086029027366d,bottom: 0.060948680628951535d,left: 0.11611979061140576d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8416790289144416d,right: 0.3787489327268909d,bottom: 0.15557436016989656d,left: 0.25123001788140487d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7347013001076877d,right: 0.955427938723596d,bottom: 0.16799368907072454d,left: 0.8017515462074d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.910632402273235d,right: 0.6981388301234663d,bottom: 0.36781271156177964d,left: 0.10574963538130067d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46781356724379475d,right: 0.9154238147161866d,bottom: 0.4309362226085971d,left: 0.2744212716111635d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2791090238579794d,right: 0.9036086855378559d,bottom: 0.03436471096045446d,left: 0.13505805459614373d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8351389518349834d,right: 0.7829702306177493d,bottom: 0.5172557557436916d,left: 0.6930011146078836d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.656850664609169d,right: 0.8361730372872913d,bottom: 0.20674173022644227d,left: 0.676026301380624d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.796735941751901d,right: 0.16090856822257427d,bottom: 0.6901766626156829d,left: 0.044114854065957165d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7241209880978601d,right: 0.8378735490937312d,bottom: 0.6559171875952862d,left: 0.4658778372993939d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22675407475989373d,right: 0.9413074968470821d,bottom: 0.16623822068206162d,left: 0.6779592855892042d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6953544716814908d,right: 0.6833412112089421d,bottom: 0.6356550213384677d,left: 0.5593532056349497d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3980752761716968d,right: 0.9740012993866628d,bottom: 0.18223411132793665d,left: 0.43666028084197817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3466896586637449d,right: 0.6127938436324593d,bottom: 0.030213788130225128d,left: 0.17466111331041922d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41791252460213546d,right: 0.9752781784128051d,bottom: 0.25902478132624873d,left: 0.41726688087596653d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3180836679530712d,right: 0.7876198933758296d,bottom: 0.28016928987999157d,left: 0.3749584242278987d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8076666757647246d,right: 0.7196864972715422d,bottom: 0.6861401401094507d,left: 0.48901901877896037d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9449278693852031d,right: 0.8870152714776898d,bottom: 0.5861626393399486d,left: 0.42349045130254914d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4938636965756146d,right: 0.999939732711966d,bottom: 0.1797630671345909d,left: 0.9207307174323118d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9813003134807844d,right: 0.8545405862536518d,bottom: 0.3539591089972882d,left: 0.43116018905173104d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6991251336730332d,right: 0.5370480674223366d,bottom: 0.10906249752256292d,left: 0.4760217121667101d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6135101279013041d,right: 0.6016487933187894d,bottom: 0.3768988161758883d,left: 0.5337542016370046d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38274709630329684d,right: 0.30136613350587604d,bottom: 0.33022293417291915d,left: 0.06181870766670228d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6588432101288922d,right: 0.9529614474934951d,bottom: 0.0392976266531061d,left: 0.4361391505528912d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5817150680357566d,right: 0.8464491061814471d,bottom: 0.3379094106330772d,left: 0.1701868617863609d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8644193269872471d,right: 0.2550257787359972d,bottom: 0.7928931902325612d,left: 0.08629762456037215d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9332426855411691d,right: 0.798523712972169d,bottom: 0.4262803990045596d,left: 0.5280887550868602d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6968411855959129d,right: 0.32169425750057656d,bottom: 0.1322584038638539d,left: 0.29684011661913523d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46698760607936796d,right: 0.346624945712402d,bottom: 0.27311006187036047d,left: 0.04271175743871114d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5558379198969031d,right: 0.5182980243662818d,bottom: 0.5476783710655834d,left: 0.4959677610193851d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8354101397192818d,right: 0.5863245299271452d,bottom: 0.6410517744518384d,left: 0.5288782992613557d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6055263672924268d,right: 0.8732422812721001d,bottom: 0.03377332842919778d,left: 0.5559872927950065d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4341978703582443d,right: 0.8765409572205569d,bottom: 0.01725038248437305d,left: 0.634069629947336d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9307279107865115d,right: 0.6787451521614607d,bottom: 0.7752573806627584d,left: 0.4600353783257176d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6485862243222289d,right: 0.8721717216658048d,bottom: 0.6453900494037256d,left: 0.7821035034521746d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8841567171025797d,right: 0.9885399142876076d,bottom: 0.005764549816204667d,left: 0.16797742519530534d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6378279581285593d,right: 0.8245832366385528d,bottom: 0.1524938765167816d,left: 0.17629704738772067d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6301302394652435d,right: 0.9195226500565563d,bottom: 0.2823216412015297d,left: 0.15005699326771837d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5206755968790987d,right: 0.4208515513423906d,bottom: 0.17030199672018553d,left: 0.31653647056382406d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7276335201832203d,right: 0.5346188279781234d,bottom: 0.4418130024997744d,left: 0.5076056143684894d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5528617448223574d,right: 0.94788552272015d,bottom: 0.010218798927883799d,left: 0.86380585105286d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9461427822918499d,right: 0.7021645845111166d,bottom: 0.47539058213407404d,left: 0.6769020562574415d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8975248135962672d,right: 0.7902025515471495d,bottom: 0.26714019825047364d,left: 0.445894975599591d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.781047274180001d,right: 0.8820276968104984d,bottom: 0.4731906204980758d,left: 0.6208612281320337d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5226496117059803d,right: 0.6666781514687649d,bottom: 0.3170980534055081d,left: 0.20839430347375654d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8315876166897742d,right: 0.40080262011405876d,bottom: 0.16024377147004676d,left: 0.3408394856721264d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6598005461839561d,right: 0.6714272472835389d,bottom: 0.2494271897889132d,left: 0.2194330998393551d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5860215180200232d,right: 0.6895672676335055d,bottom: 0.5724058892748576d,left: 0.08808123276418522d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9914111170762476d,right: 0.8142035443071d,bottom: 0.41587582077480123d,left: 0.6119765780981895d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.596676358197913d,right: 0.6671828576600797d,bottom: 0.0625582518099902d,left: 0.4795203904572104d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6706760913328976d,right: 0.7724537422329921d,bottom: 0.3942358722341912d,left: 0.011304680531329825d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8473373308395642d,right: 0.9721410550628711d,bottom: 0.01779688202786145d,left: 0.32698683806480655d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4055875082832091d,right: 0.933083110828992d,bottom: 0.2089126895989798d,left: 0.6541927196403171d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8363550613907889d,right: 0.686092507928968d,bottom: 0.8132702920974687d,left: 0.32920633520596d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1150700908448461d,right: 0.23605278324641965d,bottom: 0.08162490715084325d,left: 0.04968313994593032d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9554616728729188d,right: 0.7039603503361765d,bottom: 0.44857637848928056d,left: 0.31817090812912396d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4285703354167667d,right: 0.754141257678335d,bottom: 0.38583320346067496d,left: 0.30091418193250996d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17960231513293134d,right: 0.8732236692480345d,bottom: 0.1196903368660972d,left: 0.06269062142863546d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9864726387536892d,right: 0.7065100310834099d,bottom: 0.3804857318730618d,left: 0.531681361962382d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6852092274014966d,right: 0.4717519350069268d,bottom: 0.18756698826165707d,left: 0.01942652021032698d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9765466251764958d,right: 0.6844486646659816d,bottom: 0.07510855896130597d,left: 0.5512576043835236d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.628083307827179d,right: 0.9934660456037265d,bottom: 0.6193005802912183d,left: 0.29482717817704385d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8609153644014977d,right: 0.9112954481587153d,bottom: 0.05885298700310215d,left: 0.02148343783310236d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46891848722662455d,right: 0.7968640555246786d,bottom: 0.0990802250749746d,left: 0.27459877969251434d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8783258020706664d,right: 0.6925824847994598d,bottom: 0.28529925435632586d,left: 0.42994538436412555d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6083331613236422d,right: 0.5986760640524776d,bottom: 0.4510707442508871d,left: 0.046663028929771144d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.32257552394234856d,right: 0.2239358430089179d,bottom: 0.24384328029523572d,left: 0.08462463361343775d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6932253030553129d,right: 0.6328318020719572d,bottom: 0.05073280033030636d,left: 0.21956650060803296d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.903423467135396d,right: 0.698502336802358d,bottom: 0.5758398867607857d,left: 0.08274620210467609d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9831271444500702d,right: 0.1363579157575301d,bottom: 0.32700259716436786d,left: 0.09322500638444309d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.728679875201515d,right: 0.7067727503935566d,bottom: 0.3899735554004131d,left: 0.23900183669215824d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5355854603308887d,right: 0.36669588916588935d,bottom: 0.15675372484306627d,left: 0.12934354600623688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47043221362726373d,right: 0.7236148565052295d,bottom: 0.11964855221390647d,left: 0.6729237313220301d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43641505554453774d,right: 0.7058908158139219d,bottom: 0.32862046583190896d,left: 0.49062891755176974d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8997634974127698d,right: 0.3910398712339902d,bottom: 0.8842401866127927d,left: 0.041017080449999965d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6583979775720047d,right: 0.9599109204794039d,bottom: 0.5855247345106024d,left: 0.9198006838190553d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7777202209529341d,right: 0.7894737829127774d,bottom: 0.6268663688636575d,left: 0.7089703062029887d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.801222321684394d,right: 0.3034493069247528d,bottom: 0.028008907600032495d,left: 0.27242404519152874d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6103390742627263d,right: 0.5536786596299806d,bottom: 0.43911423645293235d,left: 0.05504853606974802d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5102563063948053d,right: 0.3172621907637403d,bottom: 0.44750709640962827d,left: 0.29998573630636804d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.09337839112656832d,right: 0.95785493853047d,bottom: 0.08505318850409638d,left: 0.9276002360979616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30575223593188217d,right: 0.5577321123949681d,bottom: 0.26629215599194456d,left: 0.30711446223075456d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.26174123265535876d,right: 0.15542562083198608d,bottom: 0.006497510109686244d,left: 0.10930440828787136d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5914300536567747d,right: 0.25121078123788054d,bottom: 0.41298560961633557d,left: 0.2504766213278231d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9288897952238135d,right: 0.18095284262660705d,bottom: 0.3202461922734966d,left: 0.13511256804648308d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3158741042913087d,right: 0.323942165355375d,bottom: 0.20807091502652353d,left: 0.0789158446723397d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9182292813335587d,right: 0.5544557917621344d,bottom: 0.24968568822793824d,left: 0.2421261139596821d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.943845380770336d,right: 0.15117952033782533d,bottom: 0.659882621413018d,left: 0.14678891434129737d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3906319638704484d,right: 0.8858086029027366d,bottom: 0.060948680628951535d,left: 0.11611979061140576d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8416790289144416d,right: 0.3787489327268909d,bottom: 0.15557436016989656d,left: 0.25123001788140487d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7347013001076877d,right: 0.955427938723596d,bottom: 0.16799368907072454d,left: 0.8017515462074d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.910632402273235d,right: 0.6981388301234663d,bottom: 0.36781271156177964d,left: 0.10574963538130067d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46781356724379475d,right: 0.9154238147161866d,bottom: 0.4309362226085971d,left: 0.2744212716111635d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2791090238579794d,right: 0.9036086855378559d,bottom: 0.03436471096045446d,left: 0.13505805459614373d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8351389518349834d,right: 0.7829702306177493d,bottom: 0.5172557557436916d,left: 0.6930011146078836d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.656850664609169d,right: 0.8361730372872913d,bottom: 0.20674173022644227d,left: 0.676026301380624d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.796735941751901d,right: 0.16090856822257427d,bottom: 0.6901766626156829d,left: 0.044114854065957165d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7241209880978601d,right: 0.8378735490937312d,bottom: 0.6559171875952862d,left: 0.4658778372993939d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22675407475989373d,right: 0.9413074968470821d,bottom: 0.16623822068206162d,left: 0.6779592855892042d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6953544716814908d,right: 0.6833412112089421d,bottom: 0.6356550213384677d,left: 0.5593532056349497d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3980752761716968d,right: 0.9740012993866628d,bottom: 0.18223411132793665d,left: 0.43666028084197817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3466896586637449d,right: 0.6127938436324593d,bottom: 0.030213788130225128d,left: 0.17466111331041922d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41791252460213546d,right: 0.9752781784128051d,bottom: 0.25902478132624873d,left: 0.41726688087596653d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3180836679530712d,right: 0.7876198933758296d,bottom: 0.28016928987999157d,left: 0.3749584242278987d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8076666757647246d,right: 0.7196864972715422d,bottom: 0.6861401401094507d,left: 0.48901901877896037d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9449278693852031d,right: 0.8870152714776898d,bottom: 0.5861626393399486d,left: 0.42349045130254914d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4938636965756146d,right: 0.999939732711966d,bottom: 0.1797630671345909d,left: 0.9207307174323118d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9813003134807844d,right: 0.8545405862536518d,bottom: 0.3539591089972882d,left: 0.43116018905173104d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6991251336730332d,right: 0.5370480674223366d,bottom: 0.10906249752256292d,left: 0.4760217121667101d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6135101279013041d,right: 0.6016487933187894d,bottom: 0.3768988161758883d,left: 0.5337542016370046d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38274709630329684d,right: 0.30136613350587604d,bottom: 0.33022293417291915d,left: 0.06181870766670228d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6588432101288922d,right: 0.9529614474934951d,bottom: 0.0392976266531061d,left: 0.4361391505528912d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5817150680357566d,right: 0.8464491061814471d,bottom: 0.3379094106330772d,left: 0.1701868617863609d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8644193269872471d,right: 0.2550257787359972d,bottom: 0.7928931902325612d,left: 0.08629762456037215d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9332426855411691d,right: 0.798523712972169d,bottom: 0.4262803990045596d,left: 0.5280887550868602d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6968411855959129d,right: 0.32169425750057656d,bottom: 0.1322584038638539d,left: 0.29684011661913523d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46698760607936796d,right: 0.346624945712402d,bottom: 0.27311006187036047d,left: 0.04271175743871114d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5558379198969031d,right: 0.5182980243662818d,bottom: 0.5476783710655834d,left: 0.4959677610193851d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8354101397192818d,right: 0.5863245299271452d,bottom: 0.6410517744518384d,left: 0.5288782992613557d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6055263672924268d,right: 0.8732422812721001d,bottom: 0.03377332842919778d,left: 0.5559872927950065d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4341978703582443d,right: 0.8765409572205569d,bottom: 0.01725038248437305d,left: 0.634069629947336d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9307279107865115d,right: 0.6787451521614607d,bottom: 0.7752573806627584d,left: 0.4600353783257176d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6485862243222289d,right: 0.8721717216658048d,bottom: 0.6453900494037256d,left: 0.7821035034521746d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8841567171025797d,right: 0.9885399142876076d,bottom: 0.005764549816204667d,left: 0.16797742519530534d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6378279581285593d,right: 0.8245832366385528d,bottom: 0.1524938765167816d,left: 0.17629704738772067d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6301302394652435d,right: 0.9195226500565563d,bottom: 0.2823216412015297d,left: 0.15005699326771837d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5206755968790987d,right: 0.4208515513423906d,bottom: 0.17030199672018553d,left: 0.31653647056382406d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7276335201832203d,right: 0.5346188279781234d,bottom: 0.4418130024997744d,left: 0.5076056143684894d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5528617448223574d,right: 0.94788552272015d,bottom: 0.010218798927883799d,left: 0.86380585105286d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9461427822918499d,right: 0.7021645845111166d,bottom: 0.47539058213407404d,left: 0.6769020562574415d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8975248135962672d,right: 0.7902025515471495d,bottom: 0.26714019825047364d,left: 0.445894975599591d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.781047274180001d,right: 0.8820276968104984d,bottom: 0.4731906204980758d,left: 0.6208612281320337d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5226496117059803d,right: 0.6666781514687649d,bottom: 0.3170980534055081d,left: 0.20839430347375654d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8315876166897742d,right: 0.40080262011405876d,bottom: 0.16024377147004676d,left: 0.3408394856721264d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6598005461839561d,right: 0.6714272472835389d,bottom: 0.2494271897889132d,left: 0.2194330998393551d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5860215180200232d,right: 0.6895672676335055d,bottom: 0.5724058892748576d,left: 0.08808123276418522d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9914111170762476d,right: 0.8142035443071d,bottom: 0.41587582077480123d,left: 0.6119765780981895d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.596676358197913d,right: 0.6671828576600797d,bottom: 0.0625582518099902d,left: 0.4795203904572104d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6706760913328976d,right: 0.7724537422329921d,bottom: 0.3942358722341912d,left: 0.011304680531329825d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8473373308395642d,right: 0.9721410550628711d,bottom: 0.01779688202786145d,left: 0.32698683806480655d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4055875082832091d,right: 0.933083110828992d,bottom: 0.2089126895989798d,left: 0.6541927196403171d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8363550613907889d,right: 0.686092507928968d,bottom: 0.8132702920974687d,left: 0.32920633520596d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1150700908448461d,right: 0.23605278324641965d,bottom: 0.08162490715084325d,left: 0.04968313994593032d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9554616728729188d,right: 0.7039603503361765d,bottom: 0.44857637848928056d,left: 0.31817090812912396d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4285703354167667d,right: 0.754141257678335d,bottom: 0.38583320346067496d,left: 0.30091418193250996d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17960231513293134d,right: 0.8732236692480345d,bottom: 0.1196903368660972d,left: 0.06269062142863546d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9864726387536892d,right: 0.7065100310834099d,bottom: 0.3804857318730618d,left: 0.531681361962382d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6852092274014966d,right: 0.4717519350069268d,bottom: 0.18756698826165707d,left: 0.01942652021032698d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9765466251764958d,right: 0.6844486646659816d,bottom: 0.07510855896130597d,left: 0.5512576043835236d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.628083307827179d,right: 0.9934660456037265d,bottom: 0.6193005802912183d,left: 0.29482717817704385d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8609153644014977d,right: 0.9112954481587153d,bottom: 0.05885298700310215d,left: 0.02148343783310236d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46891848722662455d,right: 0.7968640555246786d,bottom: 0.0990802250749746d,left: 0.27459877969251434d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8783258020706664d,right: 0.6925824847994598d,bottom: 0.28529925435632586d,left: 0.42994538436412555d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6083331613236422d,right: 0.5986760640524776d,bottom: 0.4510707442508871d,left: 0.046663028929771144d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.32257552394234856d,right: 0.2239358430089179d,bottom: 0.24384328029523572d,left: 0.08462463361343775d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6932253030553129d,right: 0.6328318020719572d,bottom: 0.05073280033030636d,left: 0.21956650060803296d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.903423467135396d,right: 0.698502336802358d,bottom: 0.5758398867607857d,left: 0.08274620210467609d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9831271444500702d,right: 0.1363579157575301d,bottom: 0.32700259716436786d,left: 0.09322500638444309d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.728679875201515d,right: 0.7067727503935566d,bottom: 0.3899735554004131d,left: 0.23900183669215824d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5355854603308887d,right: 0.36669588916588935d,bottom: 0.15675372484306627d,left: 0.12934354600623688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47043221362726373d,right: 0.7236148565052295d,bottom: 0.11964855221390647d,left: 0.6729237313220301d))));

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
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
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
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
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxbox0M),
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                var importCollection = new List<NpgsqlBoxbox0M>();
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
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0M>();
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
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
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
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

