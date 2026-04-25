

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
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7354299749521345267L),
new System.Numerics.BigInteger(3084442668154243657L),
new System.Numerics.BigInteger(5011295049481534823L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2960645534029531996L),
new System.Numerics.BigInteger(9183704654182767451L),
new System.Numerics.BigInteger(203716426990871902L),
new System.Numerics.BigInteger(1403895378944562147L),
},
},
            new BigIntegernumericArray1M
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8514394787726759686L),
new System.Numerics.BigInteger(9020866826458823899L),
new System.Numerics.BigInteger(8377438935214303061L),
new System.Numerics.BigInteger(5064209178627048071L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 1,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8663490091542600442L),
new System.Numerics.BigInteger(4668489468545123970L),
new System.Numerics.BigInteger(7694043044579774187L),
new System.Numerics.BigInteger(749769917687113698L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6807890751407768125L),
new System.Numerics.BigInteger(3491517762963717167L),
new System.Numerics.BigInteger(5743816979255225276L),
new System.Numerics.BigInteger(4527449048708194811L),
},
},
            new BigIntegernumericArray1M
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(856339039257740025L),
new System.Numerics.BigInteger(2273822120042212198L),
new System.Numerics.BigInteger(8865811704795795535L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4589897531094286586L),
new System.Numerics.BigInteger(5418186192607253375L),
new System.Numerics.BigInteger(6203316872120964210L),
},
},
            new BigIntegernumericArray1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4449695659521929377L),
new System.Numerics.BigInteger(5446658454388015443L),
new System.Numerics.BigInteger(2637233955483815269L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4471392472547181404L),
new System.Numerics.BigInteger(4643578328932596355L),
new System.Numerics.BigInteger(7284774037762599273L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1696978276083611639L),
new System.Numerics.BigInteger(6197626811359133471L),
new System.Numerics.BigInteger(9221552268853716501L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3831087622629539803L),
new System.Numerics.BigInteger(2607428067663488555L),
new System.Numerics.BigInteger(2312401655712193218L),
},
},
            new BigIntegernumericArray1M
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7197452150296809964L),
new System.Numerics.BigInteger(6395952045513304489L),
new System.Numerics.BigInteger(5499702164906763698L),
new System.Numerics.BigInteger(278927060574919911L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4966282655813606698L),
new System.Numerics.BigInteger(8908682294499673773L),
new System.Numerics.BigInteger(2895750038339453908L),
new System.Numerics.BigInteger(1638307004868050448L),
},
},
            new BigIntegernumericArray1M
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3677525335938596475L),
new System.Numerics.BigInteger(7067547424579637586L),
new System.Numerics.BigInteger(4451501818600781399L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4471236079145668312L),
new System.Numerics.BigInteger(9080577658051981028L),
new System.Numerics.BigInteger(8266635762024363107L),
new System.Numerics.BigInteger(7461691496251349570L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(266857149320000308L),
new System.Numerics.BigInteger(7242164263630776626L),
new System.Numerics.BigInteger(4378000747859965824L),
},
},
            new BigIntegernumericArray1M
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8088907363249455124L),
new System.Numerics.BigInteger(7915953266888174292L),
new System.Numerics.BigInteger(2772018128662236613L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6426804621859782781L),
new System.Numerics.BigInteger(3938987499549204221L),
new System.Numerics.BigInteger(8249860924643935115L),
new System.Numerics.BigInteger(3177643571922642547L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(355357650708629108L),
new System.Numerics.BigInteger(4544493331420445998L),
new System.Numerics.BigInteger(8812808230009963693L),
new System.Numerics.BigInteger(1422274664537485491L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3891846077502999654L),
new System.Numerics.BigInteger(740190237048224748L),
new System.Numerics.BigInteger(3344665512737820924L),
new System.Numerics.BigInteger(8763970597106338707L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6911832219142372220L),
new System.Numerics.BigInteger(4640822969090882058L),
new System.Numerics.BigInteger(8830297572675003459L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2536289544778233613L),
new System.Numerics.BigInteger(886173610554247259L),
new System.Numerics.BigInteger(2811493155423960440L),
new System.Numerics.BigInteger(4328532180069778866L),
},
},
            new BigIntegernumericArray1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423525146879374433L),
new System.Numerics.BigInteger(573220562067095109L),
new System.Numerics.BigInteger(4168316345696265687L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(337039937706476305L),
new System.Numerics.BigInteger(2585899015662750682L),
new System.Numerics.BigInteger(7033716536390367122L),
new System.Numerics.BigInteger(5451943264501590790L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(945917004346465834L),
new System.Numerics.BigInteger(1978137622658930387L),
new System.Numerics.BigInteger(7428531644480700022L),
},
},
            new BigIntegernumericArray1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2822300434392111365L),
