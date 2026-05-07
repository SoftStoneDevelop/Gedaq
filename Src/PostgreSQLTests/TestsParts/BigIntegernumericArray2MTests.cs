

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6452476800827282622L),

new System.Numerics.BigInteger(6825061729328990218L),

new System.Numerics.BigInteger(7110649431043167813L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1142826681394133249L),

new System.Numerics.BigInteger(4174719162290688460L),

new System.Numerics.BigInteger(7081453834470953113L),

},
},
            new BigIntegernumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9076136056485853915L),

new System.Numerics.BigInteger(403124440122908173L),

new System.Numerics.BigInteger(7056554110900539699L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2513306152864478035L),

new System.Numerics.BigInteger(2321689835046100655L),

new System.Numerics.BigInteger(3606028002374076500L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3312667413424098083L),

new System.Numerics.BigInteger(6404419732284519749L),

new System.Numerics.BigInteger(2645877244447870064L),

new System.Numerics.BigInteger(6447164618701460930L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(182427081051576770L),

new System.Numerics.BigInteger(1784332228745451260L),

new System.Numerics.BigInteger(3583430004035054437L),

new System.Numerics.BigInteger(8323392450324107660L),

},
},
            new BigIntegernumericArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4736908051074103145L),

new System.Numerics.BigInteger(2173760903920133265L),

new System.Numerics.BigInteger(7801175876657057887L),

new System.Numerics.BigInteger(5742260575070811093L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7309904428719889019L),

new System.Numerics.BigInteger(2859158599413866465L),

new System.Numerics.BigInteger(366804084600891286L),

new System.Numerics.BigInteger(7230636636382389427L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2934230632020954214L),

new System.Numerics.BigInteger(6990723733270646559L),

new System.Numerics.BigInteger(598747139822921130L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6699710627663855573L),

new System.Numerics.BigInteger(1197906531550190337L),

new System.Numerics.BigInteger(5882939206693866545L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4152893368135127940L),

new System.Numerics.BigInteger(522832748717821487L),

new System.Numerics.BigInteger(1072394222569416058L),

new System.Numerics.BigInteger(2704745891395657538L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7469519264928079220L),

new System.Numerics.BigInteger(2734362041807133141L),

new System.Numerics.BigInteger(7091636871521444095L),

new System.Numerics.BigInteger(910372388888611335L),

},
},
            new BigIntegernumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2197879475626909942L),

new System.Numerics.BigInteger(9164265963441221082L),

new System.Numerics.BigInteger(3521805383465407704L),

new System.Numerics.BigInteger(8801082304264482386L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4996065142221596222L),

new System.Numerics.BigInteger(2953439658335294459L),

new System.Numerics.BigInteger(4755086399853062603L),

},
},
            new BigIntegernumericArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3247209573287367626L),

new System.Numerics.BigInteger(8973743405602253490L),

new System.Numerics.BigInteger(857858498918925968L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4107602973024749270L),

new System.Numerics.BigInteger(212723672625073857L),

new System.Numerics.BigInteger(7714269290871414967L),

new System.Numerics.BigInteger(8293470673715589229L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6016857522617509720L),

new System.Numerics.BigInteger(1245999033810654922L),

new System.Numerics.BigInteger(6082584078482702350L),

new System.Numerics.BigInteger(7191009526737321376L),

},
},
            new BigIntegernumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1131668434035771546L),

new System.Numerics.BigInteger(7878783362348125446L),

new System.Numerics.BigInteger(100610580855947123L),

new System.Numerics.BigInteger(3077036078220671899L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4783423930585628299L),

new System.Numerics.BigInteger(3355196070020380115L),

new System.Numerics.BigInteger(3290743517012774691L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5713843313018944958L),

new System.Numerics.BigInteger(6240839044227958361L),

new System.Numerics.BigInteger(1846234365377930534L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6776696704065704854L),

new System.Numerics.BigInteger(4567112517952413397L),

new System.Numerics.BigInteger(388263978053179496L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2345552027762497541L),

new System.Numerics.BigInteger(7412040372852675069L),

new System.Numerics.BigInteger(3086848274204577249L),

new System.Numerics.BigInteger(8733392472945618880L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5929038804408757069L),

new System.Numerics.BigInteger(4073882831657222589L),

new System.Numerics.BigInteger(2089203865242952535L),

new System.Numerics.BigInteger(7218200577390401322L),

},
},
            new BigIntegernumericArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1830938200834726654L),

new System.Numerics.BigInteger(798947852271335341L),

new System.Numerics.BigInteger(7061010696658921542L),

new System.Numerics.BigInteger(6772374720558912746L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6333377631511697963L),

new System.Numerics.BigInteger(1873355458874634425L),

new System.Numerics.BigInteger(1452417891832444361L),

new System.Numerics.BigInteger(8831478836459598886L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6600078503072628189L),

new System.Numerics.BigInteger(63419832272397641L),

