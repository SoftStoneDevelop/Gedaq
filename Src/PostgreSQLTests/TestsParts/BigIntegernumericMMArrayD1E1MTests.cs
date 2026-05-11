

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
    internal partial interface IBigIntegerMArraynumericMMArrayD1
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD1 : IBigIntegerMArraynumericMMArrayD1
    {


#region TestData

        private readonly BigIntegernumericMMArrayD1E1M[] _testData = new BigIntegernumericMMArrayD1E1M[]
        {
            new BigIntegernumericMMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6873551550207612216L),
new System.Numerics.BigInteger(870048521798414114L),
new System.Numerics.BigInteger(1411672555913114195L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1891433604910291411L),
new System.Numerics.BigInteger(7902039253442032612L),
new System.Numerics.BigInteger(3138396786895547426L),
new System.Numerics.BigInteger(3565251901998991238L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7060753726227386752L),
new System.Numerics.BigInteger(6526809859095966911L),
new System.Numerics.BigInteger(7049424288745952503L),
new System.Numerics.BigInteger(8825024373905901102L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7932156336030328922L),
new System.Numerics.BigInteger(6482932685113413967L),
new System.Numerics.BigInteger(9102709346696437682L),
new System.Numerics.BigInteger(5752131822766276669L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1305823836898620762L),
new System.Numerics.BigInteger(7424848105048062534L),
new System.Numerics.BigInteger(5449166658455163549L),
new System.Numerics.BigInteger(3495149727036631971L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(443339438586788739L),
new System.Numerics.BigInteger(7819791357484924551L),
new System.Numerics.BigInteger(566056851883559786L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3838972509463620303L),
new System.Numerics.BigInteger(2777040725261342120L),
new System.Numerics.BigInteger(2441913124012985596L),
new System.Numerics.BigInteger(5390098994096220557L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4952424311258658858L),
new System.Numerics.BigInteger(3018740671473421361L),
new System.Numerics.BigInteger(6065913907295925102L),
new System.Numerics.BigInteger(924608261817996283L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2610284625483944772L),
new System.Numerics.BigInteger(5031574625058099600L),
new System.Numerics.BigInteger(2065197785582155458L),
new System.Numerics.BigInteger(4968152135117268007L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8566929825026112336L),
new System.Numerics.BigInteger(6405794472774691288L),
new System.Numerics.BigInteger(6898830535759912702L),
new System.Numerics.BigInteger(5511025576367069146L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7411374684353360787L),
new System.Numerics.BigInteger(524042677103300385L),
new System.Numerics.BigInteger(8800923050594714385L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2255007856088728235L),
new System.Numerics.BigInteger(3364191602725566488L),
new System.Numerics.BigInteger(3635193968120985506L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6942778532373195351L),
new System.Numerics.BigInteger(418601202531364951L),
new System.Numerics.BigInteger(5104196863131423298L),
new System.Numerics.BigInteger(5863033767099559460L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8480847927059547717L),
new System.Numerics.BigInteger(2747132351819747179L),
new System.Numerics.BigInteger(3001378972671120740L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5041360212206470057L),
new System.Numerics.BigInteger(6514291260222711284L),
new System.Numerics.BigInteger(3048675747489221484L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1197158544853667233L),
new System.Numerics.BigInteger(6898089178372702621L),
new System.Numerics.BigInteger(8254154332279418085L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(12361461395070029L),
new System.Numerics.BigInteger(6631597456989730772L),
new System.Numerics.BigInteger(6078557312757486078L),
new System.Numerics.BigInteger(81432586320295085L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8743765797390637303L),
new System.Numerics.BigInteger(4101346902524425156L),
new System.Numerics.BigInteger(3968036104872551376L),
new System.Numerics.BigInteger(180992647584484762L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2728147183454805443L),
new System.Numerics.BigInteger(5724238436007516493L),
new System.Numerics.BigInteger(6406347202264928964L),
new System.Numerics.BigInteger(2661348332811677008L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3361782920867218668L),
new System.Numerics.BigInteger(4243200272304947358L),
new System.Numerics.BigInteger(6619068504086031226L),
new System.Numerics.BigInteger(1604533813514794941L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3548761091238345651L),
new System.Numerics.BigInteger(7388841438803979511L),
new System.Numerics.BigInteger(4849470481396331250L),
new System.Numerics.BigInteger(2361021541205622264L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1188757800505338243L),
new System.Numerics.BigInteger(3216786254807626770L),
new System.Numerics.BigInteger(1340593516627955609L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4787232752079854230L),
new System.Numerics.BigInteger(8840145561159542496L),
new System.Numerics.BigInteger(3582875685011853157L),
new System.Numerics.BigInteger(4239186365054160502L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5685601298484635592L),
new System.Numerics.BigInteger(8121756010160396989L),
new System.Numerics.BigInteger(9069219823351583810L),
new System.Numerics.BigInteger(1449334374895982330L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3182244159061669694L),
new System.Numerics.BigInteger(4799546806844414443L),
new System.Numerics.BigInteger(31150854294214768L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5850928104572529518L),
new System.Numerics.BigInteger(5336221334246349249L),
new System.Numerics.BigInteger(624526339538238878L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8750454108486713829L),
new System.Numerics.BigInteger(4848271240863031837L),
new System.Numerics.BigInteger(6436283141764170409L),
new System.Numerics.BigInteger(6633173629948070485L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7852978485227636283L),
new System.Numerics.BigInteger(7297647486239878096L),
new System.Numerics.BigInteger(7977020391314453442L),
new System.Numerics.BigInteger(6912416035648350363L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1730197806526691456L),
new System.Numerics.BigInteger(8367434235221665735L),
new System.Numerics.BigInteger(2061182805459465331L),
new System.Numerics.BigInteger(7627606786457243684L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8297462585419942471L),
new System.Numerics.BigInteger(5111647274342782042L),
new System.Numerics.BigInteger(7726361958493945276L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2125876851848809669L),
new System.Numerics.BigInteger(7225244389682444342L),
new System.Numerics.BigInteger(8830085828398075178L),
new System.Numerics.BigInteger(434356851077276623L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6357901873049400687L),
new System.Numerics.BigInteger(5745758251044359197L),
new System.Numerics.BigInteger(7884250842869471044L),
new System.Numerics.BigInteger(5608185400440341653L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8430711585750231743L),
new System.Numerics.BigInteger(5108212096729425710L),
new System.Numerics.BigInteger(4782842445971591239L),
new System.Numerics.BigInteger(7537375882934676360L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5670168127951885529L),
new System.Numerics.BigInteger(8269393472087108039L),
new System.Numerics.BigInteger(4751327300336040793L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4870524551972358052L),
new System.Numerics.BigInteger(6517510096641601669L),
new System.Numerics.BigInteger(8642617260949194783L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1489265203635408906L),
new System.Numerics.BigInteger(8106044633102521625L),
new System.Numerics.BigInteger(2057492815575582125L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6317015455496779476L),
new System.Numerics.BigInteger(8210066066028290652L),
new System.Numerics.BigInteger(3455881680528042609L),
new System.Numerics.BigInteger(8140719598677081460L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8439487435942527629L),
new System.Numerics.BigInteger(4398394663162979412L),
new System.Numerics.BigInteger(4277563949612248956L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4054213258140468198L),
new System.Numerics.BigInteger(8131975665256894810L),
new System.Numerics.BigInteger(372185007083957124L),
new System.Numerics.BigInteger(3726838873358335176L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2806199796220055493L),
new System.Numerics.BigInteger(8784451622975411640L),
new System.Numerics.BigInteger(8451677567412172488L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2298593798355430897L),
new System.Numerics.BigInteger(3921608188502091911L),
new System.Numerics.BigInteger(2251877817051551062L),
new System.Numerics.BigInteger(336201045353510043L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8625713155634832308L),
new System.Numerics.BigInteger(6721018218063270598L),
new System.Numerics.BigInteger(2456949520950197011L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6922968418511450040L),
new System.Numerics.BigInteger(3183380351078365L),
new System.Numerics.BigInteger(8143647043212065998L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5933598908866491826L),
new System.Numerics.BigInteger(5196830275108057220L),
new System.Numerics.BigInteger(844360944769965160L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3787176422824370979L),
new System.Numerics.BigInteger(487768368119763106L),
new System.Numerics.BigInteger(3346914326263145763L),
new System.Numerics.BigInteger(8145549267880245902L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6220195859444260948L),
new System.Numerics.BigInteger(8868603700807124351L),
new System.Numerics.BigInteger(4444168067951940483L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7214503704579276661L),
new System.Numerics.BigInteger(6263335244680223819L),
new System.Numerics.BigInteger(6289375785903559118L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4538791921859408996L),
new System.Numerics.BigInteger(7995927627257375385L),
new System.Numerics.BigInteger(8926407798541905279L),
new System.Numerics.BigInteger(4118941606785337160L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8812691280468477497L),
new System.Numerics.BigInteger(1692008581314678932L),
new System.Numerics.BigInteger(254385417717933671L),
new System.Numerics.BigInteger(3481896021162341555L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5284575782386862574L),
new System.Numerics.BigInteger(472365568354719754L),
new System.Numerics.BigInteger(6521113815760740640L),
new System.Numerics.BigInteger(1213868375018612651L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3237839381421577229L),
new System.Numerics.BigInteger(6287671099337068979L),
new System.Numerics.BigInteger(8323379245804309730L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6990199991248515572L),
new System.Numerics.BigInteger(4071643496042154501L),
new System.Numerics.BigInteger(2459705582679837116L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8938924686154638353L),
new System.Numerics.BigInteger(7870078140182378983L),
new System.Numerics.BigInteger(3062980256496133988L),
new System.Numerics.BigInteger(6514745184285515461L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5020425239422074144L),
new System.Numerics.BigInteger(4984693741235177108L),
new System.Numerics.BigInteger(4039337494915274103L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3911588093647212401L),
new System.Numerics.BigInteger(2770762541252875066L),
new System.Numerics.BigInteger(3759365808570469489L),
new System.Numerics.BigInteger(9011791334810442081L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5330943958271287717L),
new System.Numerics.BigInteger(8336300144707834042L),
new System.Numerics.BigInteger(4319989389522315145L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2985559899237713203L),
new System.Numerics.BigInteger(5161365902569226397L),
new System.Numerics.BigInteger(2663320979653103011L),
new System.Numerics.BigInteger(3626172059422671335L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6974253221310879028L),
new System.Numerics.BigInteger(1060285867675776213L),
new System.Numerics.BigInteger(3912327753794104608L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7884310220280420448L),
new System.Numerics.BigInteger(5550062077101386695L),
new System.Numerics.BigInteger(7631800344262941971L),
new System.Numerics.BigInteger(6220776463472435546L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3685514386146398043L),
new System.Numerics.BigInteger(1800436334271204978L),
new System.Numerics.BigInteger(8882276725844896838L),
new System.Numerics.BigInteger(3385213289686760235L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3684331423274660266L),
new System.Numerics.BigInteger(4888180363182729165L),
new System.Numerics.BigInteger(2542393578007169073L),
new System.Numerics.BigInteger(1258714791222043455L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6975450998488492297L),
new System.Numerics.BigInteger(1256728934134526011L),
new System.Numerics.BigInteger(6224807713201233044L),
new System.Numerics.BigInteger(5193796672933269757L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5362137308882823579L),
new System.Numerics.BigInteger(3435784732460278827L),
new System.Numerics.BigInteger(7172037670190744956L),
new System.Numerics.BigInteger(1426235247111085393L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3329842673226021526L),
new System.Numerics.BigInteger(4279640811333129585L),
new System.Numerics.BigInteger(5776842246039562910L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(387595310179078486L),
new System.Numerics.BigInteger(3024740036523453493L),
new System.Numerics.BigInteger(4793846825942540163L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1587746437935224963L),
new System.Numerics.BigInteger(3829875895327651710L),
new System.Numerics.BigInteger(1092493162767049453L),
new System.Numerics.BigInteger(6677647950992644620L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(348491735787200321L),
new System.Numerics.BigInteger(8452277129080863256L),
new System.Numerics.BigInteger(4279533461205493227L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2530085711370406200L),
new System.Numerics.BigInteger(4949078476101277592L),
new System.Numerics.BigInteger(8597392781659300625L),
new System.Numerics.BigInteger(4388286793863090625L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3127918753565782137L),
new System.Numerics.BigInteger(1370688291207853019L),
new System.Numerics.BigInteger(7238134741174633567L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6485045603948747319L),
new System.Numerics.BigInteger(1939079354405550097L),
new System.Numerics.BigInteger(3904114340079149186L),
new System.Numerics.BigInteger(8080865400364228171L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1511270836543380686L),
new System.Numerics.BigInteger(7850405179598441375L),
new System.Numerics.BigInteger(7395662495084182130L),
new System.Numerics.BigInteger(866573196994169656L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5935701117905820007L),
new System.Numerics.BigInteger(3361307615626595478L),
new System.Numerics.BigInteger(7964676649715483651L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7333838947458283593L),
new System.Numerics.BigInteger(974613468940649297L),
new System.Numerics.BigInteger(3681406452042594686L),
new System.Numerics.BigInteger(4977043786663264484L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8944472546954003570L),
new System.Numerics.BigInteger(907965844827606919L),
new System.Numerics.BigInteger(9010325841508011543L),
new System.Numerics.BigInteger(849930276457307479L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8134574916006961292L),
new System.Numerics.BigInteger(597703600493961903L),
new System.Numerics.BigInteger(5585492380101516317L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7188846641550035330L),
new System.Numerics.BigInteger(2228692841705294510L),
new System.Numerics.BigInteger(4348151283302443572L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(580362851922848467L),
new System.Numerics.BigInteger(5418030067985128766L),
new System.Numerics.BigInteger(4720541034708441363L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5944603337191305525L),
new System.Numerics.BigInteger(8021421504796025037L),
new System.Numerics.BigInteger(2110291855263051025L),
new System.Numerics.BigInteger(2511819229197273021L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(644870821595255438L),
new System.Numerics.BigInteger(7861096965978265321L),
new System.Numerics.BigInteger(1207560986876089152L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9109991330969799291L),
new System.Numerics.BigInteger(1112243937828458381L),
new System.Numerics.BigInteger(3284326595233599772L),
new System.Numerics.BigInteger(3340045249165164969L),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)), 
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
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
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
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 23, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 56, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 64, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 79, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 90, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 12, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 146, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MI),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1M),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
FROM public.binary_bigintegernumericmmarrayd1e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI), typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

