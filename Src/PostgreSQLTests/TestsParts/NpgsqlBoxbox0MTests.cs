

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9294779224561582d,right: 0.4428980773959481d,bottom: 0.6470191003480593d,left: 0.4398901670801154d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9615466603669358d,right: 0.5659972623972618d,bottom: 0.32207890480053813d,left: 0.2834431031062524d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5682566796666342d,right: 0.269644718731501d,bottom: 0.5447389859902857d,left: 0.10687854585043477d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7920233979784481d,right: 0.4340026260326091d,bottom: 0.15096859021207676d,left: 0.22171716427692056d),
},
            new NpgsqlBoxbox0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7914906026449822d,right: 0.7629521482984213d,bottom: 0.28031169295861047d,left: 0.43617217526056096d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9983283427533207d,right: 0.8604191088923364d,bottom: 0.9284368922462396d,left: 0.21632131542120403d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5670372762833442d,right: 0.8467495792510601d,bottom: 0.3698944873786607d,left: 0.820052698932674d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8804477923920239d,right: 0.447714862138087d,bottom: 0.6612134807439439d,left: 0.21091695241979702d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8676967312126723d,right: 0.7447183842234715d,bottom: 0.6866571346217147d,left: 0.018674932638535813d),
},
            new NpgsqlBoxbox0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6479562830599352d,right: 0.852677435433365d,bottom: 0.23493050421035833d,left: 0.4584806922206688d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7356113084203585d,right: 0.6975496641499697d,bottom: 0.4398797919027423d,left: 0.31885766299483376d),
},
            new NpgsqlBoxbox0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3911137520207454d,right: 0.7982591111674721d,bottom: 0.05093607534144118d,left: 0.3254212780018967d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.818152280849944d,right: 0.6416761455232644d,bottom: 0.6851339844409334d,left: 0.007308670279926877d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3308439041694261d,right: 0.7556186871332493d,bottom: 0.20383559415531016d,left: 0.6971671205415322d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8800581587683394d,right: 0.5088234121192513d,bottom: 0.34805568308100443d,left: 0.12417013427189671d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8677057855192898d,right: 0.25138283167640596d,bottom: 0.16641739096849462d,left: 0.07316137226034758d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6462578812135593d,right: 0.7888280475222297d,bottom: 0.30070893208865523d,left: 0.4274405132807667d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4217063369133337d,right: 0.6969876837773564d,bottom: 0.3699019672261852d,left: 0.39564840891706354d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9290519336416321d,right: 0.6859200612370725d,bottom: 0.8659733631798094d,left: 0.28728715800487403d),
},
            new NpgsqlBoxbox0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7605094732929121d,right: 0.8677167198987246d,bottom: 0.5378118051286183d,left: 0.28216965534835237d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5341472554499022d,right: 0.2826607695558919d,bottom: 0.1767333711153094d,left: 0.035465648388415816d),
},
            new NpgsqlBoxbox0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.87834973195896d,right: 0.5503609194407028d,bottom: 0.694754503505792d,left: 0.5451664713685398d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8980996518067595d,right: 0.8210366709684985d,bottom: 0.8263655539849201d,left: 0.040379551649406986d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9166148974332025d,right: 0.6530856006876411d,bottom: 0.7889326370273927d,left: 0.27463562623885707d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8569907316563555d,right: 0.658366862343998d,bottom: 0.04208573125539039d,left: 0.07247125133249377d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3577850430925523d,right: 0.7159889624875401d,bottom: 0.29570589636815137d,left: 0.32393215801853326d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6538058184854141d,right: 0.7230391889307991d,bottom: 0.07450518515294924d,left: 0.6729311041464412d),
},
            new NpgsqlBoxbox0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1498884036325442d,right: 0.913484845586311d,bottom: 0.05203546797460212d,left: 0.0747132982056734d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7158735268832398d,right: 0.902013625983589d,bottom: 0.23083887024170535d,left: 0.40202987668311807d),
},
            new NpgsqlBoxbox0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.19578948558644227d,right: 0.4467597239547596d,bottom: 0.1692228160799315d,left: 0.21310548815847918d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6123224072573326d,right: 0.5096994124939902d,bottom: 0.11395011877024841d,left: 0.016154489395843963d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8268881774855525d,right: 0.7983261100377209d,bottom: 0.32306428925581065d,left: 0.6567874258712729d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5593026822736256d,right: 0.7690693085771156d,bottom: 0.5258149328134935d,left: 0.4133763527121923d),
},
            new NpgsqlBoxbox0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9456728602446719d,right: 0.18044439349152486d,bottom: 0.6842060102935172d,left: 0.014806397518272174d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5908433253582904d,right: 0.6716338744750148d,bottom: 0.0808551721913705d,left: 0.48184971335136173d),
},
            new NpgsqlBoxbox0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9043533540883921d,right: 0.8747603443033772d,bottom: 0.014019662359615603d,left: 0.6397943618496493d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7352704884041842d,right: 0.636103882688438d,bottom: 0.15917631974260305d,left: 0.4296820256885415d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8286063739732615d,right: 0.9063259434973939d,bottom: 0.5998287085147017d,left: 0.43823223536522016d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.544029805414346d,right: 0.8426911325258009d,bottom: 0.5407238504568638d,left: 0.5559411333922523d),
},
            new NpgsqlBoxbox0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4338408545212056d,right: 0.8981239234958287d,bottom: 0.06046468785030701d,left: 0.12063052226326965d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7393795296843155d,right: 0.7910598229286685d,bottom: 0.6144472779550111d,left: 0.40983653295875666d),
},
            new NpgsqlBoxbox0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7594846052137395d,right: 0.3637390001234957d,bottom: 0.4462674566408559d,left: 0.36328590533162175d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4698095911006991d,right: 0.5912178520921517d,bottom: 0.42047641508126443d,left: 0.31437314745940215d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8567426955413232d,right: 0.8122351123001144d,bottom: 0.04348256111501958d,left: 0.18781156077966443d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5861549580964568d,right: 0.3066571683449135d,bottom: 0.16358387961342846d,left: 0.22227409462956282d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5814084251811058d,right: 0.8849477885586234d,bottom: 0.496220440840372d,left: 0.6512422783922207d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6715919634684494d,right: 0.6925702045906418d,bottom: 0.6593233542953155d,left: 0.5917086910526901d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.38653200166426127d,right: 0.8508249235198252d,bottom: 0.2035490593467424d,left: 0.8079021316616366d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.97379126512571d,right: 0.7595140429590379d,bottom: 0.7458769383671603d,left: 0.15479174100626658d),
},
            new NpgsqlBoxbox0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6165037807862954d,right: 0.5923791967986131d,bottom: 0.4753888446656528d,left: 0.47315213265656586d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.49793417258396566d,right: 0.47049231726827434d,bottom: 0.4108363083633887d,left: 0.027421909890294804d),
},
            new NpgsqlBoxbox0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8704678616042487d,right: 0.7543304907975339d,bottom: 0.5141797342884267d,left: 0.6838004921069686d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7466408001946716d,right: 0.7577876070673937d,bottom: 0.14076344453382583d,left: 0.4775828606726117d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5089971390200317d,right: 0.878234948397885d,bottom: 0.4544988850640138d,left: 0.26946174067935913d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1913890633600941d,right: 0.28484009302594016d,bottom: 0.12049247880218861d,left: 0.23509819298866208d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.563054402266484d,right: 0.8591119588075077d,bottom: 0.08647538163140822d,left: 0.4986487178331437d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6563450883138692d,right: 0.8712488566216191d,bottom: 0.6366347906618531d,left: 0.7473409636440015d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4409639234843893d,right: 0.46748259371739d,bottom: 0.41282606949599365d,left: 0.26915064955195156d),
},
            new NpgsqlBoxbox0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9704508077483949d,right: 0.1321813808116623d,bottom: 0.6553009386347229d,left: 0.11221184484937119d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8597411971291435d,right: 0.878681691770713d,bottom: 0.07732200644656084d,left: 0.8324641780435957d),
},
            new NpgsqlBoxbox0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9515172652468872d,right: 0.4300147550833956d,bottom: 0.2837346844333526d,left: 0.32951696562891786d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17768079904931677d,right: 0.8923512212358716d,bottom: 0.08620464863230426d,left: 0.6981604400498839d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8295174791062929d,right: 0.9034483452168041d,bottom: 0.30361782150699257d,left: 0.4415313515941254d),
},
            new NpgsqlBoxbox0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6342187488470485d,right: 0.3267246232945342d,bottom: 0.5033028462551318d,left: 0.07854740354044065d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8801472565084617d,right: 0.2189948416610652d,bottom: 0.5141589129759743d,left: 0.07375924957854996d),
},
            new NpgsqlBoxbox0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.43796872011082555d,right: 0.7353078300405985d,bottom: 0.05503656394702405d,left: 0.7026314854434733d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9018048918757466d,right: 0.5197925249979819d,bottom: 0.7453580548334611d,left: 0.018922817311051388d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.955680347703433d,right: 0.5618901669839775d,bottom: 0.7606204766863681d,left: 0.2615454074374649d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.28332298522697896d,right: 0.6504861129071764d,bottom: 0.04107704760641029d,left: 0.2514743558194166d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3154646128781592d,right: 0.2244152283715377d,bottom: 0.2471197071975274d,left: 0.14001354164252433d),
},
            new NpgsqlBoxbox0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8504566550878192d,right: 0.4445303733223931d,bottom: 0.7586664981993197d,left: 0.09334919174338163d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8632751777617667d,right: 0.47658864102195064d,bottom: 0.08422239151066979d,left: 0.2422247928184541d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.11457645121571547d,right: 0.35480941787836173d,bottom: 0.0853354602583174d,left: 0.03166789814677207d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9094673188119744d,right: 0.4274868105634496d,bottom: 0.2641701973277395d,left: 0.011575090553862522d),
},
            new NpgsqlBoxbox0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4517217627861543d,right: 0.43163447537480826d,bottom: 0.11907091081468457d,left: 0.15738736243047757d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.08958888869293202d,right: 0.6175035827782771d,bottom: 0.07949382762101254d,left: 0.268427943489979d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7203756967568098d,right: 0.8877874723056016d,bottom: 0.48356629154855846d,left: 0.5471600998655963d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9487804735528723d,right: 0.951358986613122d,bottom: 0.15090913521245164d,left: 0.5841593563260895d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5268920816297592d,right: 0.8190464646998721d,bottom: 0.17518672858729778d,left: 0.38165870371150323d),
},
            new NpgsqlBoxbox0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7694496835988193d,right: 0.28072057505138226d,bottom: 0.7382186789921857d,left: 0.19065545585410304d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2837322696204968d,right: 0.5646955501609006d,bottom: 0.05060883472619537d,left: 0.5184247998405179d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8151550276919448d,right: 0.8372607054950642d,bottom: 0.3865300319037336d,left: 0.34973810400192773d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6779936929073405d,right: 0.6074530983488758d,bottom: 0.23684986963638832d,left: 0.15846666106329765d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.28821808744352384d,right: 0.44514672338618644d,bottom: 0.08734069820675439d,left: 0.2558257606369819d),
},
            new NpgsqlBoxbox0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6536545599266336d,right: 0.8550229815409377d,bottom: 0.367817017333782d,left: 0.722541113082731d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8190728786247945d,right: 0.34247711756878463d,bottom: 0.20144518679681778d,left: 0.08424288165150995d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7356113084203585d,right: 0.6975496641499697d,bottom: 0.4398797919027423d,left: 0.31885766299483376d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9290519336416321d,right: 0.6859200612370725d,bottom: 0.8659733631798094d,left: 0.28728715800487403d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5341472554499022d,right: 0.2826607695558919d,bottom: 0.1767333711153094d,left: 0.035465648388415816d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6538058184854141d,right: 0.7230391889307991d,bottom: 0.07450518515294924d,left: 0.6729311041464412d)));
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 31, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 151, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 132, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 139, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 68, query2))
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 97, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[33],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 146, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[32],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 111, 153))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
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

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9294779224561582d,right: 0.4428980773959481d,bottom: 0.6470191003480593d,left: 0.4398901670801154d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9615466603669358d,right: 0.5659972623972618d,bottom: 0.32207890480053813d,left: 0.2834431031062524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5682566796666342d,right: 0.269644718731501d,bottom: 0.5447389859902857d,left: 0.10687854585043477d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7920233979784481d,right: 0.4340026260326091d,bottom: 0.15096859021207676d,left: 0.22171716427692056d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7914906026449822d,right: 0.7629521482984213d,bottom: 0.28031169295861047d,left: 0.43617217526056096d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9983283427533207d,right: 0.8604191088923364d,bottom: 0.9284368922462396d,left: 0.21632131542120403d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5670372762833442d,right: 0.8467495792510601d,bottom: 0.3698944873786607d,left: 0.820052698932674d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8804477923920239d,right: 0.447714862138087d,bottom: 0.6612134807439439d,left: 0.21091695241979702d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8676967312126723d,right: 0.7447183842234715d,bottom: 0.6866571346217147d,left: 0.018674932638535813d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6479562830599352d,right: 0.852677435433365d,bottom: 0.23493050421035833d,left: 0.4584806922206688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7356113084203585d,right: 0.6975496641499697d,bottom: 0.4398797919027423d,left: 0.31885766299483376d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3911137520207454d,right: 0.7982591111674721d,bottom: 0.05093607534144118d,left: 0.3254212780018967d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.818152280849944d,right: 0.6416761455232644d,bottom: 0.6851339844409334d,left: 0.007308670279926877d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3308439041694261d,right: 0.7556186871332493d,bottom: 0.20383559415531016d,left: 0.6971671205415322d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8800581587683394d,right: 0.5088234121192513d,bottom: 0.34805568308100443d,left: 0.12417013427189671d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8677057855192898d,right: 0.25138283167640596d,bottom: 0.16641739096849462d,left: 0.07316137226034758d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6462578812135593d,right: 0.7888280475222297d,bottom: 0.30070893208865523d,left: 0.4274405132807667d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4217063369133337d,right: 0.6969876837773564d,bottom: 0.3699019672261852d,left: 0.39564840891706354d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9290519336416321d,right: 0.6859200612370725d,bottom: 0.8659733631798094d,left: 0.28728715800487403d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7605094732929121d,right: 0.8677167198987246d,bottom: 0.5378118051286183d,left: 0.28216965534835237d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5341472554499022d,right: 0.2826607695558919d,bottom: 0.1767333711153094d,left: 0.035465648388415816d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.87834973195896d,right: 0.5503609194407028d,bottom: 0.694754503505792d,left: 0.5451664713685398d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8980996518067595d,right: 0.8210366709684985d,bottom: 0.8263655539849201d,left: 0.040379551649406986d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9166148974332025d,right: 0.6530856006876411d,bottom: 0.7889326370273927d,left: 0.27463562623885707d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8569907316563555d,right: 0.658366862343998d,bottom: 0.04208573125539039d,left: 0.07247125133249377d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3577850430925523d,right: 0.7159889624875401d,bottom: 0.29570589636815137d,left: 0.32393215801853326d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6538058184854141d,right: 0.7230391889307991d,bottom: 0.07450518515294924d,left: 0.6729311041464412d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1498884036325442d,right: 0.913484845586311d,bottom: 0.05203546797460212d,left: 0.0747132982056734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7158735268832398d,right: 0.902013625983589d,bottom: 0.23083887024170535d,left: 0.40202987668311807d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19578948558644227d,right: 0.4467597239547596d,bottom: 0.1692228160799315d,left: 0.21310548815847918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6123224072573326d,right: 0.5096994124939902d,bottom: 0.11395011877024841d,left: 0.016154489395843963d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8268881774855525d,right: 0.7983261100377209d,bottom: 0.32306428925581065d,left: 0.6567874258712729d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5593026822736256d,right: 0.7690693085771156d,bottom: 0.5258149328134935d,left: 0.4133763527121923d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9456728602446719d,right: 0.18044439349152486d,bottom: 0.6842060102935172d,left: 0.014806397518272174d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5908433253582904d,right: 0.6716338744750148d,bottom: 0.0808551721913705d,left: 0.48184971335136173d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9043533540883921d,right: 0.8747603443033772d,bottom: 0.014019662359615603d,left: 0.6397943618496493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7352704884041842d,right: 0.636103882688438d,bottom: 0.15917631974260305d,left: 0.4296820256885415d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8286063739732615d,right: 0.9063259434973939d,bottom: 0.5998287085147017d,left: 0.43823223536522016d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.544029805414346d,right: 0.8426911325258009d,bottom: 0.5407238504568638d,left: 0.5559411333922523d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4338408545212056d,right: 0.8981239234958287d,bottom: 0.06046468785030701d,left: 0.12063052226326965d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7393795296843155d,right: 0.7910598229286685d,bottom: 0.6144472779550111d,left: 0.40983653295875666d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7594846052137395d,right: 0.3637390001234957d,bottom: 0.4462674566408559d,left: 0.36328590533162175d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4698095911006991d,right: 0.5912178520921517d,bottom: 0.42047641508126443d,left: 0.31437314745940215d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8567426955413232d,right: 0.8122351123001144d,bottom: 0.04348256111501958d,left: 0.18781156077966443d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5861549580964568d,right: 0.3066571683449135d,bottom: 0.16358387961342846d,left: 0.22227409462956282d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5814084251811058d,right: 0.8849477885586234d,bottom: 0.496220440840372d,left: 0.6512422783922207d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6715919634684494d,right: 0.6925702045906418d,bottom: 0.6593233542953155d,left: 0.5917086910526901d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38653200166426127d,right: 0.8508249235198252d,bottom: 0.2035490593467424d,left: 0.8079021316616366d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.97379126512571d,right: 0.7595140429590379d,bottom: 0.7458769383671603d,left: 0.15479174100626658d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6165037807862954d,right: 0.5923791967986131d,bottom: 0.4753888446656528d,left: 0.47315213265656586d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49793417258396566d,right: 0.47049231726827434d,bottom: 0.4108363083633887d,left: 0.027421909890294804d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8704678616042487d,right: 0.7543304907975339d,bottom: 0.5141797342884267d,left: 0.6838004921069686d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7466408001946716d,right: 0.7577876070673937d,bottom: 0.14076344453382583d,left: 0.4775828606726117d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5089971390200317d,right: 0.878234948397885d,bottom: 0.4544988850640138d,left: 0.26946174067935913d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1913890633600941d,right: 0.28484009302594016d,bottom: 0.12049247880218861d,left: 0.23509819298866208d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.563054402266484d,right: 0.8591119588075077d,bottom: 0.08647538163140822d,left: 0.4986487178331437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6563450883138692d,right: 0.8712488566216191d,bottom: 0.6366347906618531d,left: 0.7473409636440015d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4409639234843893d,right: 0.46748259371739d,bottom: 0.41282606949599365d,left: 0.26915064955195156d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9704508077483949d,right: 0.1321813808116623d,bottom: 0.6553009386347229d,left: 0.11221184484937119d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8597411971291435d,right: 0.878681691770713d,bottom: 0.07732200644656084d,left: 0.8324641780435957d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9515172652468872d,right: 0.4300147550833956d,bottom: 0.2837346844333526d,left: 0.32951696562891786d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17768079904931677d,right: 0.8923512212358716d,bottom: 0.08620464863230426d,left: 0.6981604400498839d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8295174791062929d,right: 0.9034483452168041d,bottom: 0.30361782150699257d,left: 0.4415313515941254d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6342187488470485d,right: 0.3267246232945342d,bottom: 0.5033028462551318d,left: 0.07854740354044065d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8801472565084617d,right: 0.2189948416610652d,bottom: 0.5141589129759743d,left: 0.07375924957854996d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43796872011082555d,right: 0.7353078300405985d,bottom: 0.05503656394702405d,left: 0.7026314854434733d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9018048918757466d,right: 0.5197925249979819d,bottom: 0.7453580548334611d,left: 0.018922817311051388d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.955680347703433d,right: 0.5618901669839775d,bottom: 0.7606204766863681d,left: 0.2615454074374649d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.28332298522697896d,right: 0.6504861129071764d,bottom: 0.04107704760641029d,left: 0.2514743558194166d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3154646128781592d,right: 0.2244152283715377d,bottom: 0.2471197071975274d,left: 0.14001354164252433d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8504566550878192d,right: 0.4445303733223931d,bottom: 0.7586664981993197d,left: 0.09334919174338163d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8632751777617667d,right: 0.47658864102195064d,bottom: 0.08422239151066979d,left: 0.2422247928184541d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.11457645121571547d,right: 0.35480941787836173d,bottom: 0.0853354602583174d,left: 0.03166789814677207d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9094673188119744d,right: 0.4274868105634496d,bottom: 0.2641701973277395d,left: 0.011575090553862522d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4517217627861543d,right: 0.43163447537480826d,bottom: 0.11907091081468457d,left: 0.15738736243047757d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08958888869293202d,right: 0.6175035827782771d,bottom: 0.07949382762101254d,left: 0.268427943489979d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7203756967568098d,right: 0.8877874723056016d,bottom: 0.48356629154855846d,left: 0.5471600998655963d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9487804735528723d,right: 0.951358986613122d,bottom: 0.15090913521245164d,left: 0.5841593563260895d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5268920816297592d,right: 0.8190464646998721d,bottom: 0.17518672858729778d,left: 0.38165870371150323d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7694496835988193d,right: 0.28072057505138226d,bottom: 0.7382186789921857d,left: 0.19065545585410304d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2837322696204968d,right: 0.5646955501609006d,bottom: 0.05060883472619537d,left: 0.5184247998405179d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8151550276919448d,right: 0.8372607054950642d,bottom: 0.3865300319037336d,left: 0.34973810400192773d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6779936929073405d,right: 0.6074530983488758d,bottom: 0.23684986963638832d,left: 0.15846666106329765d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.28821808744352384d,right: 0.44514672338618644d,bottom: 0.08734069820675439d,left: 0.2558257606369819d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6536545599266336d,right: 0.8550229815409377d,bottom: 0.367817017333782d,left: 0.722541113082731d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8190728786247945d,right: 0.34247711756878463d,bottom: 0.20144518679681778d,left: 0.08424288165150995d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9294779224561582d,right: 0.4428980773959481d,bottom: 0.6470191003480593d,left: 0.4398901670801154d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9615466603669358d,right: 0.5659972623972618d,bottom: 0.32207890480053813d,left: 0.2834431031062524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5682566796666342d,right: 0.269644718731501d,bottom: 0.5447389859902857d,left: 0.10687854585043477d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7920233979784481d,right: 0.4340026260326091d,bottom: 0.15096859021207676d,left: 0.22171716427692056d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7914906026449822d,right: 0.7629521482984213d,bottom: 0.28031169295861047d,left: 0.43617217526056096d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9983283427533207d,right: 0.8604191088923364d,bottom: 0.9284368922462396d,left: 0.21632131542120403d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5670372762833442d,right: 0.8467495792510601d,bottom: 0.3698944873786607d,left: 0.820052698932674d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8804477923920239d,right: 0.447714862138087d,bottom: 0.6612134807439439d,left: 0.21091695241979702d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8676967312126723d,right: 0.7447183842234715d,bottom: 0.6866571346217147d,left: 0.018674932638535813d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6479562830599352d,right: 0.852677435433365d,bottom: 0.23493050421035833d,left: 0.4584806922206688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7356113084203585d,right: 0.6975496641499697d,bottom: 0.4398797919027423d,left: 0.31885766299483376d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3911137520207454d,right: 0.7982591111674721d,bottom: 0.05093607534144118d,left: 0.3254212780018967d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.818152280849944d,right: 0.6416761455232644d,bottom: 0.6851339844409334d,left: 0.007308670279926877d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3308439041694261d,right: 0.7556186871332493d,bottom: 0.20383559415531016d,left: 0.6971671205415322d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8800581587683394d,right: 0.5088234121192513d,bottom: 0.34805568308100443d,left: 0.12417013427189671d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8677057855192898d,right: 0.25138283167640596d,bottom: 0.16641739096849462d,left: 0.07316137226034758d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6462578812135593d,right: 0.7888280475222297d,bottom: 0.30070893208865523d,left: 0.4274405132807667d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4217063369133337d,right: 0.6969876837773564d,bottom: 0.3699019672261852d,left: 0.39564840891706354d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9290519336416321d,right: 0.6859200612370725d,bottom: 0.8659733631798094d,left: 0.28728715800487403d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7605094732929121d,right: 0.8677167198987246d,bottom: 0.5378118051286183d,left: 0.28216965534835237d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5341472554499022d,right: 0.2826607695558919d,bottom: 0.1767333711153094d,left: 0.035465648388415816d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.87834973195896d,right: 0.5503609194407028d,bottom: 0.694754503505792d,left: 0.5451664713685398d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8980996518067595d,right: 0.8210366709684985d,bottom: 0.8263655539849201d,left: 0.040379551649406986d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9166148974332025d,right: 0.6530856006876411d,bottom: 0.7889326370273927d,left: 0.27463562623885707d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8569907316563555d,right: 0.658366862343998d,bottom: 0.04208573125539039d,left: 0.07247125133249377d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3577850430925523d,right: 0.7159889624875401d,bottom: 0.29570589636815137d,left: 0.32393215801853326d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6538058184854141d,right: 0.7230391889307991d,bottom: 0.07450518515294924d,left: 0.6729311041464412d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1498884036325442d,right: 0.913484845586311d,bottom: 0.05203546797460212d,left: 0.0747132982056734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7158735268832398d,right: 0.902013625983589d,bottom: 0.23083887024170535d,left: 0.40202987668311807d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.19578948558644227d,right: 0.4467597239547596d,bottom: 0.1692228160799315d,left: 0.21310548815847918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6123224072573326d,right: 0.5096994124939902d,bottom: 0.11395011877024841d,left: 0.016154489395843963d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8268881774855525d,right: 0.7983261100377209d,bottom: 0.32306428925581065d,left: 0.6567874258712729d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5593026822736256d,right: 0.7690693085771156d,bottom: 0.5258149328134935d,left: 0.4133763527121923d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9456728602446719d,right: 0.18044439349152486d,bottom: 0.6842060102935172d,left: 0.014806397518272174d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5908433253582904d,right: 0.6716338744750148d,bottom: 0.0808551721913705d,left: 0.48184971335136173d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9043533540883921d,right: 0.8747603443033772d,bottom: 0.014019662359615603d,left: 0.6397943618496493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7352704884041842d,right: 0.636103882688438d,bottom: 0.15917631974260305d,left: 0.4296820256885415d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8286063739732615d,right: 0.9063259434973939d,bottom: 0.5998287085147017d,left: 0.43823223536522016d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.544029805414346d,right: 0.8426911325258009d,bottom: 0.5407238504568638d,left: 0.5559411333922523d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4338408545212056d,right: 0.8981239234958287d,bottom: 0.06046468785030701d,left: 0.12063052226326965d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7393795296843155d,right: 0.7910598229286685d,bottom: 0.6144472779550111d,left: 0.40983653295875666d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7594846052137395d,right: 0.3637390001234957d,bottom: 0.4462674566408559d,left: 0.36328590533162175d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4698095911006991d,right: 0.5912178520921517d,bottom: 0.42047641508126443d,left: 0.31437314745940215d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8567426955413232d,right: 0.8122351123001144d,bottom: 0.04348256111501958d,left: 0.18781156077966443d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5861549580964568d,right: 0.3066571683449135d,bottom: 0.16358387961342846d,left: 0.22227409462956282d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5814084251811058d,right: 0.8849477885586234d,bottom: 0.496220440840372d,left: 0.6512422783922207d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6715919634684494d,right: 0.6925702045906418d,bottom: 0.6593233542953155d,left: 0.5917086910526901d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38653200166426127d,right: 0.8508249235198252d,bottom: 0.2035490593467424d,left: 0.8079021316616366d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.97379126512571d,right: 0.7595140429590379d,bottom: 0.7458769383671603d,left: 0.15479174100626658d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6165037807862954d,right: 0.5923791967986131d,bottom: 0.4753888446656528d,left: 0.47315213265656586d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49793417258396566d,right: 0.47049231726827434d,bottom: 0.4108363083633887d,left: 0.027421909890294804d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8704678616042487d,right: 0.7543304907975339d,bottom: 0.5141797342884267d,left: 0.6838004921069686d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7466408001946716d,right: 0.7577876070673937d,bottom: 0.14076344453382583d,left: 0.4775828606726117d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5089971390200317d,right: 0.878234948397885d,bottom: 0.4544988850640138d,left: 0.26946174067935913d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1913890633600941d,right: 0.28484009302594016d,bottom: 0.12049247880218861d,left: 0.23509819298866208d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.563054402266484d,right: 0.8591119588075077d,bottom: 0.08647538163140822d,left: 0.4986487178331437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6563450883138692d,right: 0.8712488566216191d,bottom: 0.6366347906618531d,left: 0.7473409636440015d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4409639234843893d,right: 0.46748259371739d,bottom: 0.41282606949599365d,left: 0.26915064955195156d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9704508077483949d,right: 0.1321813808116623d,bottom: 0.6553009386347229d,left: 0.11221184484937119d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8597411971291435d,right: 0.878681691770713d,bottom: 0.07732200644656084d,left: 0.8324641780435957d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9515172652468872d,right: 0.4300147550833956d,bottom: 0.2837346844333526d,left: 0.32951696562891786d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17768079904931677d,right: 0.8923512212358716d,bottom: 0.08620464863230426d,left: 0.6981604400498839d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8295174791062929d,right: 0.9034483452168041d,bottom: 0.30361782150699257d,left: 0.4415313515941254d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6342187488470485d,right: 0.3267246232945342d,bottom: 0.5033028462551318d,left: 0.07854740354044065d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8801472565084617d,right: 0.2189948416610652d,bottom: 0.5141589129759743d,left: 0.07375924957854996d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43796872011082555d,right: 0.7353078300405985d,bottom: 0.05503656394702405d,left: 0.7026314854434733d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9018048918757466d,right: 0.5197925249979819d,bottom: 0.7453580548334611d,left: 0.018922817311051388d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.955680347703433d,right: 0.5618901669839775d,bottom: 0.7606204766863681d,left: 0.2615454074374649d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.28332298522697896d,right: 0.6504861129071764d,bottom: 0.04107704760641029d,left: 0.2514743558194166d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3154646128781592d,right: 0.2244152283715377d,bottom: 0.2471197071975274d,left: 0.14001354164252433d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8504566550878192d,right: 0.4445303733223931d,bottom: 0.7586664981993197d,left: 0.09334919174338163d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8632751777617667d,right: 0.47658864102195064d,bottom: 0.08422239151066979d,left: 0.2422247928184541d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.11457645121571547d,right: 0.35480941787836173d,bottom: 0.0853354602583174d,left: 0.03166789814677207d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9094673188119744d,right: 0.4274868105634496d,bottom: 0.2641701973277395d,left: 0.011575090553862522d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4517217627861543d,right: 0.43163447537480826d,bottom: 0.11907091081468457d,left: 0.15738736243047757d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08958888869293202d,right: 0.6175035827782771d,bottom: 0.07949382762101254d,left: 0.268427943489979d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7203756967568098d,right: 0.8877874723056016d,bottom: 0.48356629154855846d,left: 0.5471600998655963d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9487804735528723d,right: 0.951358986613122d,bottom: 0.15090913521245164d,left: 0.5841593563260895d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5268920816297592d,right: 0.8190464646998721d,bottom: 0.17518672858729778d,left: 0.38165870371150323d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7694496835988193d,right: 0.28072057505138226d,bottom: 0.7382186789921857d,left: 0.19065545585410304d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2837322696204968d,right: 0.5646955501609006d,bottom: 0.05060883472619537d,left: 0.5184247998405179d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8151550276919448d,right: 0.8372607054950642d,bottom: 0.3865300319037336d,left: 0.34973810400192773d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6779936929073405d,right: 0.6074530983488758d,bottom: 0.23684986963638832d,left: 0.15846666106329765d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.28821808744352384d,right: 0.44514672338618644d,bottom: 0.08734069820675439d,left: 0.2558257606369819d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6536545599266336d,right: 0.8550229815409377d,bottom: 0.367817017333782d,left: 0.722541113082731d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8190728786247945d,right: 0.34247711756878463d,bottom: 0.20144518679681778d,left: 0.08424288165150995d))));

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

