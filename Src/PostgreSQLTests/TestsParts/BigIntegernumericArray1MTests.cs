

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
    Id = 6,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1735308727493607541L),
new System.Numerics.BigInteger(1768324606559319619L),
new System.Numerics.BigInteger(704796096736410112L),
new System.Numerics.BigInteger(6909577407408910008L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4223978005772770798L),
new System.Numerics.BigInteger(2239948315336140822L),
new System.Numerics.BigInteger(1824284719453186195L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7796657125069825900L),
new System.Numerics.BigInteger(3197594334691157832L),
new System.Numerics.BigInteger(7864702189352945593L),
new System.Numerics.BigInteger(4235536941239791024L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1996308271319528070L),
new System.Numerics.BigInteger(7602264485486656969L),
new System.Numerics.BigInteger(5630349955927036178L),
new System.Numerics.BigInteger(2914331047854001961L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7353176885231904399L),
new System.Numerics.BigInteger(1350270447086583831L),
new System.Numerics.BigInteger(6186794509993593150L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7526936579101171220L),
new System.Numerics.BigInteger(5683462992687423255L),
new System.Numerics.BigInteger(5518661418183376543L),
},
},
            new BigIntegernumericArray1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3204601444879314377L),
new System.Numerics.BigInteger(8547065062594208966L),
new System.Numerics.BigInteger(1442897798734620066L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8741931432590565946L),
new System.Numerics.BigInteger(1987986467593789116L),
new System.Numerics.BigInteger(798368230938556299L),
new System.Numerics.BigInteger(1083894343431447535L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7863535157188108119L),
new System.Numerics.BigInteger(5601717967261283847L),
new System.Numerics.BigInteger(8227112479008044007L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2167705291612385652L),
new System.Numerics.BigInteger(4729419036246036120L),
new System.Numerics.BigInteger(7020318573283835523L),
new System.Numerics.BigInteger(8973540080024139499L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1738441304222798422L),
new System.Numerics.BigInteger(728712583843364095L),
new System.Numerics.BigInteger(7932515645789688909L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(230921523073580821L),
new System.Numerics.BigInteger(3573129486900424090L),
new System.Numerics.BigInteger(6805370885874851586L),
new System.Numerics.BigInteger(5971418850807299517L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580821819010650436L),
new System.Numerics.BigInteger(1068792136758182688L),
new System.Numerics.BigInteger(6804742949163296899L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7853002028518343722L),
new System.Numerics.BigInteger(8122215832077008128L),
new System.Numerics.BigInteger(4073729330083469355L),
new System.Numerics.BigInteger(7519229629853128279L),
},
},
            new BigIntegernumericArray1M
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1955040311216762429L),
new System.Numerics.BigInteger(4489663921021418208L),
new System.Numerics.BigInteger(1909953942204475472L),
new System.Numerics.BigInteger(1040897826638954004L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(521718099388669571L),
new System.Numerics.BigInteger(2906190638750290962L),
new System.Numerics.BigInteger(6411101080633140233L),
new System.Numerics.BigInteger(4328273557130272549L),
},
},
            new BigIntegernumericArray1M
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2945975639219905808L),
new System.Numerics.BigInteger(1369356349290340065L),
new System.Numerics.BigInteger(9048593121649756628L),
new System.Numerics.BigInteger(2804071976360634165L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(493265112339114401L),
new System.Numerics.BigInteger(7155338571741841641L),
new System.Numerics.BigInteger(8980878913669553905L),
new System.Numerics.BigInteger(2738006696086326005L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(812997050855097731L),
new System.Numerics.BigInteger(3401413438076391293L),
new System.Numerics.BigInteger(3517674326217477813L),
new System.Numerics.BigInteger(5933735761853556137L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2074388779238294705L),
new System.Numerics.BigInteger(671869588273809988L),
new System.Numerics.BigInteger(1556739380030102544L),
new System.Numerics.BigInteger(719691407191592511L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5057864437770095103L),
new System.Numerics.BigInteger(1094894703059037228L),
new System.Numerics.BigInteger(3862894363143941688L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7640108622911961723L),
new System.Numerics.BigInteger(3264581179042787579L),
new System.Numerics.BigInteger(5130479931947146519L),
new System.Numerics.BigInteger(4082246121477002622L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(335586653291956407L),
new System.Numerics.BigInteger(311628282745489990L),
new System.Numerics.BigInteger(8216833952822032576L),
new System.Numerics.BigInteger(2307171270084608054L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6389649984356740066L),
new System.Numerics.BigInteger(804763241711701232L),
new System.Numerics.BigInteger(2105733086840038093L),
},
},
            new BigIntegernumericArray1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8540872067840799605L),