new System.Numerics.BigInteger(8852922641850620340L),
new System.Numerics.BigInteger(2318798304264545385L),
new System.Numerics.BigInteger(7638490632265001892L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6210158627696599330L),
new System.Numerics.BigInteger(3150798755426907810L),
new System.Numerics.BigInteger(5303913564402552656L),
},
},
            new BigIntegernumericArray1M
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7027592584991896684L),
new System.Numerics.BigInteger(8946830827912714962L),
new System.Numerics.BigInteger(2636888127576171507L),
new System.Numerics.BigInteger(1890177719921024776L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1902882882126340294L),
new System.Numerics.BigInteger(6329236481191475830L),
new System.Numerics.BigInteger(2612175881865222565L),
new System.Numerics.BigInteger(860187921923933145L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2373221684572913560L),
new System.Numerics.BigInteger(7945033124321454266L),
new System.Numerics.BigInteger(3636512908616218880L),
new System.Numerics.BigInteger(1758380791958934924L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3574760873188286786L),
new System.Numerics.BigInteger(626207824375667904L),
new System.Numerics.BigInteger(7961874663441841279L),
new System.Numerics.BigInteger(5651099656975728246L),
},
},
            new BigIntegernumericArray1M
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1434362123319171688L),
new System.Numerics.BigInteger(5631367186077888499L),
new System.Numerics.BigInteger(9112061464359386705L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7147837950015227645L),
new System.Numerics.BigInteger(1864424613292083296L),
new System.Numerics.BigInteger(938743868963123090L),
new System.Numerics.BigInteger(3728583807332276974L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1550799691269630089L),
new System.Numerics.BigInteger(5504470960725494082L),
new System.Numerics.BigInteger(2923545588737641598L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2609801390372082110L),
new System.Numerics.BigInteger(2088795695534015271L),
new System.Numerics.BigInteger(6332073491918645626L),
new System.Numerics.BigInteger(2831567884358714270L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8935083266568355672L),
new System.Numerics.BigInteger(7635385233521715668L),
new System.Numerics.BigInteger(410672710303680719L),
},
},
            new BigIntegernumericArray1M
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3961130259767387933L),
new System.Numerics.BigInteger(5972009310455857917L),
new System.Numerics.BigInteger(4632992297017848880L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2136503069744486742L),
new System.Numerics.BigInteger(4770102749325881503L),
new System.Numerics.BigInteger(4859588824396434240L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7749670777347383654L),
new System.Numerics.BigInteger(3897806594148742090L),
new System.Numerics.BigInteger(3298578356343277193L),
new System.Numerics.BigInteger(4241624651291733475L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6562192565304004762L),
new System.Numerics.BigInteger(6655089323110430493L),
new System.Numerics.BigInteger(355152212849237828L),
new System.Numerics.BigInteger(6293733834572469264L),
},
},
            new BigIntegernumericArray1M
{
    Id = 97,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1033981225218467951L),
new System.Numerics.BigInteger(7583196837352062137L),
new System.Numerics.BigInteger(8681116701439374677L),
new System.Numerics.BigInteger(4703550592334782160L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2386726223661444338L),
new System.Numerics.BigInteger(9008333785072974029L),
new System.Numerics.BigInteger(1696159725782486325L),
new System.Numerics.BigInteger(4627546674258564952L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8875266576557941164L),
new System.Numerics.BigInteger(5665022493278671378L),
new System.Numerics.BigInteger(4485580804012184195L),
new System.Numerics.BigInteger(8965243234014178124L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6405583134510730782L),
new System.Numerics.BigInteger(4012076635542535260L),
new System.Numerics.BigInteger(3280544515594855881L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2301807122678311455L),
new System.Numerics.BigInteger(6639483908032027951L),
new System.Numerics.BigInteger(390983455277369760L),
new System.Numerics.BigInteger(2724320192662687853L),
},
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1318349822792743003L),
new System.Numerics.BigInteger(7601862715438672005L),
new System.Numerics.BigInteger(734597128493099746L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6497176025043116363L),
new System.Numerics.BigInteger(6245888814825531521L),
new System.Numerics.BigInteger(2724249517547820927L),
new System.Numerics.BigInteger(5782471586760540423L),
},
},
            new BigIntegernumericArray1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3616698888984998204L),
