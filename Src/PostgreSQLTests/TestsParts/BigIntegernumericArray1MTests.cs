

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
    Id = 5,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2568942935607468963L),
new System.Numerics.BigInteger(1553984316849522815L),
new System.Numerics.BigInteger(5504770218887543871L),
new System.Numerics.BigInteger(3821594863974217987L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1095851644665949288L),
new System.Numerics.BigInteger(8912565459064300395L),
new System.Numerics.BigInteger(8469333955546334253L),
},
},
            new BigIntegernumericArray1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5586014099687921580L),
new System.Numerics.BigInteger(4841506343937899378L),
new System.Numerics.BigInteger(8447284475661538270L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6129179311338465302L),
new System.Numerics.BigInteger(4208087547531162220L),
new System.Numerics.BigInteger(571039364410554822L),
new System.Numerics.BigInteger(7124745968547868935L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3892308088999388291L),
new System.Numerics.BigInteger(152747015471621854L),
new System.Numerics.BigInteger(2185772836480690649L),
new System.Numerics.BigInteger(1437171078036262353L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5677533630845211370L),
new System.Numerics.BigInteger(4451149602995447854L),
new System.Numerics.BigInteger(5235686048382970331L),
new System.Numerics.BigInteger(2923469924698188496L),
},
},
            new BigIntegernumericArray1M
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6526549853713174854L),
new System.Numerics.BigInteger(5293497080179537194L),
new System.Numerics.BigInteger(7894224668347629756L),
new System.Numerics.BigInteger(6113997234298268866L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7947182773001624346L),
new System.Numerics.BigInteger(3004333095565418713L),
new System.Numerics.BigInteger(3468684828890364777L),
new System.Numerics.BigInteger(7592815875454865125L),
},
},
            new BigIntegernumericArray1M
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3952641597613952037L),
new System.Numerics.BigInteger(8294019741990242448L),
new System.Numerics.BigInteger(4391904615367699638L),
new System.Numerics.BigInteger(2822833528488335002L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5214865405617473128L),
new System.Numerics.BigInteger(6688833234144787249L),
new System.Numerics.BigInteger(4011849085652874175L),
new System.Numerics.BigInteger(2993642339442548051L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1853740869521669810L),
new System.Numerics.BigInteger(572947449483742368L),
new System.Numerics.BigInteger(1074470765210289473L),
new System.Numerics.BigInteger(234291273360991482L),
},
},
            new BigIntegernumericArray1M
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6379857381362595620L),
new System.Numerics.BigInteger(8620556165625056904L),
new System.Numerics.BigInteger(3301279407624228888L),
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
new System.Numerics.BigInteger(2326506135016883678L),
new System.Numerics.BigInteger(1424044310110876133L),
new System.Numerics.BigInteger(8606146457711408514L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8282844050362433623L),
new System.Numerics.BigInteger(883582437413870715L),
new System.Numerics.BigInteger(765782293983642273L),
new System.Numerics.BigInteger(5037158383024565801L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2320837184493643223L),
new System.Numerics.BigInteger(5190172190067800395L),
new System.Numerics.BigInteger(5542588848891798406L),
new System.Numerics.BigInteger(4631993602934591502L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9171157461353335369L),
new System.Numerics.BigInteger(171638327403431087L),
new System.Numerics.BigInteger(4705620803186129107L),
},
},
            new BigIntegernumericArray1M
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2108529642473807842L),
new System.Numerics.BigInteger(5033535542777640685L),
new System.Numerics.BigInteger(3544720993775663620L),
new System.Numerics.BigInteger(3571750282837889446L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1359361047427700361L),
new System.Numerics.BigInteger(1318155308682641160L),
new System.Numerics.BigInteger(4634312807899923690L),
new System.Numerics.BigInteger(6345791948209873928L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7847025796844733103L),
new System.Numerics.BigInteger(2106922543259526878L),
new System.Numerics.BigInteger(6866219556889920422L),
new System.Numerics.BigInteger(2781237651033071359L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4706278105010994095L),
new System.Numerics.BigInteger(4390996629913423802L),
new System.Numerics.BigInteger(5418850179922447668L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2754050576917574579L),
new System.Numerics.BigInteger(757891511728439301L),
new System.Numerics.BigInteger(1637846978556326637L),
new System.Numerics.BigInteger(1328075451300985545L),
},
},
            new BigIntegernumericArray1M
{
    Id = 62,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3334874759856361389L),
