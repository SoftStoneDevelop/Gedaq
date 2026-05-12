

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
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9306848671031213d,right: 0.9181293769161392d,bottom: 0.031455260162292054d,left: 0.6818237824333496d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8030994214645314d,right: 0.7620287021001686d,bottom: 0.07626598327347278d,left: 0.3888558529622589d),
},
            new NpgsqlBoxboxE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.21354742052517905d,right: 0.8009981364064128d,bottom: 0.20207648613118678d,left: 0.2755644064019742d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7423919370540055d,right: 0.7144311830712876d,bottom: 0.6139605994781934d,left: 0.4609301799490444d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8297606109165411d,right: 0.9098085706646545d,bottom: 0.6574181977863026d,left: 0.06505136466370853d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7878614584320116d,right: 0.6988758438813315d,bottom: 0.11287783781653293d,left: 0.33255316250334044d),
},
            new NpgsqlBoxboxE0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8687005089234557d,right: 0.9566656378194274d,bottom: 0.44898988218359903d,left: 0.37227897719259273d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8271307739985523d,right: 0.8841902553546716d,bottom: 0.306936761187669d,left: 0.29069804259914767d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49856298310488434d,right: 0.6909202718752103d,bottom: 0.4112183929085331d,left: 0.21991650742391933d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9394673700125727d,right: 0.7590125373311944d,bottom: 0.5996064892367154d,left: 0.7114466895492046d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7212252413299385d,right: 0.4285047276840548d,bottom: 0.4769137216997198d,left: 0.0552018110433804d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6864919021088338d,right: 0.5827281393808391d,bottom: 0.5879896886488871d,left: 0.39459431040638304d),
},
            new NpgsqlBoxboxE0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.794774758680941d,right: 0.5787021015948401d,bottom: 0.7741508484802243d,left: 0.3197410123681267d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9696127820452448d,right: 0.9948314877934178d,bottom: 0.3814572665920233d,left: 0.6810677437223334d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9018769084955713d,right: 0.8426817138527086d,bottom: 0.7723375003868648d,left: 0.3420464548660115d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9247646838404786d,right: 0.6011264705070842d,bottom: 0.923121803074658d,left: 0.44871843709005144d),
},
            new NpgsqlBoxboxE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8734890575750933d,right: 0.513125639943483d,bottom: 0.7865632746007659d,left: 0.47635734315891054d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9050203957752231d,right: 0.28249572600659323d,bottom: 0.6848122800916291d,left: 0.23034590801346344d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3355286673752791d,right: 0.945496926461102d,bottom: 0.2995430328565283d,left: 0.07358150307963995d),
},
            new NpgsqlBoxboxE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.48040646568539447d,right: 0.4406813529029544d,bottom: 0.15029511520627015d,left: 0.10879290882877612d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7315273530062297d,right: 0.9246496797046344d,bottom: 0.4495235263181413d,left: 0.12838327201875444d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5277020617263993d,right: 0.6476711556647111d,bottom: 0.47849628967755065d,left: 0.351538469855204d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7342588418468846d,right: 0.27044192434642444d,bottom: 0.6807531034249115d,left: 0.2296488380454692d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.41403595847769237d,right: 0.9655440382958129d,bottom: 0.03702273666017819d,left: 0.08905182923491795d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7726203287747321d,right: 0.5353307717797949d,bottom: 0.4134622432413668d,left: 0.08525090823800607d),
},
            new NpgsqlBoxboxE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9438271378185284d,right: 0.6106259689429216d,bottom: 0.38586467855513507d,left: 0.19107540436009463d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5338691134096438d,right: 0.7198194363864405d,bottom: 0.26763352915181116d,left: 0.01296936145407901d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7861982222216236d,right: 0.3825155382935298d,bottom: 0.6944781614305843d,left: 0.005721924937259648d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5498823122664696d,right: 0.7952230174977447d,bottom: 0.23539932230198957d,left: 0.5498816960912691d),
},
            new NpgsqlBoxboxE0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8590179555930683d,right: 0.9569133882073477d,bottom: 0.7855607883845935d,left: 0.6353087929150528d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6452913339884188d,right: 0.6501064651069776d,bottom: 0.36365730692484066d,left: 0.31932850705544624d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.908610378063228d,right: 0.996836369247746d,bottom: 0.5408752741786136d,left: 0.2500974839551605d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.478998648046274d,right: 0.4414506368068385d,bottom: 0.4142399560053682d,left: 0.4084248920514175d),
},
            new NpgsqlBoxboxE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.35202275344794276d,right: 0.6035753744432223d,bottom: 0.1252850836112137d,left: 0.06962555422369798d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6051145467870812d,right: 0.6408426534434559d,bottom: 0.25741248193766153d,left: 0.31965613845473395d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4651730451112892d,right: 0.35216766244343956d,bottom: 0.1332042658009348d,left: 0.07084344995925829d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.08949902715906954d,right: 0.30824415027993335d,bottom: 0.0032588512100162337d,left: 0.2723862536123617d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8397872064191085d,right: 0.4130377589523577d,bottom: 0.016009742785835d,left: 0.1266062462101245d),
},
            new NpgsqlBoxboxE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4437897975177416d,right: 0.5615638697711257d,bottom: 0.2537162753738581d,left: 0.03607840605051549d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5178910854052814d,right: 0.6379685832478185d,bottom: 0.025789918623008057d,left: 0.3156452142098115d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5824178107350527d,right: 0.9438733252019879d,bottom: 0.46650151074390434d,left: 0.48285744898155936d),
},
            new NpgsqlBoxboxE0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4181872578244459d,right: 0.8939536672184851d,bottom: 0.08154839568632277d,left: 0.3964386825078614d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5268721159379869d,right: 0.7679186809045251d,bottom: 0.28852318158940105d,left: 0.40928416595970774d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8696916999790065d,right: 0.11799860366252568d,bottom: 0.038059569445952235d,left: 0.08627074789256284d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.06852954779676546d,right: 0.7494669162631983d,bottom: 0.011520064238644045d,left: 0.5777913385287606d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.63802969097982d,right: 0.7143353967700513d,bottom: 0.30991367432242634d,left: 0.39075573908411876d),
},
            new NpgsqlBoxboxE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6859545494707071d,right: 0.5906697931000849d,bottom: 0.2354701315517328d,left: 0.38031986144215113d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.835557376930316d,right: 0.24703755531721527d,bottom: 0.6734633089940385d,left: 0.03689144332990313d),
},
            new NpgsqlBoxboxE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4948319416428798d,right: 0.7679138576050716d,bottom: 0.049458460927895076d,left: 0.7000587547410753d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8048531824083973d,right: 0.4405390253698286d,bottom: 0.7968859033254463d,left: 0.06783703089586568d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9920682177607026d,right: 0.3297271078033328d,bottom: 0.20055901110769336d,left: 0.20733965851685654d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8836447474567437d,right: 0.696057145700637d,bottom: 0.0309419193397531d,left: 0.17558379560838144d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8198002294330219d,right: 0.9673797514952619d,bottom: 0.08322232672084318d,left: 0.3176059332027069d),
},
            new NpgsqlBoxboxE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9786915878349745d,right: 0.8394854622853675d,bottom: 0.6146834923772551d,left: 0.49558901176742254d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9693621765939983d,right: 0.8287921300639631d,bottom: 0.18579769488608244d,left: 0.5896884127762007d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9446246724131108d,right: 0.8510752729891102d,bottom: 0.4998337848337506d,left: 0.7731073990488144d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3993852964305644d,right: 0.9799689509792057d,bottom: 0.21775068827608168d,left: 0.8059707656769054d),
},
            new NpgsqlBoxboxE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9865489033110866d,right: 0.8710343097986087d,bottom: 0.38487467238606277d,left: 0.7751724820067926d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46842149518619525d,right: 0.7863012957131673d,bottom: 0.17642316385953782d,left: 0.4528564153788618d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5713356840888639d,right: 0.9518486177765096d,bottom: 0.35028156680166933d,left: 0.9026743383443415d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6382091272879199d,right: 0.7625111490181768d,bottom: 0.33087751265679677d,left: 0.4209162527715685d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7697896393123597d,right: 0.9433762451044044d,bottom: 0.099761439032377d,left: 0.19412134465697495d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.47850251640859576d,right: 0.839262461197198d,bottom: 0.17794005814582103d,left: 0.5656971404666474d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5812404180577971d,right: 0.8709441470522412d,bottom: 0.42497573330090876d,left: 0.6973840241282016d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7228061306416497d,right: 0.30028365132996937d,bottom: 0.6961686097599691d,left: 0.28205190993515283d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7299620359224439d,right: 0.761403511998111d,bottom: 0.4584587749919691d,left: 0.3224507345377672d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6623458127353036d,right: 0.582760110647639d,bottom: 0.5383465261247361d,left: 0.12761931755729805d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9814133643111776d,right: 0.3019476361256055d,bottom: 0.9175087128529333d,left: 0.14501688307998495d),
},
            new NpgsqlBoxboxE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8248164091132495d,right: 0.9395522196590808d,bottom: 0.2334555633709986d,left: 0.47355561984205763d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4524632288931062d,right: 0.41200453210533605d,bottom: 0.2938904855025566d,left: 0.14721537854119437d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7132310396467907d,right: 0.767716054860889d,bottom: 0.044167110316287395d,left: 0.10173802161098744d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6760355216252145d,right: 0.9543760306823436d,bottom: 0.22255614027577664d,left: 0.5568487481464881d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8680925337753899d,right: 0.6251021699228596d,bottom: 0.4410150517701189d,left: 0.08826500428894535d),
},
            new NpgsqlBoxboxE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9117120612487464d,right: 0.9831775314890482d,bottom: 0.7507443686180663d,left: 0.05521457967760224d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7427094405143173d,right: 0.45023476860303757d,bottom: 0.7065300317421007d,left: 0.14327584938128635d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7106695265003632d,right: 0.6689982866580999d,bottom: 0.44696124844788276d,left: 0.31666497948789807d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9828661859361661d,right: 0.63961957405738d,bottom: 0.8746803573306939d,left: 0.20401932079380125d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.42614131566408786d,right: 0.7158575912860514d,bottom: 0.001698634824181866d,left: 0.2235322689784951d),
},
            new NpgsqlBoxboxE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9971575800290049d,right: 0.6132901007477767d,bottom: 0.5983555577947308d,left: 0.234704417158062d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8452750217234796d,right: 0.3774005344459791d,bottom: 0.02072727779655359d,left: 0.2815509619628407d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6864919021088338d,right: 0.5827281393808391d,bottom: 0.5879896886488871d,left: 0.39459431040638304d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9247646838404786d,right: 0.6011264705070842d,bottom: 0.923121803074658d,left: 0.44871843709005144d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3355286673752791d,right: 0.945496926461102d,bottom: 0.2995430328565283d,left: 0.07358150307963995d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7726203287747321d,right: 0.5353307717797949d,bottom: 0.4134622432413668d,left: 0.08525090823800607d)));
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
                parametr1.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 135, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 19, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 89, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 89, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 107, 19))
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[20], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9306848671031213d,right: 0.9181293769161392d,bottom: 0.031455260162292054d,left: 0.6818237824333496d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8030994214645314d,right: 0.7620287021001686d,bottom: 0.07626598327347278d,left: 0.3888558529622589d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21354742052517905d,right: 0.8009981364064128d,bottom: 0.20207648613118678d,left: 0.2755644064019742d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7423919370540055d,right: 0.7144311830712876d,bottom: 0.6139605994781934d,left: 0.4609301799490444d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8297606109165411d,right: 0.9098085706646545d,bottom: 0.6574181977863026d,left: 0.06505136466370853d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7878614584320116d,right: 0.6988758438813315d,bottom: 0.11287783781653293d,left: 0.33255316250334044d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8687005089234557d,right: 0.9566656378194274d,bottom: 0.44898988218359903d,left: 0.37227897719259273d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8271307739985523d,right: 0.8841902553546716d,bottom: 0.306936761187669d,left: 0.29069804259914767d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49856298310488434d,right: 0.6909202718752103d,bottom: 0.4112183929085331d,left: 0.21991650742391933d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9394673700125727d,right: 0.7590125373311944d,bottom: 0.5996064892367154d,left: 0.7114466895492046d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7212252413299385d,right: 0.4285047276840548d,bottom: 0.4769137216997198d,left: 0.0552018110433804d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6864919021088338d,right: 0.5827281393808391d,bottom: 0.5879896886488871d,left: 0.39459431040638304d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.794774758680941d,right: 0.5787021015948401d,bottom: 0.7741508484802243d,left: 0.3197410123681267d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9696127820452448d,right: 0.9948314877934178d,bottom: 0.3814572665920233d,left: 0.6810677437223334d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9018769084955713d,right: 0.8426817138527086d,bottom: 0.7723375003868648d,left: 0.3420464548660115d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9247646838404786d,right: 0.6011264705070842d,bottom: 0.923121803074658d,left: 0.44871843709005144d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8734890575750933d,right: 0.513125639943483d,bottom: 0.7865632746007659d,left: 0.47635734315891054d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9050203957752231d,right: 0.28249572600659323d,bottom: 0.6848122800916291d,left: 0.23034590801346344d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3355286673752791d,right: 0.945496926461102d,bottom: 0.2995430328565283d,left: 0.07358150307963995d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48040646568539447d,right: 0.4406813529029544d,bottom: 0.15029511520627015d,left: 0.10879290882877612d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7315273530062297d,right: 0.9246496797046344d,bottom: 0.4495235263181413d,left: 0.12838327201875444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5277020617263993d,right: 0.6476711556647111d,bottom: 0.47849628967755065d,left: 0.351538469855204d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7342588418468846d,right: 0.27044192434642444d,bottom: 0.6807531034249115d,left: 0.2296488380454692d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41403595847769237d,right: 0.9655440382958129d,bottom: 0.03702273666017819d,left: 0.08905182923491795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7726203287747321d,right: 0.5353307717797949d,bottom: 0.4134622432413668d,left: 0.08525090823800607d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9438271378185284d,right: 0.6106259689429216d,bottom: 0.38586467855513507d,left: 0.19107540436009463d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5338691134096438d,right: 0.7198194363864405d,bottom: 0.26763352915181116d,left: 0.01296936145407901d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7861982222216236d,right: 0.3825155382935298d,bottom: 0.6944781614305843d,left: 0.005721924937259648d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5498823122664696d,right: 0.7952230174977447d,bottom: 0.23539932230198957d,left: 0.5498816960912691d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8590179555930683d,right: 0.9569133882073477d,bottom: 0.7855607883845935d,left: 0.6353087929150528d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6452913339884188d,right: 0.6501064651069776d,bottom: 0.36365730692484066d,left: 0.31932850705544624d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.908610378063228d,right: 0.996836369247746d,bottom: 0.5408752741786136d,left: 0.2500974839551605d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.478998648046274d,right: 0.4414506368068385d,bottom: 0.4142399560053682d,left: 0.4084248920514175d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35202275344794276d,right: 0.6035753744432223d,bottom: 0.1252850836112137d,left: 0.06962555422369798d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6051145467870812d,right: 0.6408426534434559d,bottom: 0.25741248193766153d,left: 0.31965613845473395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4651730451112892d,right: 0.35216766244343956d,bottom: 0.1332042658009348d,left: 0.07084344995925829d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08949902715906954d,right: 0.30824415027993335d,bottom: 0.0032588512100162337d,left: 0.2723862536123617d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8397872064191085d,right: 0.4130377589523577d,bottom: 0.016009742785835d,left: 0.1266062462101245d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4437897975177416d,right: 0.5615638697711257d,bottom: 0.2537162753738581d,left: 0.03607840605051549d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5178910854052814d,right: 0.6379685832478185d,bottom: 0.025789918623008057d,left: 0.3156452142098115d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5824178107350527d,right: 0.9438733252019879d,bottom: 0.46650151074390434d,left: 0.48285744898155936d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4181872578244459d,right: 0.8939536672184851d,bottom: 0.08154839568632277d,left: 0.3964386825078614d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5268721159379869d,right: 0.7679186809045251d,bottom: 0.28852318158940105d,left: 0.40928416595970774d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8696916999790065d,right: 0.11799860366252568d,bottom: 0.038059569445952235d,left: 0.08627074789256284d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.06852954779676546d,right: 0.7494669162631983d,bottom: 0.011520064238644045d,left: 0.5777913385287606d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.63802969097982d,right: 0.7143353967700513d,bottom: 0.30991367432242634d,left: 0.39075573908411876d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6859545494707071d,right: 0.5906697931000849d,bottom: 0.2354701315517328d,left: 0.38031986144215113d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.835557376930316d,right: 0.24703755531721527d,bottom: 0.6734633089940385d,left: 0.03689144332990313d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4948319416428798d,right: 0.7679138576050716d,bottom: 0.049458460927895076d,left: 0.7000587547410753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8048531824083973d,right: 0.4405390253698286d,bottom: 0.7968859033254463d,left: 0.06783703089586568d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9920682177607026d,right: 0.3297271078033328d,bottom: 0.20055901110769336d,left: 0.20733965851685654d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8836447474567437d,right: 0.696057145700637d,bottom: 0.0309419193397531d,left: 0.17558379560838144d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8198002294330219d,right: 0.9673797514952619d,bottom: 0.08322232672084318d,left: 0.3176059332027069d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9786915878349745d,right: 0.8394854622853675d,bottom: 0.6146834923772551d,left: 0.49558901176742254d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9693621765939983d,right: 0.8287921300639631d,bottom: 0.18579769488608244d,left: 0.5896884127762007d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9446246724131108d,right: 0.8510752729891102d,bottom: 0.4998337848337506d,left: 0.7731073990488144d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3993852964305644d,right: 0.9799689509792057d,bottom: 0.21775068827608168d,left: 0.8059707656769054d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9865489033110866d,right: 0.8710343097986087d,bottom: 0.38487467238606277d,left: 0.7751724820067926d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46842149518619525d,right: 0.7863012957131673d,bottom: 0.17642316385953782d,left: 0.4528564153788618d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5713356840888639d,right: 0.9518486177765096d,bottom: 0.35028156680166933d,left: 0.9026743383443415d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6382091272879199d,right: 0.7625111490181768d,bottom: 0.33087751265679677d,left: 0.4209162527715685d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7697896393123597d,right: 0.9433762451044044d,bottom: 0.099761439032377d,left: 0.19412134465697495d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47850251640859576d,right: 0.839262461197198d,bottom: 0.17794005814582103d,left: 0.5656971404666474d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5812404180577971d,right: 0.8709441470522412d,bottom: 0.42497573330090876d,left: 0.6973840241282016d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7228061306416497d,right: 0.30028365132996937d,bottom: 0.6961686097599691d,left: 0.28205190993515283d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7299620359224439d,right: 0.761403511998111d,bottom: 0.4584587749919691d,left: 0.3224507345377672d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6623458127353036d,right: 0.582760110647639d,bottom: 0.5383465261247361d,left: 0.12761931755729805d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9814133643111776d,right: 0.3019476361256055d,bottom: 0.9175087128529333d,left: 0.14501688307998495d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8248164091132495d,right: 0.9395522196590808d,bottom: 0.2334555633709986d,left: 0.47355561984205763d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4524632288931062d,right: 0.41200453210533605d,bottom: 0.2938904855025566d,left: 0.14721537854119437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7132310396467907d,right: 0.767716054860889d,bottom: 0.044167110316287395d,left: 0.10173802161098744d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6760355216252145d,right: 0.9543760306823436d,bottom: 0.22255614027577664d,left: 0.5568487481464881d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8680925337753899d,right: 0.6251021699228596d,bottom: 0.4410150517701189d,left: 0.08826500428894535d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9117120612487464d,right: 0.9831775314890482d,bottom: 0.7507443686180663d,left: 0.05521457967760224d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7427094405143173d,right: 0.45023476860303757d,bottom: 0.7065300317421007d,left: 0.14327584938128635d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7106695265003632d,right: 0.6689982866580999d,bottom: 0.44696124844788276d,left: 0.31666497948789807d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9828661859361661d,right: 0.63961957405738d,bottom: 0.8746803573306939d,left: 0.20401932079380125d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42614131566408786d,right: 0.7158575912860514d,bottom: 0.001698634824181866d,left: 0.2235322689784951d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9971575800290049d,right: 0.6132901007477767d,bottom: 0.5983555577947308d,left: 0.234704417158062d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8452750217234796d,right: 0.3774005344459791d,bottom: 0.02072727779655359d,left: 0.2815509619628407d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9306848671031213d,right: 0.9181293769161392d,bottom: 0.031455260162292054d,left: 0.6818237824333496d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8030994214645314d,right: 0.7620287021001686d,bottom: 0.07626598327347278d,left: 0.3888558529622589d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.21354742052517905d,right: 0.8009981364064128d,bottom: 0.20207648613118678d,left: 0.2755644064019742d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7423919370540055d,right: 0.7144311830712876d,bottom: 0.6139605994781934d,left: 0.4609301799490444d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8297606109165411d,right: 0.9098085706646545d,bottom: 0.6574181977863026d,left: 0.06505136466370853d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7878614584320116d,right: 0.6988758438813315d,bottom: 0.11287783781653293d,left: 0.33255316250334044d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8687005089234557d,right: 0.9566656378194274d,bottom: 0.44898988218359903d,left: 0.37227897719259273d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8271307739985523d,right: 0.8841902553546716d,bottom: 0.306936761187669d,left: 0.29069804259914767d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49856298310488434d,right: 0.6909202718752103d,bottom: 0.4112183929085331d,left: 0.21991650742391933d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9394673700125727d,right: 0.7590125373311944d,bottom: 0.5996064892367154d,left: 0.7114466895492046d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7212252413299385d,right: 0.4285047276840548d,bottom: 0.4769137216997198d,left: 0.0552018110433804d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6864919021088338d,right: 0.5827281393808391d,bottom: 0.5879896886488871d,left: 0.39459431040638304d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.794774758680941d,right: 0.5787021015948401d,bottom: 0.7741508484802243d,left: 0.3197410123681267d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9696127820452448d,right: 0.9948314877934178d,bottom: 0.3814572665920233d,left: 0.6810677437223334d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9018769084955713d,right: 0.8426817138527086d,bottom: 0.7723375003868648d,left: 0.3420464548660115d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9247646838404786d,right: 0.6011264705070842d,bottom: 0.923121803074658d,left: 0.44871843709005144d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8734890575750933d,right: 0.513125639943483d,bottom: 0.7865632746007659d,left: 0.47635734315891054d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9050203957752231d,right: 0.28249572600659323d,bottom: 0.6848122800916291d,left: 0.23034590801346344d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3355286673752791d,right: 0.945496926461102d,bottom: 0.2995430328565283d,left: 0.07358150307963995d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48040646568539447d,right: 0.4406813529029544d,bottom: 0.15029511520627015d,left: 0.10879290882877612d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7315273530062297d,right: 0.9246496797046344d,bottom: 0.4495235263181413d,left: 0.12838327201875444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5277020617263993d,right: 0.6476711556647111d,bottom: 0.47849628967755065d,left: 0.351538469855204d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7342588418468846d,right: 0.27044192434642444d,bottom: 0.6807531034249115d,left: 0.2296488380454692d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41403595847769237d,right: 0.9655440382958129d,bottom: 0.03702273666017819d,left: 0.08905182923491795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7726203287747321d,right: 0.5353307717797949d,bottom: 0.4134622432413668d,left: 0.08525090823800607d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9438271378185284d,right: 0.6106259689429216d,bottom: 0.38586467855513507d,left: 0.19107540436009463d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5338691134096438d,right: 0.7198194363864405d,bottom: 0.26763352915181116d,left: 0.01296936145407901d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7861982222216236d,right: 0.3825155382935298d,bottom: 0.6944781614305843d,left: 0.005721924937259648d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5498823122664696d,right: 0.7952230174977447d,bottom: 0.23539932230198957d,left: 0.5498816960912691d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8590179555930683d,right: 0.9569133882073477d,bottom: 0.7855607883845935d,left: 0.6353087929150528d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6452913339884188d,right: 0.6501064651069776d,bottom: 0.36365730692484066d,left: 0.31932850705544624d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.908610378063228d,right: 0.996836369247746d,bottom: 0.5408752741786136d,left: 0.2500974839551605d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.478998648046274d,right: 0.4414506368068385d,bottom: 0.4142399560053682d,left: 0.4084248920514175d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35202275344794276d,right: 0.6035753744432223d,bottom: 0.1252850836112137d,left: 0.06962555422369798d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6051145467870812d,right: 0.6408426534434559d,bottom: 0.25741248193766153d,left: 0.31965613845473395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4651730451112892d,right: 0.35216766244343956d,bottom: 0.1332042658009348d,left: 0.07084344995925829d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08949902715906954d,right: 0.30824415027993335d,bottom: 0.0032588512100162337d,left: 0.2723862536123617d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8397872064191085d,right: 0.4130377589523577d,bottom: 0.016009742785835d,left: 0.1266062462101245d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4437897975177416d,right: 0.5615638697711257d,bottom: 0.2537162753738581d,left: 0.03607840605051549d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5178910854052814d,right: 0.6379685832478185d,bottom: 0.025789918623008057d,left: 0.3156452142098115d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5824178107350527d,right: 0.9438733252019879d,bottom: 0.46650151074390434d,left: 0.48285744898155936d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4181872578244459d,right: 0.8939536672184851d,bottom: 0.08154839568632277d,left: 0.3964386825078614d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5268721159379869d,right: 0.7679186809045251d,bottom: 0.28852318158940105d,left: 0.40928416595970774d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8696916999790065d,right: 0.11799860366252568d,bottom: 0.038059569445952235d,left: 0.08627074789256284d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.06852954779676546d,right: 0.7494669162631983d,bottom: 0.011520064238644045d,left: 0.5777913385287606d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.63802969097982d,right: 0.7143353967700513d,bottom: 0.30991367432242634d,left: 0.39075573908411876d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6859545494707071d,right: 0.5906697931000849d,bottom: 0.2354701315517328d,left: 0.38031986144215113d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.835557376930316d,right: 0.24703755531721527d,bottom: 0.6734633089940385d,left: 0.03689144332990313d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4948319416428798d,right: 0.7679138576050716d,bottom: 0.049458460927895076d,left: 0.7000587547410753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8048531824083973d,right: 0.4405390253698286d,bottom: 0.7968859033254463d,left: 0.06783703089586568d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9920682177607026d,right: 0.3297271078033328d,bottom: 0.20055901110769336d,left: 0.20733965851685654d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8836447474567437d,right: 0.696057145700637d,bottom: 0.0309419193397531d,left: 0.17558379560838144d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8198002294330219d,right: 0.9673797514952619d,bottom: 0.08322232672084318d,left: 0.3176059332027069d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9786915878349745d,right: 0.8394854622853675d,bottom: 0.6146834923772551d,left: 0.49558901176742254d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9693621765939983d,right: 0.8287921300639631d,bottom: 0.18579769488608244d,left: 0.5896884127762007d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9446246724131108d,right: 0.8510752729891102d,bottom: 0.4998337848337506d,left: 0.7731073990488144d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3993852964305644d,right: 0.9799689509792057d,bottom: 0.21775068827608168d,left: 0.8059707656769054d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9865489033110866d,right: 0.8710343097986087d,bottom: 0.38487467238606277d,left: 0.7751724820067926d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46842149518619525d,right: 0.7863012957131673d,bottom: 0.17642316385953782d,left: 0.4528564153788618d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5713356840888639d,right: 0.9518486177765096d,bottom: 0.35028156680166933d,left: 0.9026743383443415d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6382091272879199d,right: 0.7625111490181768d,bottom: 0.33087751265679677d,left: 0.4209162527715685d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7697896393123597d,right: 0.9433762451044044d,bottom: 0.099761439032377d,left: 0.19412134465697495d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.47850251640859576d,right: 0.839262461197198d,bottom: 0.17794005814582103d,left: 0.5656971404666474d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5812404180577971d,right: 0.8709441470522412d,bottom: 0.42497573330090876d,left: 0.6973840241282016d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7228061306416497d,right: 0.30028365132996937d,bottom: 0.6961686097599691d,left: 0.28205190993515283d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7299620359224439d,right: 0.761403511998111d,bottom: 0.4584587749919691d,left: 0.3224507345377672d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6623458127353036d,right: 0.582760110647639d,bottom: 0.5383465261247361d,left: 0.12761931755729805d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9814133643111776d,right: 0.3019476361256055d,bottom: 0.9175087128529333d,left: 0.14501688307998495d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8248164091132495d,right: 0.9395522196590808d,bottom: 0.2334555633709986d,left: 0.47355561984205763d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4524632288931062d,right: 0.41200453210533605d,bottom: 0.2938904855025566d,left: 0.14721537854119437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7132310396467907d,right: 0.767716054860889d,bottom: 0.044167110316287395d,left: 0.10173802161098744d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6760355216252145d,right: 0.9543760306823436d,bottom: 0.22255614027577664d,left: 0.5568487481464881d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8680925337753899d,right: 0.6251021699228596d,bottom: 0.4410150517701189d,left: 0.08826500428894535d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9117120612487464d,right: 0.9831775314890482d,bottom: 0.7507443686180663d,left: 0.05521457967760224d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7427094405143173d,right: 0.45023476860303757d,bottom: 0.7065300317421007d,left: 0.14327584938128635d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7106695265003632d,right: 0.6689982866580999d,bottom: 0.44696124844788276d,left: 0.31666497948789807d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9828661859361661d,right: 0.63961957405738d,bottom: 0.8746803573306939d,left: 0.20401932079380125d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42614131566408786d,right: 0.7158575912860514d,bottom: 0.001698634824181866d,left: 0.2235322689784951d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9971575800290049d,right: 0.6132901007477767d,bottom: 0.5983555577947308d,left: 0.234704417158062d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8452750217234796d,right: 0.3774005344459791d,bottom: 0.02072727779655359d,left: 0.2815509619628407d))));

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

