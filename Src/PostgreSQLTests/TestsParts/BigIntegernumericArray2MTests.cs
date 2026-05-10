

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8979550189931904144L),

new System.Numerics.BigInteger(6750304917746141846L),

new System.Numerics.BigInteger(3572527793449168487L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3736023799647310654L),

new System.Numerics.BigInteger(5437035960609797665L),

new System.Numerics.BigInteger(2735101751334703047L),

new System.Numerics.BigInteger(5786733116487177835L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2871525498287432775L),

new System.Numerics.BigInteger(4516303288075595198L),

new System.Numerics.BigInteger(2715661996657667182L),

new System.Numerics.BigInteger(7664397493910303176L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6401188666465863276L),

new System.Numerics.BigInteger(2631771324916426196L),

new System.Numerics.BigInteger(1443551694176957057L),

},
},
            new BigIntegernumericArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1992481500018023277L),

new System.Numerics.BigInteger(5664224936366776994L),

new System.Numerics.BigInteger(995593317219600669L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8800700127432826619L),

new System.Numerics.BigInteger(3616259631395112164L),

new System.Numerics.BigInteger(8580993568363525752L),

new System.Numerics.BigInteger(1453967206988946993L),

},
},
            new BigIntegernumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1448281118018825082L),

new System.Numerics.BigInteger(1086790437696986333L),

new System.Numerics.BigInteger(3138439551047172258L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8104499137223677346L),

new System.Numerics.BigInteger(6480071419000598280L),

new System.Numerics.BigInteger(133584667345992685L),

new System.Numerics.BigInteger(4886105378369125807L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1142690467620154861L),

new System.Numerics.BigInteger(5441349083368921969L),

new System.Numerics.BigInteger(8403920620149006542L),

new System.Numerics.BigInteger(115304078006397853L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1434077789786959815L),

new System.Numerics.BigInteger(3034874787569505422L),

new System.Numerics.BigInteger(6983956797352151620L),

new System.Numerics.BigInteger(4058007061616594041L),

},
},
            new BigIntegernumericArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6979087777100411605L),

new System.Numerics.BigInteger(1511765990571766508L),

new System.Numerics.BigInteger(4680662277992788418L),

new System.Numerics.BigInteger(8074180881050313273L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3972516949497632792L),

new System.Numerics.BigInteger(41004496924291337L),

new System.Numerics.BigInteger(2028271584681649152L),

},
},
            new BigIntegernumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5412544336117171629L),

new System.Numerics.BigInteger(6622062500590410058L),

new System.Numerics.BigInteger(5098946572203836159L),

new System.Numerics.BigInteger(3120424401853867534L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(159123740460368194L),

new System.Numerics.BigInteger(4908200720863221961L),

new System.Numerics.BigInteger(2884241732199141791L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8998060909732175960L),

new System.Numerics.BigInteger(8662895250285696962L),

new System.Numerics.BigInteger(7309783912660234901L),

new System.Numerics.BigInteger(1359535426910499853L),

},
},
            new BigIntegernumericArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7293455278860446616L),

new System.Numerics.BigInteger(1742470656796844716L),

new System.Numerics.BigInteger(1357990314282729414L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7265683220566732528L),

new System.Numerics.BigInteger(2412141965974807186L),

new System.Numerics.BigInteger(8378010221364411279L),

},
},
            new BigIntegernumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5623852111981896144L),

new System.Numerics.BigInteger(4741988390627119070L),

new System.Numerics.BigInteger(2240136538852923968L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3758341964848727379L),

new System.Numerics.BigInteger(8469856886934238389L),

new System.Numerics.BigInteger(2059561417263121630L),

new System.Numerics.BigInteger(7232880380209820918L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2885440536729999476L),

new System.Numerics.BigInteger(6825623616212266244L),

new System.Numerics.BigInteger(4165601876078743770L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8972592156399934226L),

new System.Numerics.BigInteger(1181142380327200682L),

new System.Numerics.BigInteger(5004215775653422546L),

new System.Numerics.BigInteger(1781613367462198000L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6522270711617267197L),

new System.Numerics.BigInteger(4716891630623732715L),

new System.Numerics.BigInteger(6851153847820346610L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3487758815140546268L),

new System.Numerics.BigInteger(8858313265999727902L),

new System.Numerics.BigInteger(8679905678074979119L),

new System.Numerics.BigInteger(7449802772799930202L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8265657061134760618L),

new System.Numerics.BigInteger(7554019320649523750L),

new System.Numerics.BigInteger(6518911340202686783L),

