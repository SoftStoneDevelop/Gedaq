

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
    internal partial interface IBigIntegerListnumericArray
    {
    }
    
    internal partial class BigIntegerListnumericArray : IBigIntegerListnumericArray
    {


#region TestData

        private readonly BigIntegernumericArray2M[] _testData = new BigIntegernumericArray2M[]
        {
            new BigIntegernumericArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5974926479978167398L),

new System.Numerics.BigInteger(3114189454622391974L),

new System.Numerics.BigInteger(6812259345986081030L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4309671523502002862L),

new System.Numerics.BigInteger(9053627945108015303L),

new System.Numerics.BigInteger(7311966630381691445L),

},
},
            new BigIntegernumericArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5819363375804973262L),

new System.Numerics.BigInteger(9059906443012074716L),

new System.Numerics.BigInteger(8447166935935939731L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1202768710599214830L),

new System.Numerics.BigInteger(5792353382643429354L),

new System.Numerics.BigInteger(5903192633897678300L),

new System.Numerics.BigInteger(4238631571191332772L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3564922574627219382L),

new System.Numerics.BigInteger(116877856409204484L),

new System.Numerics.BigInteger(7365984846079081631L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3384579043877399457L),

new System.Numerics.BigInteger(2344849011763945661L),

new System.Numerics.BigInteger(8713336072031565421L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8559545444323824919L),

new System.Numerics.BigInteger(2046757317293056568L),

new System.Numerics.BigInteger(4245874489321321799L),

new System.Numerics.BigInteger(5474961993973353020L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5937824472082151354L),

new System.Numerics.BigInteger(8200340247543687364L),

new System.Numerics.BigInteger(8514301286526269356L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4663638132519711929L),

new System.Numerics.BigInteger(1897154876518251704L),

new System.Numerics.BigInteger(7739580323649343044L),

new System.Numerics.BigInteger(4838487469753631862L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(557685312541807593L),

new System.Numerics.BigInteger(6782293416248663430L),

new System.Numerics.BigInteger(4793344304853634497L),

},
},
            new BigIntegernumericArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4491832531786129051L),

new System.Numerics.BigInteger(6906162352612872329L),

new System.Numerics.BigInteger(6198480242082849026L),

new System.Numerics.BigInteger(2498408402238914894L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1604141585196215037L),

new System.Numerics.BigInteger(8221683089960837458L),

new System.Numerics.BigInteger(129139415716203511L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358066981729987529L),

new System.Numerics.BigInteger(6377516788329452941L),

new System.Numerics.BigInteger(3930897293036190331L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1453051360129216588L),

new System.Numerics.BigInteger(120724967113750057L),

new System.Numerics.BigInteger(3209416265422202570L),

},
},
            new BigIntegernumericArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(747607244015868413L),

new System.Numerics.BigInteger(5782532159879746154L),

new System.Numerics.BigInteger(7093646569830421366L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4723006750181199654L),

new System.Numerics.BigInteger(7031696490732858970L),

new System.Numerics.BigInteger(6727421192838570575L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(642916006376453055L),

new System.Numerics.BigInteger(6778504705920786858L),

new System.Numerics.BigInteger(2157860913974786773L),

new System.Numerics.BigInteger(3835173494460349591L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4056274628138583254L),

new System.Numerics.BigInteger(6235817766252819125L),

new System.Numerics.BigInteger(5313120541164896682L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1509108825535963012L),

new System.Numerics.BigInteger(8382995918169411660L),

new System.Numerics.BigInteger(5628795133654306865L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4030889809290077765L),

new System.Numerics.BigInteger(6632789248512559445L),

new System.Numerics.BigInteger(1545076197362135776L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3340185735933406196L),

new System.Numerics.BigInteger(7636848818476525988L),

new System.Numerics.BigInteger(8578617237912148025L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(102142012138824889L),

new System.Numerics.BigInteger(485108424057898736L),

new System.Numerics.BigInteger(1489827185123790592L),

new System.Numerics.BigInteger(6729374405042313171L),

},
},
            new BigIntegernumericArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8777655721292773773L),

new System.Numerics.BigInteger(6072980331342180442L),

new System.Numerics.BigInteger(8546752842200587003L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1271642216448669036L),

new System.Numerics.BigInteger(4213376486013616659L),

new System.Numerics.BigInteger(2151097172378679568L),

new System.Numerics.BigInteger(4574328992655316921L),

},
},
            new BigIntegernumericArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(777350205885075125L),

new System.Numerics.BigInteger(7785769895761806897L),

new System.Numerics.BigInteger(4997621417169065923L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2400600116021851920L),