new System.Numerics.BigInteger(1577859276779236423L),
new System.Numerics.BigInteger(3956632086501491693L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7871974635113396333L),
new System.Numerics.BigInteger(8507911734762436705L),
new System.Numerics.BigInteger(5414421238712023938L),
new System.Numerics.BigInteger(9140722136444097290L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6922971956725180662L),
new System.Numerics.BigInteger(1197605613733259115L),
new System.Numerics.BigInteger(7665847462749025035L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(807268077620935233L),
new System.Numerics.BigInteger(8549166010496505410L),
new System.Numerics.BigInteger(7833209993765519921L),
},
},
            new BigIntegernumericArray1M
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9203270127031003035L),
new System.Numerics.BigInteger(2680537337215093825L),
new System.Numerics.BigInteger(4960372874099043507L),
new System.Numerics.BigInteger(3671853013294200685L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5586763826640978111L),
new System.Numerics.BigInteger(3328100052159999415L),
new System.Numerics.BigInteger(8861134043725128955L),
},
},
            new BigIntegernumericArray1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(293835010911229532L),
new System.Numerics.BigInteger(4578800164069460002L),
new System.Numerics.BigInteger(3293038903821901340L),
new System.Numerics.BigInteger(4519627707378025948L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1012347566906183606L),
new System.Numerics.BigInteger(6763715945779231781L),
new System.Numerics.BigInteger(5377331428822579238L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5416756213661255842L),
new System.Numerics.BigInteger(5391380363696862685L),
new System.Numerics.BigInteger(1077274228256830097L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(852794441081027139L),
new System.Numerics.BigInteger(2531697797563459043L),
new System.Numerics.BigInteger(5459504616592120830L),
},
},
            new BigIntegernumericArray1M
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(614409848711976468L),
new System.Numerics.BigInteger(1147942359311005086L),
new System.Numerics.BigInteger(1050487204327497771L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 87,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5640306602451331854L),
new System.Numerics.BigInteger(5413586380366763857L),
new System.Numerics.BigInteger(4118087811430269986L),
new System.Numerics.BigInteger(2393679568679693375L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7296088103971543097L),
new System.Numerics.BigInteger(7606251870585244486L),
new System.Numerics.BigInteger(82241640531963042L),
new System.Numerics.BigInteger(2705768681474716657L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4340721773888626841L),
new System.Numerics.BigInteger(7444581180181338707L),
new System.Numerics.BigInteger(5615954690385544953L),
new System.Numerics.BigInteger(5539398055002277676L),
},
},
            new BigIntegernumericArray1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1704301943821220208L),
new System.Numerics.BigInteger(7990642282101480095L),
new System.Numerics.BigInteger(7023869540152682201L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5507893246014468459L),
new System.Numerics.BigInteger(4111037653713517707L),
new System.Numerics.BigInteger(8826578514638062156L),
new System.Numerics.BigInteger(1335659532776186709L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(275261714202284892L),
new System.Numerics.BigInteger(5342989939084264084L),
new System.Numerics.BigInteger(4691541532259242792L),
new System.Numerics.BigInteger(3200794206497336638L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3591549868970014176L),
new System.Numerics.BigInteger(1806213572323612910L),
new System.Numerics.BigInteger(6937946529860317230L),
new System.Numerics.BigInteger(91421985452274726L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4944932205937391046L),
new System.Numerics.BigInteger(4303001364098451483L),
new System.Numerics.BigInteger(4172169273999430508L),
new System.Numerics.BigInteger(8033964290519559368L),
},
},
            new BigIntegernumericArray1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364222490681418902L),
