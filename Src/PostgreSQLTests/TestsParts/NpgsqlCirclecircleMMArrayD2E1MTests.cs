

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
    internal partial interface INpgsqlCircleMArraycircleMMArrayD2
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMMArrayD2 : INpgsqlCircleMArraycircleMMArrayD2
    {


#region TestData

        private readonly NpgsqlCirclecircleMMArrayD2E1M[] _testData = new NpgsqlCirclecircleMMArrayD2E1M[]
        {
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9993933863083893d, y: 0.4786102889910564d), radius: 0.6524412430485553d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3405484768403504d, y: 0.12693021264227689d), radius: 0.8250297453838564d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27625742988528d, y: 0.4713871625727952d), radius: 0.548815881736735d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15544637723619714d, y: 0.6075230396053486d), radius: 0.5033728956109523d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3397477835265801d, y: 0.3277951003245887d), radius: 0.19913475204936715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2974663371833538d, y: 0.6561771345806923d), radius: 0.7615677582066215d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5808156498149281d, y: 0.006043125489385348d), radius: 0.941859165662853d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.701126849689833d, y: 0.5475115825319087d), radius: 0.2610976975932512d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8070869863672521d, y: 0.07972460558808714d), radius: 0.09631745077585807d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025488604712086915d, y: 0.3705091813818976d), radius: 0.30690696433609954d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7160352836464047d, y: 0.9145881033952948d), radius: 0.3761214220467084d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34881549792867395d, y: 0.7072241557572093d), radius: 0.4784633590111781d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11521206670096718d, y: 0.4989962016919196d), radius: 0.7649225261982338d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8597515721834956d, y: 0.018582940919083857d), radius: 0.8171356048081447d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7002200181797056d, y: 0.11399032316962576d), radius: 0.9744584486452154d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.939894071006079d, y: 0.7244835420244033d), radius: 0.81027850143249d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0880052446625148d, y: 0.15549171734074718d), radius: 0.7156986862553513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5102352488020239d, y: 0.012244724058823153d), radius: 0.4729525206692127d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5777724045322578d, y: 0.13096167886349153d), radius: 0.49367767826996023d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01702644330885983d, y: 0.14293830407033115d), radius: 0.6303637400527713d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10009113578310269d, y: 0.7337005148602581d), radius: 0.3950162946367183d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3450373204310877d, y: 0.5084455142108295d), radius: 0.7113025817550517d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6323855592569466d, y: 0.09624371988770941d), radius: 0.8093884360825815d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3058483101575472d, y: 0.21463988464374206d), radius: 0.5590496971387204d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41749086909018485d, y: 0.928875289770234d), radius: 0.9302961294022992d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9528918007184979d, y: 0.4436643583442941d), radius: 0.2841716819175325d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7774778646339551d, y: 0.3531310927608461d), radius: 0.6902247191287845d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4784985640510092d, y: 0.22673044325337943d), radius: 0.6454965115098292d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5642619622682792d, y: 0.47215225547268536d), radius: 0.2164508138807718d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8820211808666883d, y: 0.6531108200419554d), radius: 0.5895261658426147d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.563993148865169d, y: 0.5809271061695297d), radius: 0.44774928478355136d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5346272614506674d, y: 0.488824571708953d), radius: 0.14449482002663283d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07486296113146007d, y: 0.8360946681683439d), radius: 0.1191463265914946d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9952382875869585d, y: 0.37618752771847996d), radius: 0.868946605495954d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9908074566912108d, y: 0.9826047277128818d), radius: 0.8091572773676419d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03278177484554823d, y: 0.9699435124992826d), radius: 0.29005908846516504d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649140528234396d, y: 0.18579290134897464d), radius: 0.3344035997754443d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9011956797310102d, y: 0.6958332156977435d), radius: 0.004301337852900766d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.602438346495525d, y: 0.26548233802375676d), radius: 0.5547799427294873d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8819626767853174d, y: 0.2258292704905993d), radius: 0.10768750187395137d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7055895997645322d, y: 0.5178496678527209d), radius: 0.7669028334147907d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3126430028088152d, y: 0.2726904135684377d), radius: 0.8231433290452533d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9525808326186254d, y: 0.5645363149590451d), radius: 0.13684152415319473d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7379702806660394d, y: 0.7220747302230931d), radius: 0.8382242261723053d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04152281764582666d, y: 0.6304913051263981d), radius: 0.327226075082398d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5570681370477049d, y: 0.27780162212352766d), radius: 0.5794882099001754d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2715492067636276d, y: 0.9993255968045041d), radius: 0.06734196684510607d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.911429821824249d, y: 0.15375472460755235d), radius: 0.5303291934532678d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08272314987334484d, y: 0.49092468693500524d), radius: 0.9954146455526621d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3265954555707019d, y: 0.9499949875091835d), radius: 0.3726523175973714d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38413416546867896d, y: 0.026123279824759482d), radius: 0.03774919853621106d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33624336120808695d, y: 0.7869912567651065d), radius: 0.820352244531932d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5561208347901263d, y: 0.8390087707958316d), radius: 0.8082214736813059d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2921491570591963d, y: 0.033531679557044614d), radius: 0.8674336931979365d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7939364579689179d, y: 0.7085228079477484d), radius: 0.38107829179067054d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7089787214989113d, y: 0.6680331944433207d), radius: 0.20459364445869177d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9475598939953696d, y: 0.9933210932986457d), radius: 0.14039790306039324d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8681159276419539d, y: 0.005004522719462168d), radius: 0.2931216621462518d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0367146733565481d, y: 0.024885458280863526d), radius: 0.33167964660068616d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23268581663780397d, y: 0.27042973750086197d), radius: 0.5617997833421497d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22177210613448872d, y: 0.4106138791273346d), radius: 0.7099786280385619d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18906244731421018d, y: 0.6075601678171063d), radius: 0.2879153633657029d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17186871103431245d, y: 0.18316026007013753d), radius: 0.032574012491039084d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6721733727921638d, y: 0.942703257120048d), radius: 0.2642085703215996d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5619126801317906d, y: 0.5198085135261852d), radius: 0.49710808990418054d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9716529293169934d, y: 0.43895491742163106d), radius: 0.4558593029867859d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6727532597509776d, y: 0.027707986732137813d), radius: 0.42053973832543345d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8115351549373977d, y: 0.8432937472742884d), radius: 0.18516329482225224d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9247458169726094d, y: 0.3194649789907801d), radius: 0.01955732035450297d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9100730149794345d, y: 0.7881774876793047d), radius: 0.06282304625132873d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37780384024323743d, y: 0.055583824993808095d), radius: 0.5284925769541152d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.039210960498945235d, y: 0.2960041739271083d), radius: 0.6382301628799903d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9651641523249065d, y: 0.45255902879802445d), radius: 0.7626077059228524d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19753957060341965d, y: 0.5868683031933892d), radius: 0.15875261528873186d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004744045356072202d, y: 0.45480359742933807d), radius: 0.8497626180417062d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.505550481694228d, y: 0.4648297741252517d), radius: 0.998566380346845d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10160790596654701d, y: 0.6417206084747702d), radius: 0.48034761890792155d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4221296928529136d, y: 0.7689019791573267d), radius: 0.9429221864966597d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5881093316734792d, y: 0.3850221556912651d), radius: 0.5117702261554433d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49311909449593305d, y: 0.04944841228276009d), radius: 0.09592240901752558d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7315720076774239d, y: 0.20395593773102416d), radius: 0.16475376858746327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3406954205651912d, y: 0.24074005032810908d), radius: 0.9045592569664346d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7298904063538311d, y: 0.09385436428810223d), radius: 0.3179408268881375d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6255414708359801d, y: 0.7622716692837168d), radius: 0.43326199080992767d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3115493192299478d, y: 0.18131977451771486d), radius: 0.3101046391892154d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10296007862810386d, y: 0.6731943742678596d), radius: 0.7488078192725833d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15936070897300136d, y: 0.074253946386858d), radius: 0.22195198902902746d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10310647706208631d, y: 0.7326135338058489d), radius: 0.2634395901717763d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02408693295340769d, y: 0.04665077498768433d), radius: 0.5825813355939901d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36367203198577525d, y: 0.5629091115523662d), radius: 0.3726884951665054d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4759152934408175d, y: 0.9384020783831885d), radius: 0.669918383509063d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04748611543865233d, y: 0.018367592650546327d), radius: 0.13297534254087096d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6586247449261171d, y: 0.11746010780300875d), radius: 0.4045925672776288d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.749613978442899d, y: 0.847950859370002d), radius: 0.48716794764903437d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6806401691538941d, y: 0.6242991567799213d), radius: 0.04393399661887798d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6313824798901183d, y: 0.7101129602752552d), radius: 0.9321619268125709d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8255651942742661d, y: 0.024893020813033795d), radius: 0.9703008317268761d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7268689008834517d, y: 0.6628244855865676d), radius: 0.7050616345868436d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15140855463289193d, y: 0.24967162108882301d), radius: 0.1498559580892257d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5247820504896192d, y: 0.11975794918692961d), radius: 0.931987396425839d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25563829272451244d, y: 0.8716478572710517d), radius: 0.7650225298157397d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22837947054803265d, y: 0.1421932293135323d), radius: 0.0015943906621663784d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35390637438517825d, y: 0.3538357289497027d), radius: 0.29554239944905214d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5663060057488095d, y: 0.8532275697173523d), radius: 0.9181831324791373d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14974643595922987d, y: 0.4061707671759983d), radius: 0.7618816829456406d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27709025040065394d, y: 0.5924620487554765d), radius: 0.41130552043392465d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5502461693402015d, y: 0.3614150747263857d), radius: 0.8573954859664712d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.052841141133067704d, y: 0.9947366113358397d), radius: 0.5131754581668706d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7415311868374919d, y: 0.909368019492305d), radius: 0.9326316870318841d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7075557030402232d, y: 0.9920405226546084d), radius: 0.43685498926445754d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7110896020451573d, y: 0.7561996344356567d), radius: 0.47119685205763906d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4929562385989825d, y: 0.5779267318580801d), radius: 0.9671733765045433d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8434219311944494d, y: 0.7107027362042123d), radius: 0.4068742679321593d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9381668517602432d, y: 0.8379290993432678d), radius: 0.036942048302421204d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9129844376241674d, y: 0.14226379073853013d), radius: 0.30898507099234707d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45358645494607375d, y: 0.17554834689547516d), radius: 0.9209446152998122d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3540748705801603d, y: 0.40744974660923305d), radius: 0.7281363326636745d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8430921716897228d, y: 0.6449886857911401d), radius: 0.40883853699093675d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34004900627599544d, y: 0.2644322436565284d), radius: 0.7800235258471798d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058948330174340535d, y: 0.1659635180539656d), radius: 0.09851099876788283d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11597529196450229d, y: 0.22722175365092778d), radius: 0.18223363173350815d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8558420958372627d, y: 0.08215656607174249d), radius: 0.005930756142726201d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29733739125569947d, y: 0.03579885892574164d), radius: 0.7789611505657069d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41394379412766935d, y: 0.5327901188271097d), radius: 0.3174611905435152d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6754228121978666d, y: 0.9905508234501086d), radius: 0.5761706456580186d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32383831697590526d, y: 0.9121816671791378d), radius: 0.8807090546304103d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3857436707548604d, y: 0.12426027386237959d), radius: 0.27592546046885713d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37831549732699465d, y: 0.3335149044451736d), radius: 0.517938464476223d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2477509523271596d, y: 0.24305476483088073d), radius: 0.625412158141339d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5654850636688025d, y: 0.4647620301904052d), radius: 0.5802636769464272d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14333112462663578d, y: 0.3714668630639356d), radius: 0.42788601770049206d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48746464218689256d, y: 0.028465715625477506d), radius: 0.6312218247805648d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2783831659309891d, y: 0.8489762651548395d), radius: 0.15930181905272855d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32199210928199495d, y: 0.21162048863771643d), radius: 0.9324286504202212d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1692820668348941d, y: 0.6196195432846955d), radius: 0.5033093449694399d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.339208068813763d, y: 0.47256187363222024d), radius: 0.39603819315442856d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3040694489138751d, y: 0.07204180863881937d), radius: 0.21364602802773214d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8751283690383158d, y: 0.623869170813967d), radius: 0.35556247173666145d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16514964152155054d, y: 0.33367772207666246d), radius: 0.19416731614820382d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0038981877892928507d, y: 0.6931680776285505d), radius: 0.731335528618364d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5596696155771237d, y: 0.5915199399235787d), radius: 0.9461721736276882d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6264276026708864d, y: 0.360158857521629d), radius: 0.14584542314474158d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4118189571477672d, y: 0.9772577800992143d), radius: 0.2135665051078508d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.308526998989061d, y: 0.7914787099879858d), radius: 0.1450254831463922d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2631247340536924d, y: 0.6252216728902675d), radius: 0.08333784464707716d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7749733820587533d, y: 0.8337761990850514d), radius: 0.6108245951401626d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29002014391011544d, y: 0.46476109776798125d), radius: 0.9934001558620037d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16573031096638535d, y: 0.3113268201230782d), radius: 0.9236027523528479d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9976232519698753d, y: 0.5470027581510379d), radius: 0.35042449028483025d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7063380423240286d, y: 0.577405499354299d), radius: 0.5574387676836848d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1301774318750727d, y: 0.7082379642759883d), radius: 0.8909800711802985d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37093745565739533d, y: 0.21693594671981387d), radius: 0.3393427074596459d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6947622738631007d, y: 0.8253185728210625d), radius: 0.48225652773413397d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9360675744665191d, y: 0.2902025953986016d), radius: 0.0024624579804588542d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1812842545428569d, y: 0.4288095745730406d), radius: 0.11727255514425938d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7925401398144878d, y: 0.22317403262175817d), radius: 0.24447501572383679d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4085728892674342d, y: 0.573526422188232d), radius: 0.40768542000899d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6848503933182288d, y: 0.9853263636819045d), radius: 0.7282379786795125d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8206732597372893d, y: 0.46484142716581567d), radius: 0.07822903418051064d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5569813847089035d, y: 0.4003882422809628d), radius: 0.8003533663413626d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0060541892270078446d, y: 0.9773627455682572d), radius: 0.777011692386431d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46974119712471485d, y: 0.6838496191655054d), radius: 0.49620659218925045d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00906117730667233d, y: 0.4719815859193863d), radius: 0.4563121964234178d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6250076861209002d, y: 0.8876207220976341d), radius: 0.9047347232380883d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6572822596563273d, y: 0.6617516516254676d), radius: 0.24937664711526497d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5762877379177394d, y: 0.5153140493203356d), radius: 0.6306186623208798d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8097627552778193d, y: 0.47886341076675953d), radius: 0.04602493704277477d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31494945080953496d, y: 0.03897718904272518d), radius: 0.6607694240288645d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3441656909956774d, y: 0.9733451641452932d), radius: 0.8417947693375685d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04721428444402176d, y: 0.17353010048764939d), radius: 0.4138835976793166d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27429085248592133d, y: 0.7881351492141352d), radius: 0.7389747646068768d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7027199727000453d, y: 0.6953200151642678d), radius: 0.6643975221055105d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4150050793544662d, y: 0.21595093230935125d), radius: 0.9234443324938194d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.747574603673882d, y: 0.523575014467312d), radius: 0.09714754781694412d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.785750105079034d, y: 0.7797820735534896d), radius: 0.829302613412208d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.598436728647179d, y: 0.9243670547375017d), radius: 0.9983569349767479d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9756408039193519d, y: 0.50360328655947d), radius: 0.31286865257350516d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5501511098997975d, y: 0.6031038718874d), radius: 0.14680811961775397d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9332119273662391d, y: 0.27349993477102263d), radius: 0.9468674377717745d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4327795604219169d, y: 0.24717536825492115d), radius: 0.3323872934131643d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2396169164346197d, y: 0.02806011207306669d), radius: 0.9586905228795104d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13202689804055545d, y: 0.028908568827672676d), radius: 0.7234523618566172d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49523854523420985d, y: 0.7364876427990186d), radius: 0.46044798318169267d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08380298590961588d, y: 0.9039941926848333d), radius: 0.4128149727495679d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10666116668352066d, y: 0.5630619245358487d), radius: 0.5397647086654713d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.825371211245924d, y: 0.5331924769836607d), radius: 0.4347031245221612d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13196406615041512d, y: 0.8298748498081844d), radius: 0.6318627612922657d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7335591776160402d, y: 0.26381919826272593d), radius: 0.886563953774432d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5564211501742923d, y: 0.18466937124433458d), radius: 0.47203708904846187d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3144942953028941d, y: 0.6495383193789482d), radius: 0.8834275623741179d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1017444287010344d, y: 0.4434650717295009d), radius: 0.14700097495884124d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27756364161683644d, y: 0.6939252407760984d), radius: 0.05165868831805487d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02248513939574437d, y: 0.019857488137614565d), radius: 0.9876401447078617d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.039559652793171196d, y: 0.8207281089774928d), radius: 0.04749642948845989d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05557924261171854d, y: 0.30282732969210746d), radius: 0.7007025270475753d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05174751779499154d, y: 0.8264010357246432d), radius: 0.15921922297830127d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.311761568512142d, y: 0.3529336911505814d), radius: 0.12768936586607516d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4264590788497855d, y: 0.10987405525807892d), radius: 0.23970186461105525d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.751775244478792d, y: 0.5580329885390805d), radius: 0.949387332845143d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686657425177342d, y: 0.8377531248130833d), radius: 0.6759256855387237d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9780873585786559d, y: 0.20086170837994077d), radius: 0.18046305076225244d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19708686289680133d, y: 0.37043249940113965d), radius: 0.2379605368418305d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8888086339449455d, y: 0.7254041223571183d), radius: 0.5928608428048142d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6418513993743162d, y: 0.9195798778661397d), radius: 0.7234408790388153d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8183857765132009d, y: 0.8009213060181896d), radius: 0.2563845896073127d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8149775861240197d, y: 0.49158650436736373d), radius: 0.16653854743906016d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4786310358531971d, y: 0.6583227117210985d), radius: 0.4157870468851588d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20757526990094677d, y: 0.23661904199120998d), radius: 0.8958065678350958d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404877766150409d, y: 0.6008639371295793d), radius: 0.9570400002662317d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.559252984308913d, y: 0.5661903015576633d), radius: 0.5523386443725257d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3598689935010211d, y: 0.5086274084392212d), radius: 0.4770019572075824d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3285876744447961d, y: 0.06844531586336666d), radius: 0.9821111828678742d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7982039286005361d, y: 0.052919462936816375d), radius: 0.9762331189529864d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5120296490047774d, y: 0.3319846580387351d), radius: 0.8046466171783387d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5835875658008141d, y: 0.0854368645887622d), radius: 0.29790356870445056d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6918813185562652d, y: 0.9056432883423376d), radius: 0.11296882302893108d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9709800756371085d, y: 0.7223058433597946d), radius: 0.22271379419102133d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6269869028577496d, y: 0.42020779716749357d), radius: 0.214162698229172d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3500591834425535d, y: 0.9725052601549827d), radius: 0.29053092089624977d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3394572928649754d, y: 0.10850960153312306d), radius: 0.5088052576543658d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13186535834307755d, y: 0.9926283726441182d), radius: 0.2635518007231198d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6627633060345857d, y: 0.47695090243699245d), radius: 0.3551528920496694d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03609430633090782d, y: 0.14210567293287524d), radius: 0.9446709773265846d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19925200464489778d, y: 0.2194473487521602d), radius: 0.4539780287024069d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5843629169502329d, y: 0.4881474490240273d), radius: 0.9698778055600389d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9523635400533984d, y: 0.8387753647838975d), radius: 0.12013279491230644d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5795889525788043d, y: 0.9498864790108287d), radius: 0.8886888970234902d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8802022585250217d, y: 0.3931316315754998d), radius: 0.4510324244652596d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6646835444332934d, y: 0.565332253999709d), radius: 0.5761113381334634d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.059536295944841666d, y: 0.5667758191523776d), radius: 0.8868165337087692d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6953123787517196d, y: 0.38800881526875686d), radius: 0.8700318121673755d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5020624113197145d, y: 0.455853006512686d), radius: 0.7077340287223223d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7501346733716261d, y: 0.7697904431374387d), radius: 0.02124142652126748d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17648226734862982d, y: 0.3418156233676246d), radius: 0.9738435050329471d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5273092491427853d, y: 0.5513364343051337d), radius: 0.31906520009969264d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8646960780212299d, y: 0.03140790682897432d), radius: 0.4916731957813081d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9744520486605154d, y: 0.04130092375173222d), radius: 0.9510579244850911d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9706017808591164d, y: 0.12727580632914381d), radius: 0.20108742928947476d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.830358588790736d, y: 0.5786823581122191d), radius: 0.7152903283047338d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45360342539222676d, y: 0.6143481694386218d), radius: 0.8669400426456226d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6775275238012592d, y: 0.47902273465197054d), radius: 0.8867420724334965d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9910854735373945d, y: 0.5780028100006938d), radius: 0.5141203845269097d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5293687361756715d, y: 0.2758496531937825d), radius: 0.8400907167121449d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33767315280181864d, y: 0.7723935343360849d), radius: 0.5766094061374052d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2724490757190371d, y: 0.8409575693488133d), radius: 0.4304688593477217d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26769936103184333d, y: 0.5579469039803009d), radius: 0.1667468320013692d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3163126389431027d, y: 0.9766813190744661d), radius: 0.32034847593508975d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6474146418307662d, y: 0.13353638109810317d), radius: 0.41757318290802203d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9119481436790235d, y: 0.3796629054122578d), radius: 0.30053470375548286d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6030606889591124d, y: 0.0883094090170663d), radius: 0.6412491203846257d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32080484937375886d, y: 0.6529509731646742d), radius: 0.2753849282165629d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9729026869349805d, y: 0.9243990836136814d), radius: 0.8306964144398526d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.676513995265777d, y: 0.9619538453401467d), radius: 0.19821678800737275d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4019630814419941d, y: 0.09735379047808457d), radius: 0.5740648781927378d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7884741705886289d, y: 0.2002043579005619d), radius: 0.2745598510629126d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8879756295565048d, y: 0.4302099444766614d), radius: 0.5426527037101998d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2328823623132723d, y: 0.060252276901389235d), radius: 0.8369226101571606d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39296735648542347d, y: 0.8803963691246035d), radius: 0.2709625315543063d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8520777878870017d, y: 0.4887969652646895d), radius: 0.4798835971120302d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6072365101986402d, y: 0.6233758279431256d), radius: 0.6887357401193451d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6680319279189136d, y: 0.08690884695925993d), radius: 0.11753643996479313d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7678551248201984d, y: 0.4630551225079319d), radius: 0.15269447980925366d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18004664336494358d, y: 0.8228022619743603d), radius: 0.964098156815205d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6950734629940146d, y: 0.10436162395054382d), radius: 0.9101035178722876d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33147579044643993d, y: 0.24424549644665194d), radius: 0.5717603027558382d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13696264126262392d, y: 0.3159025663653082d), radius: 0.5615471687744629d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.391975678064199d, y: 0.9394098265738849d), radius: 0.7157757492925534d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8065494837078309d, y: 0.2852492626838986d), radius: 0.1136173259139025d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.64665752750802d, y: 0.1622775999495012d), radius: 0.9947119738232018d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2535988733683441d, y: 0.9022667373597663d), radius: 0.033379438420174656d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2985626192905445d, y: 0.9481734727348212d), radius: 0.30709394863292516d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6225611515285779d, y: 0.13788187960504528d), radius: 0.5823153748526241d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2923830263580284d, y: 0.9550121959742934d), radius: 0.4177797630366483d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.480209641474561d, y: 0.6773635650816395d), radius: 0.43629177456758284d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7045527333826129d, y: 0.7649199660967054d), radius: 0.9881891260410067d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2966406352516179d, y: 0.938279586006491d), radius: 0.5626196279936594d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.545273169942749d, y: 0.6783143542693708d), radius: 0.4070648748496086d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10256991545261251d, y: 0.22013561346904564d), radius: 0.7253540347319786d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7249289930962624d, y: 0.24143334148505746d), radius: 0.3904868507742809d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04096389972676728d, y: 0.4475188722934993d), radius: 0.8309602032227983d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4277432302617158d, y: 0.6619402978014463d), radius: 0.40678439439199676d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3713203914307497d, y: 0.4564944494414739d), radius: 0.23160873047606256d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2618478280648263d, y: 0.7666931284787115d), radius: 0.8682258557935261d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31370562379953226d, y: 0.24706006071014375d), radius: 0.5991935433109999d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6010037000631062d, y: 0.355127111842072d), radius: 0.45388982094655705d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4644822364266856d, y: 0.6871336679160607d), radius: 0.8313579026068217d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7699663614797675d, y: 0.798273824249167d), radius: 0.6938191032841216d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2070958095338027d, y: 0.8027462239816565d), radius: 0.7783966392837791d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6161358223606147d, y: 0.06349273619546358d), radius: 0.5450474182864267d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.768170412367633d, y: 0.5638897410029439d), radius: 0.7992954336871024d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2027462685134802d, y: 0.9004574323772578d), radius: 0.753201203381378d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.571538700972126d, y: 0.7795429738382729d), radius: 0.8826521446121307d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8103745680537412d, y: 0.6283724763994946d), radius: 0.8440056281060959d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30459594002740253d, y: 0.0698062597793302d), radius: 0.21725822770149317d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9061086037333124d, y: 0.9567914899808423d), radius: 0.5187440432416621d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1454976354622597d, y: 0.7834212031110074d), radius: 0.7355359829146751d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.587046409301762d, y: 0.44115172970386585d), radius: 0.11547771790047356d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4123725213807721d, y: 0.17236683992078694d), radius: 0.7313449599917313d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6096372781522312d, y: 0.0029362653583386855d), radius: 0.5916558817850265d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6107506281778153d, y: 0.5364825524740359d), radius: 0.08999623733055173d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 190,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8854655915008953d, y: 0.12687332456212186d), radius: 0.3327408092853903d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9789957306929503d, y: 0.6643807094929473d), radius: 0.5593245327772762d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19825056386892692d, y: 0.9725578191522333d), radius: 0.33800609465125486d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7631042107647134d, y: 0.6314227313916057d), radius: 0.9139844612981445d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649140528234396d, y: 0.18579290134897464d), radius: 0.3344035997754443d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9011956797310102d, y: 0.6958332156977435d), radius: 0.004301337852900766d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.602438346495525d, y: 0.26548233802375676d), radius: 0.5547799427294873d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8819626767853174d, y: 0.2258292704905993d), radius: 0.10768750187395137d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5619126801317906d, y: 0.5198085135261852d), radius: 0.49710808990418054d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9716529293169934d, y: 0.43895491742163106d), radius: 0.4558593029867859d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6727532597509776d, y: 0.027707986732137813d), radius: 0.42053973832543345d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8115351549373977d, y: 0.8432937472742884d), radius: 0.18516329482225224d), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9651641523249065d, y: 0.45255902879802445d), radius: 0.7626077059228524d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19753957060341965d, y: 0.5868683031933892d), radius: 0.15875261528873186d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004744045356072202d, y: 0.45480359742933807d), radius: 0.8497626180417062d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.505550481694228d, y: 0.4648297741252517d), radius: 0.998566380346845d), }, }));
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6586247449261171d, y: 0.11746010780300875d), radius: 0.4045925672776288d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.749613978442899d, y: 0.847950859370002d), radius: 0.48716794764903437d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6806401691538941d, y: 0.6242991567799213d), radius: 0.04393399661887798d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6313824798901183d, y: 0.7101129602752552d), radius: 0.9321619268125709d), }, }));
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14974643595922987d, y: 0.4061707671759983d), radius: 0.7618816829456406d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27709025040065394d, y: 0.5924620487554765d), radius: 0.41130552043392465d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5502461693402015d, y: 0.3614150747263857d), radius: 0.8573954859664712d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.052841141133067704d, y: 0.9947366113358397d), radius: 0.5131754581668706d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD2E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD2E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 85, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 102, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 128, query1, 145, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 62, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 145, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 180))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 27, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI), typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