new System.Numerics.BigInteger(8342389038653474476L),

new System.Numerics.BigInteger(1693728501317425419L),

new System.Numerics.BigInteger(2287615189728575769L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7655106083668479798L),

new System.Numerics.BigInteger(3229288659408632881L),

new System.Numerics.BigInteger(7358958427083144757L),

new System.Numerics.BigInteger(2210502225272783855L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6632732685024585332L),

new System.Numerics.BigInteger(7155676536073033643L),

new System.Numerics.BigInteger(4377180518110321370L),

new System.Numerics.BigInteger(5026941377489316834L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2644866027327575245L),

new System.Numerics.BigInteger(5383983547403431826L),

new System.Numerics.BigInteger(1084299285300804128L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4275025098836637576L),

new System.Numerics.BigInteger(5189839703791356926L),

new System.Numerics.BigInteger(8788013425910250915L),

},
},
            new BigIntegernumericArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3962339721528334974L),

new System.Numerics.BigInteger(8168895105399660195L),

new System.Numerics.BigInteger(3733652782123054061L),

new System.Numerics.BigInteger(5202468351577464528L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6148529456704605935L),

new System.Numerics.BigInteger(1200131443927579661L),

new System.Numerics.BigInteger(8939725686725278962L),

},
},
            new BigIntegernumericArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7976850742878902336L),

new System.Numerics.BigInteger(6338158436215786929L),

new System.Numerics.BigInteger(3528383412020268569L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4269083958573780316L),

new System.Numerics.BigInteger(6170892768916260797L),

new System.Numerics.BigInteger(6280470914271655555L),

new System.Numerics.BigInteger(1947272095816774297L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2637069190980605102L),

new System.Numerics.BigInteger(7376580294889892301L),

new System.Numerics.BigInteger(410871076711377806L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8636881260474553673L),

new System.Numerics.BigInteger(1903044763559231705L),

new System.Numerics.BigInteger(8771635833367714919L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6761920761379214672L),

new System.Numerics.BigInteger(7192963071096254687L),

new System.Numerics.BigInteger(2336416185825948396L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3875894134441855945L),

new System.Numerics.BigInteger(5033622650946909709L),

new System.Numerics.BigInteger(512338614646335066L),

new System.Numerics.BigInteger(781355621443349446L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2395307777836707457L),

new System.Numerics.BigInteger(1024556163007645951L),

new System.Numerics.BigInteger(6972499197129425695L),

new System.Numerics.BigInteger(351040879293168692L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4637617271389199808L),

new System.Numerics.BigInteger(3558962538561988263L),

new System.Numerics.BigInteger(4337179967156966911L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4341472809276029645L),

new System.Numerics.BigInteger(8385761353142081502L),

new System.Numerics.BigInteger(2128169697017456914L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3074866329721860465L),

new System.Numerics.BigInteger(7011686620128490939L),

new System.Numerics.BigInteger(5278151682116237025L),

},
},
            new BigIntegernumericArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4600715264402555274L),

new System.Numerics.BigInteger(5131441288209443399L),

new System.Numerics.BigInteger(5620613507294967863L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3959881422185885619L),

new System.Numerics.BigInteger(125777485976579883L),

new System.Numerics.BigInteger(838304193658329107L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7427442071722370045L),

new System.Numerics.BigInteger(3702166234390839994L),

new System.Numerics.BigInteger(2484474123453225270L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4195335603345432860L),

new System.Numerics.BigInteger(7562563591058550743L),

new System.Numerics.BigInteger(3698283696076175535L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5350029551366984817L),

new System.Numerics.BigInteger(3707334676304871406L),

new System.Numerics.BigInteger(873616146282153909L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5622530727208518935L),

new System.Numerics.BigInteger(3094251432308352788L),

new System.Numerics.BigInteger(868115738035107225L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(136726732933881685L),

new System.Numerics.BigInteger(6647765014085921519L),

new System.Numerics.BigInteger(984594974239259591L),

new System.Numerics.BigInteger(6256122195449817278L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3884177487290253190L),

new System.Numerics.BigInteger(7265454722381905613L),

new System.Numerics.BigInteger(1851750045174106083L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4369651011101498713L),

new System.Numerics.BigInteger(1416599815870956628L),

new System.Numerics.BigInteger(7064794402321713777L),

new System.Numerics.BigInteger(3089331050185064828L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6775834077502968640L),

new System.Numerics.BigInteger(4283188103518182619L),

new System.Numerics.BigInteger(7592995910676422825L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3882926403744319418L),

new System.Numerics.BigInteger(8657131161873655432L),

new System.Numerics.BigInteger(7020029964356794941L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(656187194467812145L),

new System.Numerics.BigInteger(2435197030662779232L),

new System.Numerics.BigInteger(24897516925221040L),

new System.Numerics.BigInteger(8985471062271819448L),

},
},
            new BigIntegernumericArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7637973724757577383L),