new System.Numerics.BigInteger(2286965319975507305L),
new System.Numerics.BigInteger(4778757473888530837L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8822208390630030960L),
new System.Numerics.BigInteger(1637263342790469554L),
new System.Numerics.BigInteger(5560557536459306280L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3237943975712177929L),
new System.Numerics.BigInteger(4635035158697925977L),
new System.Numerics.BigInteger(8183773522364757997L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4757196086592713255L),
new System.Numerics.BigInteger(8533075285839682516L),
new System.Numerics.BigInteger(285376800209065111L),
new System.Numerics.BigInteger(8312806910390616009L),
},
},
            new BigIntegernumericArray1M
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2975805385420411971L),
new System.Numerics.BigInteger(6006124620124692047L),
new System.Numerics.BigInteger(1036576162650229343L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2183352258394249189L),
new System.Numerics.BigInteger(8011553833878976688L),
new System.Numerics.BigInteger(5592113685872159719L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5717323916252756174L),
new System.Numerics.BigInteger(3217702205775907193L),
new System.Numerics.BigInteger(4630264616764735176L),
new System.Numerics.BigInteger(5348196041034503746L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5495113857722970240L),
new System.Numerics.BigInteger(1238748095384078799L),
new System.Numerics.BigInteger(1502488299452828674L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 79,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(830514274925425121L),
new System.Numerics.BigInteger(778190749718892921L),
new System.Numerics.BigInteger(7919277418884932035L),
new System.Numerics.BigInteger(2627201420396502322L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(504208437793907243L),
new System.Numerics.BigInteger(2652016388926520221L),
new System.Numerics.BigInteger(4055644756015043184L),
new System.Numerics.BigInteger(1590275090617123886L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 41,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2075035429592531061L),
new System.Numerics.BigInteger(9217116378061111290L),
new System.Numerics.BigInteger(2390616412006436716L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 86,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3510172864220487687L),
new System.Numerics.BigInteger(5001700778714121912L),
new System.Numerics.BigInteger(3263088964011603037L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 95,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2876226747779927334L),
new System.Numerics.BigInteger(8520641968502594769L),
new System.Numerics.BigInteger(3839878742796735583L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7639422646814083758L),
new System.Numerics.BigInteger(5162227173590855042L),
new System.Numerics.BigInteger(4269874321617902281L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 104,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5666712442057447022L),
new System.Numerics.BigInteger(1266346177725236725L),
new System.Numerics.BigInteger(1067831325612499950L),
new System.Numerics.BigInteger(6217946344398075714L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8228362258382126311L),
new System.Numerics.BigInteger(7243282736898653894L),
new System.Numerics.BigInteger(71833593628977090L),
},
},
            new BigIntegernumericArray1M
{
    Id = 105,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3806118624606220052L),
new System.Numerics.BigInteger(7536644773437939190L),
new System.Numerics.BigInteger(3673503546911447912L),
new System.Numerics.BigInteger(8172948831509515675L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(426870317434399188L),
new System.Numerics.BigInteger(7481096519982770692L),
new System.Numerics.BigInteger(2971771647562670601L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5485797798955646663L),
new System.Numerics.BigInteger(1621027905675820724L),
new System.Numerics.BigInteger(7557527858528533108L),
new System.Numerics.BigInteger(5576064482128874551L),
},
},
            new BigIntegernumericArray1M
{
    Id = 106,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4165628846525299539L),