new System.Numerics.BigInteger(2119828093044525296L),
new System.Numerics.BigInteger(5402941286324558369L),
new System.Numerics.BigInteger(2621501318269546718L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4855101413665268372L),
new System.Numerics.BigInteger(2177515625933364799L),
new System.Numerics.BigInteger(279054399083194349L),
new System.Numerics.BigInteger(6801093307886485050L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7660479003628425167L),
new System.Numerics.BigInteger(5984131046248111440L),
new System.Numerics.BigInteger(2867075964209933229L),
new System.Numerics.BigInteger(1306747022770716383L),
},
},
            new BigIntegernumericArray1M
{
    Id = 114,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7243709160186425390L),
new System.Numerics.BigInteger(2976349422623456354L),
new System.Numerics.BigInteger(9006159997425698283L),
new System.Numerics.BigInteger(1015759345777240996L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 117,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9107398400363594993L),
new System.Numerics.BigInteger(3870006326173359032L),
new System.Numerics.BigInteger(4453108152821791002L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6991560982021474350L),
new System.Numerics.BigInteger(7511791712035051431L),
new System.Numerics.BigInteger(2504479007062903743L),
new System.Numerics.BigInteger(1772302901406887025L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2137389372176824135L),
new System.Numerics.BigInteger(4108987894384246939L),
new System.Numerics.BigInteger(4116263200370202451L),
},
},
            new BigIntegernumericArray1M
{
    Id = 119,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5745201361808610306L),
new System.Numerics.BigInteger(1879789745459903819L),
new System.Numerics.BigInteger(8066683438580245099L),
new System.Numerics.BigInteger(1080839435525617455L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2887460392868715517L),
new System.Numerics.BigInteger(5764723087358484094L),
new System.Numerics.BigInteger(2296244111499137477L),
new System.Numerics.BigInteger(8109347976118601120L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8710299632349064121L),
new System.Numerics.BigInteger(4807682345591387048L),
new System.Numerics.BigInteger(294564016565577891L),
new System.Numerics.BigInteger(244115272397412038L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 134,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1295670171111298731L),
new System.Numerics.BigInteger(7977237479806694069L),
new System.Numerics.BigInteger(2926969814722085574L),
new System.Numerics.BigInteger(5899190520626319267L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5095874313119140530L),
new System.Numerics.BigInteger(3427378257166749303L),
new System.Numerics.BigInteger(940790371329872045L),
},
},
            new BigIntegernumericArray1M
{
    Id = 135,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4808526301387778408L),
new System.Numerics.BigInteger(2170203439715686207L),
new System.Numerics.BigInteger(3456989923198732126L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1321534916282591598L),
new System.Numerics.BigInteger(7162419308121806574L),
new System.Numerics.BigInteger(2236026780368038506L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5406796631640750648L),
new System.Numerics.BigInteger(3370333420964825811L),
new System.Numerics.BigInteger(5566714030260256813L),
new System.Numerics.BigInteger(6645380162950872455L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 138,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6823988985162049458L),
new System.Numerics.BigInteger(6592933601217003546L),
new System.Numerics.BigInteger(408675920146768800L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 140,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2320782108809122173L),
new System.Numerics.BigInteger(5907506860592840856L),
new System.Numerics.BigInteger(7163289649102173325L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3073509730745587482L),
new System.Numerics.BigInteger(8480132075695413044L),
new System.Numerics.BigInteger(7960459600121873975L),
new System.Numerics.BigInteger(6132955834185843605L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7192644233252128992L),
new System.Numerics.BigInteger(6621818562254660489L),
new System.Numerics.BigInteger(6442323763814648743L),
new System.Numerics.BigInteger(9143949235893317151L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 143,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6256964078430741699L),
new System.Numerics.BigInteger(8019868062695313741L),
new System.Numerics.BigInteger(4377121785870976717L),
new System.Numerics.BigInteger(5865774886083299590L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2360891500762664605L),
new System.Numerics.BigInteger(2406754416283503149L),
new System.Numerics.BigInteger(8667883878013170685L),
},
},
            new BigIntegernumericArray1M
{
    Id = 147,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8596507513478855205L),
new System.Numerics.BigInteger(2579054538733229260L),
new System.Numerics.BigInteger(1770724299246828961L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 90,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3127495268188113702L),
new System.Numerics.BigInteger(5571022133201624130L),
new System.Numerics.BigInteger(2332120739466019129L),
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(8));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 140;
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
                        Assert.That(models, Has.Count.EqualTo(2));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
BigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 109, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 45, query2))
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
                        Assert.That(models, Has.Count.EqualTo(22));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatchAsync(connection, 82, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
BigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
BigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatch(connection, 13, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
BigIntegernumericArray1M.AssertModel(models[0],_testData[2], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[3], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[27],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
BigIntegernumericArray1M.AssertModel(models[0],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
BigIntegernumericArray1M.AssertModel(models[0],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[29], false);
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