new System.Numerics.BigInteger(4720608298644655783L),

new System.Numerics.BigInteger(3410268209152010735L),

new System.Numerics.BigInteger(5895442218992687603L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8113837871521153395L),

new System.Numerics.BigInteger(1414268609957399817L),

new System.Numerics.BigInteger(1986476445939432466L),

new System.Numerics.BigInteger(5271909843549103311L),

},
},
            new BigIntegernumericArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5388159244386190276L),

new System.Numerics.BigInteger(2276545213441937109L),

new System.Numerics.BigInteger(4346387777093655863L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5085067432551372968L),

new System.Numerics.BigInteger(949020775405271654L),

new System.Numerics.BigInteger(7971208316143434004L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6410131871329002330L),

new System.Numerics.BigInteger(7208578197850418629L),

new System.Numerics.BigInteger(1631970846136274994L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4850584047350903015L),

new System.Numerics.BigInteger(5356103867977619491L),

new System.Numerics.BigInteger(588908160204777771L),

},
},
            new BigIntegernumericArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5813434666677724120L),

new System.Numerics.BigInteger(7462029153025926896L),

new System.Numerics.BigInteger(7259606413498312947L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7781201708639731360L),

new System.Numerics.BigInteger(9188025586139932253L),

new System.Numerics.BigInteger(1217402204852964102L),

new System.Numerics.BigInteger(6797091912809988336L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(177489943882541117L),

new System.Numerics.BigInteger(1216056314262407292L),

new System.Numerics.BigInteger(6786985130998924073L),

new System.Numerics.BigInteger(3488968575445835329L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1395898447813631596L),

new System.Numerics.BigInteger(5626471889072430622L),

new System.Numerics.BigInteger(2378847308852708129L),

new System.Numerics.BigInteger(222535018842893614L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1480520543977817554L),

new System.Numerics.BigInteger(5797537138664674588L),

new System.Numerics.BigInteger(9067519400217379078L),

new System.Numerics.BigInteger(4063919378820462950L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3218631447744280172L),

new System.Numerics.BigInteger(4074667641383569L),

new System.Numerics.BigInteger(9073066141275197225L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7864917184222093096L),

new System.Numerics.BigInteger(8607298853121916711L),

new System.Numerics.BigInteger(808651241876432244L),

},
},
            new BigIntegernumericArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7690570764865914964L),

new System.Numerics.BigInteger(2089104663468832430L),

new System.Numerics.BigInteger(5954751430028111056L),

new System.Numerics.BigInteger(457416802271199954L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8672724634621336453L),

new System.Numerics.BigInteger(4606326680434449236L),

new System.Numerics.BigInteger(4540972369477625249L),

new System.Numerics.BigInteger(6250058714866276618L),

},
},
            new BigIntegernumericArray2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6964288102419667207L),

new System.Numerics.BigInteger(7948687936426354657L),

new System.Numerics.BigInteger(2819620531215226479L),

new System.Numerics.BigInteger(1903648173146033162L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(283391006468772618L),

new System.Numerics.BigInteger(1024454483171243241L),

new System.Numerics.BigInteger(2165686643075156964L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2291609902819202941L),

new System.Numerics.BigInteger(8275088938423081159L),

new System.Numerics.BigInteger(7134690235327759272L),

new System.Numerics.BigInteger(7396215660365515174L),

},
},
            new BigIntegernumericArray2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7064218594580919140L),

new System.Numerics.BigInteger(8320804266743761513L),

new System.Numerics.BigInteger(7309852802063772028L),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
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

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                List<BigIntegernumericArray2M> models = null;

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray2M> models = null;

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 184;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 183;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 146;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 184;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 183, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 87, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 68, query1, 179, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 10, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 126, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 176, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 148, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 68, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 77, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 179);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
BigIntegernumericArray2M.AssertModel(models[0],_testData[31], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[32], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[33], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
BigIntegernumericArray2M.AssertModel(models[0],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[29], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[30], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[31], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[32], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[33], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray2M),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
FROM public.binary_bigintegernumericarray2m m
LEFT JOIN public.binary_bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI), typeof(BigIntegernumericArray2MI)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MI>();
                var models2 = new List<BigIntegernumericArray2MI>();
                await ((IBigIntegerListnumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MI>();
                var models2 = new List<BigIntegernumericArray2MI>();
                ((IBigIntegerListnumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