new System.Numerics.BigInteger(2702447936889403821L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6967038593481189114L),

new System.Numerics.BigInteger(8094431313459645608L),

new System.Numerics.BigInteger(6830609462120639156L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4089807602278513556L),

new System.Numerics.BigInteger(1556391778168342041L),

new System.Numerics.BigInteger(5053842368916968740L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4939096627015382661L),

new System.Numerics.BigInteger(2222897974522238396L),

new System.Numerics.BigInteger(498537251506410281L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6688041336006690771L),

new System.Numerics.BigInteger(8756915685246680069L),

new System.Numerics.BigInteger(910484372368698207L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1159679971772844580L),

new System.Numerics.BigInteger(242116305427596312L),

new System.Numerics.BigInteger(906461898459503508L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7267492374413826262L),

new System.Numerics.BigInteger(6119086663828835573L),

new System.Numerics.BigInteger(1101871976368313577L),

},
},
            new BigIntegernumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1248170944093093655L),

new System.Numerics.BigInteger(7351443677943415258L),

new System.Numerics.BigInteger(5408378550869802101L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1387176055906060717L),

new System.Numerics.BigInteger(6866985294976700748L),

new System.Numerics.BigInteger(258917530934709656L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5657822731337105656L),

new System.Numerics.BigInteger(6871166584929926028L),

new System.Numerics.BigInteger(4033409862616977740L),

new System.Numerics.BigInteger(4783973503485555064L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2198564911778583687L),

new System.Numerics.BigInteger(3185074252961195564L),

new System.Numerics.BigInteger(5060700732898993156L),

new System.Numerics.BigInteger(7934530378837535252L),

},
},
            new BigIntegernumericArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1648830885697576691L),

new System.Numerics.BigInteger(3263174599078038066L),

new System.Numerics.BigInteger(2223317242345608680L),

new System.Numerics.BigInteger(6998700537813098503L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1399479887475580769L),

new System.Numerics.BigInteger(2442581025512898067L),

new System.Numerics.BigInteger(6815709552125378322L),

},
},
            new BigIntegernumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5479815859552270677L),

new System.Numerics.BigInteger(2807605831270284316L),

new System.Numerics.BigInteger(1905589799594622988L),

new System.Numerics.BigInteger(6467479087795340250L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7244616483603468138L),

new System.Numerics.BigInteger(8166334950929349375L),

new System.Numerics.BigInteger(2465832328140388350L),

new System.Numerics.BigInteger(6329730907481350720L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2112035899573236372L),

new System.Numerics.BigInteger(5854499744582984146L),

new System.Numerics.BigInteger(7263195542872456451L),

},
},
            new BigIntegernumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3471370745001533410L),

new System.Numerics.BigInteger(7389969243381406340L),

new System.Numerics.BigInteger(5830411786256084211L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7440819251763979611L),

new System.Numerics.BigInteger(7604015240497052140L),

new System.Numerics.BigInteger(7067990203154247328L),

new System.Numerics.BigInteger(6486226640221767066L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7115568252284460794L),

new System.Numerics.BigInteger(2594288168231989428L),

new System.Numerics.BigInteger(8289764785043755060L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9143490242304116251L),

new System.Numerics.BigInteger(1650399363132383006L),

new System.Numerics.BigInteger(3809304914617531849L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8707747164791937636L),

new System.Numerics.BigInteger(8114581298833940893L),

new System.Numerics.BigInteger(7715275975935192480L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6750054040628189039L),

new System.Numerics.BigInteger(7480244660106757793L),

new System.Numerics.BigInteger(2867219977481888183L),

new System.Numerics.BigInteger(6567378053772759569L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7204387205972029833L),

new System.Numerics.BigInteger(680985093774029464L),

new System.Numerics.BigInteger(3849521251981552852L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3902042464245261710L),

new System.Numerics.BigInteger(5438075208218497247L),

new System.Numerics.BigInteger(3225179800632090424L),

},
},
            new BigIntegernumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3511030172827215668L),

new System.Numerics.BigInteger(2430961725769664039L),

new System.Numerics.BigInteger(1603608732992538469L),

new System.Numerics.BigInteger(8170136373590461821L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1216168631213975504L),

new System.Numerics.BigInteger(3521980196289110173L),

new System.Numerics.BigInteger(3769986359180024452L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8549353232090857728L),

new System.Numerics.BigInteger(6017975618386748285L),

new System.Numerics.BigInteger(3710733308612326943L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7999531748115887167L),

new System.Numerics.BigInteger(997669367729735000L),