new System.Numerics.BigInteger(7939630200219844960L),
new System.Numerics.BigInteger(4687819643869181350L),
new System.Numerics.BigInteger(8158318172216782027L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3931140406520276431L),
new System.Numerics.BigInteger(4679705643337024897L),
new System.Numerics.BigInteger(2380228534148003223L),
new System.Numerics.BigInteger(2153608305692630083L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8697191993780062687L),
new System.Numerics.BigInteger(2341908285650053444L),
new System.Numerics.BigInteger(4259627159093585490L),
new System.Numerics.BigInteger(7628200089207767001L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 105,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4174900981109607037L),
new System.Numerics.BigInteger(5694945812412146358L),
new System.Numerics.BigInteger(3012996825307605925L),
new System.Numerics.BigInteger(4248004977655207304L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(643157183600508946L),
new System.Numerics.BigInteger(2654615956681263818L),
new System.Numerics.BigInteger(6849977375721856164L),
new System.Numerics.BigInteger(3958876831245920311L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 41,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6243966702784568446L),
new System.Numerics.BigInteger(6899134865143045010L),
new System.Numerics.BigInteger(8194301591545165183L),
new System.Numerics.BigInteger(1018465719616087352L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 121,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7012650169305012177L),
new System.Numerics.BigInteger(5518926924878752143L),
new System.Numerics.BigInteger(6571869422637495945L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3562769643664669595L),
new System.Numerics.BigInteger(7510824590839638566L),
new System.Numerics.BigInteger(3456556364692355049L),
new System.Numerics.BigInteger(4183218696565964571L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7948981334394982897L),
new System.Numerics.BigInteger(1563364113830890789L),
new System.Numerics.BigInteger(5835318048886185026L),
new System.Numerics.BigInteger(1352852884959488197L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 136,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5377005575385621125L),
new System.Numerics.BigInteger(3647233290488990919L),
new System.Numerics.BigInteger(779653133803948938L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7651874483988346647L),
new System.Numerics.BigInteger(7767236345509466067L),
new System.Numerics.BigInteger(7693542265037096231L),
new System.Numerics.BigInteger(3250871521446492019L),
},
},
            new BigIntegernumericArray1M
{
    Id = 141,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3801917107550801171L),
new System.Numerics.BigInteger(2876380632943887797L),
new System.Numerics.BigInteger(1158989940112898691L),
new System.Numerics.BigInteger(5688776265229216004L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8593892473577151867L),
new System.Numerics.BigInteger(1671463533377183279L),
new System.Numerics.BigInteger(6621989726654659556L),
new System.Numerics.BigInteger(5566130453233057049L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7486419350868288096L),
new System.Numerics.BigInteger(4301143533150967681L),
new System.Numerics.BigInteger(8278782809125679408L),
},
},
            new BigIntegernumericArray1M
{
    Id = 146,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5699938012389630178L),
new System.Numerics.BigInteger(2759127448391177080L),
new System.Numerics.BigInteger(3283167160219247484L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5279492896474022130L),
new System.Numerics.BigInteger(5218851002345471055L),
new System.Numerics.BigInteger(7897060106486442778L),
new System.Numerics.BigInteger(6684387103223880672L),
},
},
            new BigIntegernumericArray1M
{
    Id = 151,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2795804461026341461L),