new System.Numerics.BigInteger(1072352930235831736L),

new System.Numerics.BigInteger(5593177381720653086L),

},
},
            new BigIntegernumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(867617367596826871L),

new System.Numerics.BigInteger(372934255768862755L),

new System.Numerics.BigInteger(8542485457077346900L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6538183057623577552L),

new System.Numerics.BigInteger(8657615051531264635L),

new System.Numerics.BigInteger(4717104492303550028L),

new System.Numerics.BigInteger(13849267057063230L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6089232339061826702L),

new System.Numerics.BigInteger(251936230920288828L),

new System.Numerics.BigInteger(616912006554678535L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6193326879509383392L),

new System.Numerics.BigInteger(6731717384750854677L),

new System.Numerics.BigInteger(6923225050019752192L),

new System.Numerics.BigInteger(1830826079815148114L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5576281412841337372L),

new System.Numerics.BigInteger(5287495393956390933L),

new System.Numerics.BigInteger(2519183437640239207L),

new System.Numerics.BigInteger(5119921690732871366L),

},
},
            new BigIntegernumericArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7949443527872328166L),

new System.Numerics.BigInteger(8830793261797302986L),

new System.Numerics.BigInteger(3654657053909638604L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4014183291173945177L),

new System.Numerics.BigInteger(5554520182130575606L),

new System.Numerics.BigInteger(3625967553764928233L),

new System.Numerics.BigInteger(190830700586390040L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1209607849844422469L),

new System.Numerics.BigInteger(2610094373385550470L),

new System.Numerics.BigInteger(9126324089923682084L),

new System.Numerics.BigInteger(2457480462424067199L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5291638624877544900L),

new System.Numerics.BigInteger(2632356535582711228L),

new System.Numerics.BigInteger(318138780760394780L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4425046751701853780L),

new System.Numerics.BigInteger(8017384213397365329L),

new System.Numerics.BigInteger(5678639415553999253L),

new System.Numerics.BigInteger(2178295447315505853L),

},
},
            new BigIntegernumericArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2662392559015349377L),

new System.Numerics.BigInteger(8221446976851294533L),

new System.Numerics.BigInteger(1625361895221022419L),

new System.Numerics.BigInteger(3979074338238070597L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5729733995129494215L),

new System.Numerics.BigInteger(7769343460645831548L),

new System.Numerics.BigInteger(5171692904638344972L),

new System.Numerics.BigInteger(1870116501371828107L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2284939374614551177L),

new System.Numerics.BigInteger(634944924088145654L),

new System.Numerics.BigInteger(5544633928113230259L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8119821142632861569L),

new System.Numerics.BigInteger(1324234305881897490L),

new System.Numerics.BigInteger(8985533469269970103L),

new System.Numerics.BigInteger(7718739825128981964L),

},
},
            new BigIntegernumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3370643828753353979L),

new System.Numerics.BigInteger(2736324671601588865L),

new System.Numerics.BigInteger(3097215969420769351L),

new System.Numerics.BigInteger(723233689048054734L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8453839152785058722L),

new System.Numerics.BigInteger(7359560885548136959L),

new System.Numerics.BigInteger(9011360718653504955L),

new System.Numerics.BigInteger(7705635144939368507L),

},
},
            new BigIntegernumericArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7771769369103376205L),

new System.Numerics.BigInteger(7789952588623754001L),

new System.Numerics.BigInteger(8404920441404397911L),

new System.Numerics.BigInteger(3447355927628200870L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9085662089764094588L),

new System.Numerics.BigInteger(3343334513041435987L),

new System.Numerics.BigInteger(8759771143759681953L),

new System.Numerics.BigInteger(3369897904531473139L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2259941148749491379L),

new System.Numerics.BigInteger(8041651292013168881L),

new System.Numerics.BigInteger(5553101700279886119L),

new System.Numerics.BigInteger(863613311346106745L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4832598249007348823L),

new System.Numerics.BigInteger(3572286493166411846L),

new System.Numerics.BigInteger(5427739768683682731L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7351150635844542226L),

new System.Numerics.BigInteger(6197547257805800192L),

new System.Numerics.BigInteger(5425317023322830985L),

new System.Numerics.BigInteger(1818508331598712413L),

},
},
            new BigIntegernumericArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7472025537294992628L),

new System.Numerics.BigInteger(5755063264098880435L),

new System.Numerics.BigInteger(5521630414780416654L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5207165427682557422L),

new System.Numerics.BigInteger(8372756912184780742L),

new System.Numerics.BigInteger(3855655253886349781L),

new System.Numerics.BigInteger(4795535944515245677L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139020642192835023L),

new System.Numerics.BigInteger(5876108432952866278L),

new System.Numerics.BigInteger(234880614894688312L),

new System.Numerics.BigInteger(7074582559560245485L),

},
},
            new BigIntegernumericArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1390752819197900401L),

new System.Numerics.BigInteger(2556366768567857808L),