new System.Numerics.BigInteger(2217274621267103821L),

new System.Numerics.BigInteger(4012120162230293562L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5687571699465263198L),

new System.Numerics.BigInteger(7834215673244455056L),

new System.Numerics.BigInteger(7694640964693211718L),

new System.Numerics.BigInteger(4073708448765832650L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3265343060965782474L),

new System.Numerics.BigInteger(6737631723700989341L),

new System.Numerics.BigInteger(2217387883301487501L),

new System.Numerics.BigInteger(4451054448245420301L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8011721011330329334L),

new System.Numerics.BigInteger(5141566932341840479L),

new System.Numerics.BigInteger(1329045949058627787L),

new System.Numerics.BigInteger(5980774692036924452L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5352022736852190108L),

new System.Numerics.BigInteger(4226902214576899631L),

new System.Numerics.BigInteger(3745531761938706145L),

},
},
            new BigIntegernumericArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4961208956933601524L),

new System.Numerics.BigInteger(2276624853247240530L),

new System.Numerics.BigInteger(2703564459275393738L),

new System.Numerics.BigInteger(1240082312418368363L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(571086377070859559L),

new System.Numerics.BigInteger(6418664939204975202L),

new System.Numerics.BigInteger(5288638315522682950L),

new System.Numerics.BigInteger(5402012155061516382L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7800589265792286712L),

new System.Numerics.BigInteger(6448544595065732200L),

new System.Numerics.BigInteger(9122694118161638778L),

new System.Numerics.BigInteger(9004531973341783224L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5273383950031434497L),

new System.Numerics.BigInteger(5351774646998294263L),

new System.Numerics.BigInteger(4837902404086522295L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2705314467687387016L),

new System.Numerics.BigInteger(6640170516474882929L),

new System.Numerics.BigInteger(2364657300163158530L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6365870140032081203L),

new System.Numerics.BigInteger(2627387232620388581L),

new System.Numerics.BigInteger(1874064291958400430L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6928255726220776401L),

new System.Numerics.BigInteger(5886289530515041789L),

new System.Numerics.BigInteger(1210517690915789227L),

},
},
            new BigIntegernumericArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5544301912097617893L),

new System.Numerics.BigInteger(7314072114009486533L),

new System.Numerics.BigInteger(4348186657461501084L),

new System.Numerics.BigInteger(2010384407405700257L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2089081933292337473L),

new System.Numerics.BigInteger(2965161767543100629L),

new System.Numerics.BigInteger(3353321039606445285L),

},
},
            new BigIntegernumericArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4325507821885815733L),

new System.Numerics.BigInteger(7526713704294681742L),

new System.Numerics.BigInteger(8812307385408935992L),

new System.Numerics.BigInteger(369223647941452925L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1329026805446577328L),

new System.Numerics.BigInteger(6936806123879805440L),

new System.Numerics.BigInteger(2407069967158421719L),

new System.Numerics.BigInteger(7600558903965987730L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(977359311115054196L),

new System.Numerics.BigInteger(6592172864961260779L),

new System.Numerics.BigInteger(6241897967779732220L),

new System.Numerics.BigInteger(4419035177454665907L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4997899767597877339L),

new System.Numerics.BigInteger(1208936883971783645L),

new System.Numerics.BigInteger(3801076362917064256L),

new System.Numerics.BigInteger(6241128587539928083L),

},
},
            new BigIntegernumericArray2M
{
    Id = 197,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8245781317327459782L),

new System.Numerics.BigInteger(173980213123332161L),

new System.Numerics.BigInteger(5384610277910634412L),

new System.Numerics.BigInteger(5223322829215243718L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6217772217371514005L),

new System.Numerics.BigInteger(3368320860296410803L),

new System.Numerics.BigInteger(5262231485627321973L),

new System.Numerics.BigInteger(8951402223103064704L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6788647403346586998L),

new System.Numerics.BigInteger(9216452089837023474L),

new System.Numerics.BigInteger(6066464282112163006L),

new System.Numerics.BigInteger(5519255103609994811L),

},
},
            new BigIntegernumericArray2M
{
    Id = 205,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1279692801584707218L),

new System.Numerics.BigInteger(104518290708118589L),

new System.Numerics.BigInteger(7365051099837112422L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(415759213004790344L),

new System.Numerics.BigInteger(8364038118541132390L),

new System.Numerics.BigInteger(4756832092784017746L),

},
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 89;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 180, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 90, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 171, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 109, query1, 139, query2))
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 53, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 132, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 125, 98))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 125, 34))
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[34], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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