new System.Numerics.BigInteger(5472523960268852179L),
new System.Numerics.BigInteger(1938198050664586586L),
new System.Numerics.BigInteger(4978763091753750724L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7750714444918638135L),
new System.Numerics.BigInteger(2666828055265358167L),
new System.Numerics.BigInteger(4664135855359036470L),
new System.Numerics.BigInteger(5578640245706819503L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8153765266513571707L),
new System.Numerics.BigInteger(577111087007531398L),
new System.Numerics.BigInteger(3858070454989897657L),
new System.Numerics.BigInteger(156242242231185795L),
},
},
            new BigIntegernumericArray1M
{
    Id = 156,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(928812634588568141L),
new System.Numerics.BigInteger(7526208255914623443L),
new System.Numerics.BigInteger(2901680111592810346L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4189664850697491852L),
new System.Numerics.BigInteger(7241546782254191823L),
new System.Numerics.BigInteger(7229789626486624464L),
},
},
            new BigIntegernumericArray1M
{
    Id = 160,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7698991147580417539L),
new System.Numerics.BigInteger(6304505256611063185L),
new System.Numerics.BigInteger(1425264458243626470L),
new System.Numerics.BigInteger(2198400714837496754L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8146875884675762406L),
new System.Numerics.BigInteger(8668184179461734023L),
new System.Numerics.BigInteger(5091393210386453757L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2044563485725687588L),
new System.Numerics.BigInteger(6188675449217059324L),
new System.Numerics.BigInteger(4110743368628854111L),
},
},
            new BigIntegernumericArray1M
{
    Id = 165,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9034909759137094828L),
new System.Numerics.BigInteger(1703055084687282643L),
new System.Numerics.BigInteger(716194427184180510L),
new System.Numerics.BigInteger(7718162078732027978L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4871166854384084442L),
new System.Numerics.BigInteger(5425823720886207870L),
new System.Numerics.BigInteger(344491243331215265L),
new System.Numerics.BigInteger(1217575511611159633L),
},
},
            new BigIntegernumericArray1M
{
    Id = 174,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6894208499860025897L),
new System.Numerics.BigInteger(2972826223380818556L),
new System.Numerics.BigInteger(6786557697385077954L),
new System.Numerics.BigInteger(5607137054901405270L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8353329708079737899L),
new System.Numerics.BigInteger(1210464041455324657L),
new System.Numerics.BigInteger(208832946917902696L),
new System.Numerics.BigInteger(5741149058110633975L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 176,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1561525978787443710L),
new System.Numerics.BigInteger(6361279463056804704L),
new System.Numerics.BigInteger(1543090435952873268L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(283516801170272958L),
new System.Numerics.BigInteger(986596056079763268L),
new System.Numerics.BigInteger(5027625630772761480L),
},
},
            new BigIntegernumericArray1M
{
    Id = 183,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8443501434052533811L),
new System.Numerics.BigInteger(3994386746713385880L),
new System.Numerics.BigInteger(5679510555363544950L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6623832929184533825L),
new System.Numerics.BigInteger(1709891920405394749L),
new System.Numerics.BigInteger(4341724490242320118L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 188,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2044578041908212156L),
new System.Numerics.BigInteger(6757887011216774191L),
new System.Numerics.BigInteger(5419869070699068412L),
new System.Numerics.BigInteger(4384994827509813947L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 192,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9170410743351944873L),
new System.Numerics.BigInteger(8164082343568588766L),
new System.Numerics.BigInteger(5462227651820143793L),
new System.Numerics.BigInteger(8749504759556028871L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6632001587129072744L),
new System.Numerics.BigInteger(4342593009666360876L),
new System.Numerics.BigInteger(1652385931676288107L),
new System.Numerics.BigInteger(2427373003965648897L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 198,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8107304636914251132L),
new System.Numerics.BigInteger(130131674542917026L),
new System.Numerics.BigInteger(6502232028714227416L),
new System.Numerics.BigInteger(4210395392981093747L),
},
    ModelInner = null,
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 188;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 174, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 55, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 100, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
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
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[33],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 188, query1, 176, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 18, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 30, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(BigIntegernumericArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI), typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                await ((IBigIntegerArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                ((IBigIntegerArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