new System.Numerics.BigInteger(379001955660008645L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4035995787655674662L),

new System.Numerics.BigInteger(1122569369537691923L),

new System.Numerics.BigInteger(6053361184103776353L),

new System.Numerics.BigInteger(6040398305669787726L),

},
},
            new BigIntegernumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(31094007646541365L),

new System.Numerics.BigInteger(3818279647735128135L),

new System.Numerics.BigInteger(8800831093992641378L),

new System.Numerics.BigInteger(5438806077430321381L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8182426068286878970L),

new System.Numerics.BigInteger(4976479810778283681L),

new System.Numerics.BigInteger(5985612415067800054L),

new System.Numerics.BigInteger(5361519517513337884L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3382590229145677494L),

new System.Numerics.BigInteger(6265750874651492053L),

new System.Numerics.BigInteger(7167656953466561115L),

new System.Numerics.BigInteger(3180279934635211889L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7526165527418003823L),

new System.Numerics.BigInteger(4065096874294750562L),

new System.Numerics.BigInteger(8909414903641322568L),

new System.Numerics.BigInteger(1735927276810751288L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2807073264459111898L),

new System.Numerics.BigInteger(8746848390898018812L),

new System.Numerics.BigInteger(929873954769431427L),

new System.Numerics.BigInteger(5489475841552087870L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(118552638797085589L),

new System.Numerics.BigInteger(2736369686260919898L),

new System.Numerics.BigInteger(4876591708041917934L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4964330713083888194L),

new System.Numerics.BigInteger(3102845202517188056L),

new System.Numerics.BigInteger(7935719858721506606L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4582752370004076809L),

new System.Numerics.BigInteger(7797503728532153027L),

new System.Numerics.BigInteger(2726360475759278708L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4649226135069963652L),

new System.Numerics.BigInteger(2671823755889931164L),

new System.Numerics.BigInteger(5099460454306649680L),

new System.Numerics.BigInteger(1874389860212575866L),

},
},
            new BigIntegernumericArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2920451733445081172L),

new System.Numerics.BigInteger(345922328274436945L),

new System.Numerics.BigInteger(10728545301834362L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8428491602369679263L),

new System.Numerics.BigInteger(3612523815732167834L),

new System.Numerics.BigInteger(3526521443318019400L),

new System.Numerics.BigInteger(7456651487719816651L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4087186746842165077L),

new System.Numerics.BigInteger(6983614753665331720L),

new System.Numerics.BigInteger(775467374923153176L),

new System.Numerics.BigInteger(6190230066448343597L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6139928345559471924L),

new System.Numerics.BigInteger(5768554513477954488L),

new System.Numerics.BigInteger(8079121213756708055L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8932978351343753795L),

new System.Numerics.BigInteger(8076307446026438748L),

new System.Numerics.BigInteger(2851985028440803310L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8244403060132582400L),

new System.Numerics.BigInteger(2514836906996293278L),

new System.Numerics.BigInteger(1817166753565850120L),

new System.Numerics.BigInteger(7369631813803420805L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7283062751476633330L),

new System.Numerics.BigInteger(2185948566332831026L),

new System.Numerics.BigInteger(8943831550807205464L),

new System.Numerics.BigInteger(8200549950907338365L),

},
},
            new BigIntegernumericArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5327937768703003390L),

new System.Numerics.BigInteger(4476484481764528932L),

new System.Numerics.BigInteger(3954184947754717691L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2646365906473752287L),

new System.Numerics.BigInteger(5632637281107757179L),

new System.Numerics.BigInteger(5560648877810264555L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2316063643332354666L),

new System.Numerics.BigInteger(7843928968760989448L),

new System.Numerics.BigInteger(6521057768682083764L),

new System.Numerics.BigInteger(149033754748145727L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2246639803884348241L),

new System.Numerics.BigInteger(6617469938353306592L),

new System.Numerics.BigInteger(4877773532934512980L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1812045311024451792L),

new System.Numerics.BigInteger(666027211640614003L),

new System.Numerics.BigInteger(6234123487775073517L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(498265940854073522L),

new System.Numerics.BigInteger(5763899220857968437L),

new System.Numerics.BigInteger(4631174549881156758L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3011250226674090018L),

new System.Numerics.BigInteger(724935707819316818L),

new System.Numerics.BigInteger(8445306211200394864L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5711197756151884426L),

new System.Numerics.BigInteger(1747953900495885408L),

new System.Numerics.BigInteger(8369348536748199025L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 194,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4646654776408315469L),

new System.Numerics.BigInteger(7078610532129670624L),

new System.Numerics.BigInteger(3977293627918554303L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8466985346989025859L),

new System.Numerics.BigInteger(8289150919266947876L),

new System.Numerics.BigInteger(4905352764258285271L),

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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
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
                parametr1.Value = 178;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 60;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[34], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 178;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 178, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[33],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 134, query1, 46, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 60, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 65, 125))
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[34], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 166);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[34], false);
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