new System.Numerics.BigInteger(1758734142873772969L),
new System.Numerics.BigInteger(6294886464070189722L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3043389274458727823L),
new System.Numerics.BigInteger(9199282071695583470L),
new System.Numerics.BigInteger(1311290657158581066L),
new System.Numerics.BigInteger(2627417093952222770L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5428214843131675678L),
new System.Numerics.BigInteger(4772296530435899257L),
new System.Numerics.BigInteger(4654051849915540556L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1899584294347224016L),
new System.Numerics.BigInteger(5306686977894697926L),
new System.Numerics.BigInteger(2644868795394326065L),
new System.Numerics.BigInteger(6950483711318458224L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6185841538225909003L),
new System.Numerics.BigInteger(9012612709460736700L),
new System.Numerics.BigInteger(7985959780870968177L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 121,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5105681717435914993L),
new System.Numerics.BigInteger(3145587919480162988L),
new System.Numerics.BigInteger(7826699531958030923L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3191159652459026347L),
new System.Numerics.BigInteger(3541156544814916210L),
new System.Numerics.BigInteger(4406425373038010141L),
new System.Numerics.BigInteger(5649885967989295877L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8758502605440258624L),
new System.Numerics.BigInteger(8397554854388401621L),
new System.Numerics.BigInteger(4096676389909990791L),
new System.Numerics.BigInteger(2610149467391576859L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3025192768732588819L),
new System.Numerics.BigInteger(5547383284315953560L),
new System.Numerics.BigInteger(6783680102032023718L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3716894331022588250L),
new System.Numerics.BigInteger(5327979465409750006L),
new System.Numerics.BigInteger(3508428436422021017L),
},
},
            new BigIntegernumericArray1M
{
    Id = 136,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6957198390621098380L),
new System.Numerics.BigInteger(160224312579130017L),
new System.Numerics.BigInteger(6162348697425723448L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4339664692223316956L),
new System.Numerics.BigInteger(596553845609004831L),
new System.Numerics.BigInteger(3980092311143851804L),
new System.Numerics.BigInteger(3242325182333121786L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(255758319982938654L),
new System.Numerics.BigInteger(5459973739949728366L),
new System.Numerics.BigInteger(2746555916511116010L),
new System.Numerics.BigInteger(6697311791906130505L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8724869259903286483L),
new System.Numerics.BigInteger(8641778361432767019L),
new System.Numerics.BigInteger(2541610227751599904L),
new System.Numerics.BigInteger(6475023521898924859L),
},
},
            new BigIntegernumericArray1M
{
    Id = 143,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2002960113355572222L),
new System.Numerics.BigInteger(6330381534927731194L),
new System.Numerics.BigInteger(7568954492493543552L),
new System.Numerics.BigInteger(2046303872142358274L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 145,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6694757354894346290L),
new System.Numerics.BigInteger(5839296046752134987L),
new System.Numerics.BigInteger(7867163589662314748L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3425507623478060226L),
new System.Numerics.BigInteger(9144714276512852694L),
new System.Numerics.BigInteger(5423802868307312353L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1540225286977462938L),
new System.Numerics.BigInteger(9044286335554357344L),
new System.Numerics.BigInteger(638086892129718558L),
},
},
            new BigIntegernumericArray1M
{
    Id = 151,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7015975220930310480L),
new System.Numerics.BigInteger(5158524284838058560L),
new System.Numerics.BigInteger(7931752385924739917L),
new System.Numerics.BigInteger(6516644097451310657L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 152,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1213627132496212183L),
new System.Numerics.BigInteger(5912365014474413521L),
new System.Numerics.BigInteger(3973677171390864066L),
new System.Numerics.BigInteger(7726508472679525540L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7695541625110686542L),
new System.Numerics.BigInteger(8943037530540603502L),
new System.Numerics.BigInteger(5657389629703350543L),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[7], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[8], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[9], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
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
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
BigIntegernumericArray1M.AssertModel(models[0],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
BigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
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

                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
BigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
BigIntegernumericArray1M.AssertModel(models[0],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 145, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatchAsync(connection, 145, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
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
                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatch(connection, 143, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
BigIntegernumericArray1M.AssertModel(models[0],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
BigIntegernumericArray1M.AssertModel(models[0],_testData[2], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[3], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[27],_testData[29], false);
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
BigIntegernumericArray1M.AssertModel(models[0],_testData[2], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[3], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
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

