

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0657154435502022d, b: 0.6397553464415526d, c: 0.8640434140916606d),
new NpgsqlTypes.NpgsqlLine(a: 0.07930966308073539d, b: 0.8944391022275677d, c: 0.8209540977457921d),
new NpgsqlTypes.NpgsqlLine(a: 0.28950928137593746d, b: 0.27362307815020537d, c: 0.4103051043414139d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9416909658481644d, b: 0.6287797263644554d, c: 0.5437313434376431d),
new NpgsqlTypes.NpgsqlLine(a: 0.23705097958567856d, b: 0.31805613407517785d, c: 0.41968487150020206d),
new NpgsqlTypes.NpgsqlLine(a: 0.3048459918362719d, b: 0.9626120298009747d, c: 0.29382812451356277d),
new NpgsqlTypes.NpgsqlLine(a: 0.4610874082933183d, b: 0.07872416317961295d, c: 0.6759285406023885d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1641659088061398d, b: 0.5837991303694466d, c: 0.486843932902118d),
new NpgsqlTypes.NpgsqlLine(a: 0.8802355943380231d, b: 0.25188861935476936d, c: 0.7243925953096039d),
new NpgsqlTypes.NpgsqlLine(a: 0.5762061722542362d, b: 0.1696410227280758d, c: 0.6411158779642454d),
new NpgsqlTypes.NpgsqlLine(a: 0.910445873320144d, b: 0.987839604524928d, c: 0.4834905613374232d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5656482796523389d, b: 0.07099812157223329d, c: 0.005408711486542539d),
new NpgsqlTypes.NpgsqlLine(a: 0.3871195223960955d, b: 0.6729262389498243d, c: 0.23009640814855692d),
new NpgsqlTypes.NpgsqlLine(a: 0.5853783518141885d, b: 0.04002117845312636d, c: 0.022819804183871972d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8718768773941707d, b: 0.6021684149385721d, c: 0.9946272832373567d),
new NpgsqlTypes.NpgsqlLine(a: 0.8370187646248489d, b: 0.1753414801165798d, c: 0.08914777152085229d),
new NpgsqlTypes.NpgsqlLine(a: 0.24618721783024622d, b: 0.4085266144975508d, c: 0.6646442879832587d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.028378965152192293d, b: 0.5495316892258524d, c: 0.06083115707486619d),
new NpgsqlTypes.NpgsqlLine(a: 0.1889309828066431d, b: 0.15023926234395202d, c: 0.2559838780539623d),
new NpgsqlTypes.NpgsqlLine(a: 0.35028836064104507d, b: 0.8191753626898035d, c: 0.9735940355509979d),
new NpgsqlTypes.NpgsqlLine(a: 0.2402468453738409d, b: 0.3825985417376129d, c: 0.405358775218014d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7768649373045683d, b: 0.8399780110964458d, c: 0.7562278547568998d),
new NpgsqlTypes.NpgsqlLine(a: 0.18113315183805478d, b: 0.23727662276794304d, c: 0.21887245406260436d),
new NpgsqlTypes.NpgsqlLine(a: 0.8585605544815202d, b: 0.4950634166324692d, c: 0.08812541735992885d),
new NpgsqlTypes.NpgsqlLine(a: 0.8800104069595572d, b: 0.8037112582563709d, c: 0.7219297868309561d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33899452611493275d, b: 0.6076976081734553d, c: 0.6076979997315786d),
new NpgsqlTypes.NpgsqlLine(a: 0.04239469031163057d, b: 0.1340909653883744d, c: 0.807000505721361d),
new NpgsqlTypes.NpgsqlLine(a: 0.5259103547150986d, b: 0.15377206864371362d, c: 0.32817164148305045d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46635422961359796d, b: 0.49097292616909183d, c: 0.9159837471252399d),
new NpgsqlTypes.NpgsqlLine(a: 0.7409644261950814d, b: 0.4502806602567754d, c: 0.5976472251325659d),
new NpgsqlTypes.NpgsqlLine(a: 0.9648130392896928d, b: 0.49368958433134513d, c: 0.351817209428368d),
new NpgsqlTypes.NpgsqlLine(a: 0.8804640163679704d, b: 0.5679905159736253d, c: 0.46913669286430604d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8374014298630897d, b: 0.6529870318488407d, c: 0.6207027304279622d),
new NpgsqlTypes.NpgsqlLine(a: 0.26361877055739613d, b: 0.21258289188206136d, c: 0.028637614769925546d),
new NpgsqlTypes.NpgsqlLine(a: 0.1757029095686219d, b: 0.6021352162343159d, c: 0.48355865495301587d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38333471899667126d, b: 0.4181730239368445d, c: 0.06278711977080986d),
new NpgsqlTypes.NpgsqlLine(a: 0.26469871219623164d, b: 0.11320474463782282d, c: 0.4792503185399418d),
new NpgsqlTypes.NpgsqlLine(a: 0.28789799728477494d, b: 0.1684666590652114d, c: 0.6337381123160999d),
new NpgsqlTypes.NpgsqlLine(a: 0.30296064602268646d, b: 0.06234542461995862d, c: 0.6389797348778853d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5503169123737333d, b: 0.8613465207924396d, c: 0.18378854633970454d),
new NpgsqlTypes.NpgsqlLine(a: 0.4947375718238961d, b: 0.5074060188992674d, c: 0.3939316854148387d),
new NpgsqlTypes.NpgsqlLine(a: 0.47059393653262027d, b: 0.7929009059064853d, c: 0.18479958588781376d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6421356183903413d, b: 0.1224065486938567d, c: 0.6944988020178736d),
new NpgsqlTypes.NpgsqlLine(a: 0.6956686139702456d, b: 0.33810221403450824d, c: 0.0686236461896036d),
new NpgsqlTypes.NpgsqlLine(a: 0.8698776916181156d, b: 0.661507851852187d, c: 0.05251170179120812d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6426039051258983d, b: 0.7747237829574608d, c: 0.9156797552655433d),
new NpgsqlTypes.NpgsqlLine(a: 0.4375246596176292d, b: 0.3045994420193049d, c: 0.6268372348361827d),
new NpgsqlTypes.NpgsqlLine(a: 0.8681721601401897d, b: 0.22510030719657959d, c: 0.39075864648574943d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5386662629913065d, b: 0.6082850542906484d, c: 0.1449709426230653d),
new NpgsqlTypes.NpgsqlLine(a: 0.7977968372209423d, b: 0.8642110336049708d, c: 0.8025259307369759d),
new NpgsqlTypes.NpgsqlLine(a: 0.7701485109488886d, b: 0.5673262332964868d, c: 0.7851436488659733d),
new NpgsqlTypes.NpgsqlLine(a: 0.8687290714040926d, b: 0.9086989530196621d, c: 0.29160291069182676d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9161568676849111d, b: 0.9996253981523405d, c: 0.7910989979216412d),
new NpgsqlTypes.NpgsqlLine(a: 0.11349725312552161d, b: 0.4805945798546235d, c: 0.373534320300011d),
new NpgsqlTypes.NpgsqlLine(a: 0.9963577790524911d, b: 0.5247054328863301d, c: 0.12784867176104608d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9268542186418974d, b: 0.667216722609538d, c: 0.5660639459541876d),
new NpgsqlTypes.NpgsqlLine(a: 0.34898732878145733d, b: 0.7034947004271086d, c: 0.5214126312262979d),
new NpgsqlTypes.NpgsqlLine(a: 0.8856542253506401d, b: 0.42547322482062744d, c: 0.09016310147377304d),
new NpgsqlTypes.NpgsqlLine(a: 0.18463605949260042d, b: 0.12236410726985558d, c: 0.7865545180406668d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6177830623834164d, b: 0.9641250759607262d, c: 0.09104955985630825d),
new NpgsqlTypes.NpgsqlLine(a: 0.982088441748743d, b: 0.03882608117027253d, c: 0.3589128791896574d),
new NpgsqlTypes.NpgsqlLine(a: 0.6936240210780479d, b: 0.27681347701872905d, c: 0.6542405942864707d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25668142102935143d, b: 0.4159411297454202d, c: 0.21893061773227862d),
new NpgsqlTypes.NpgsqlLine(a: 0.5955759134717294d, b: 0.9868684359463161d, c: 0.6983336689619365d),
new NpgsqlTypes.NpgsqlLine(a: 0.015636672906021554d, b: 0.23582351984719385d, c: 0.662888419961137d),
new NpgsqlTypes.NpgsqlLine(a: 0.6688237070406845d, b: 0.18012820651751849d, c: 0.8436935875320216d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6080592382912229d, b: 0.04994427745135721d, c: 0.2868267725836551d),
new NpgsqlTypes.NpgsqlLine(a: 0.4059722254921506d, b: 0.28797177939125385d, c: 0.17866432385690678d),
new NpgsqlTypes.NpgsqlLine(a: 0.4207084754270317d, b: 0.2493792794227082d, c: 0.2619510391129224d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3253345252583828d, b: 0.846183666791453d, c: 0.018702634428334197d),
new NpgsqlTypes.NpgsqlLine(a: 0.2703151710897992d, b: 0.4940638364166663d, c: 0.12918307350403957d),
new NpgsqlTypes.NpgsqlLine(a: 0.9504347883748102d, b: 0.018399241307879954d, c: 0.5376889313917743d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29143453027084665d, b: 0.5596987055535839d, c: 0.790399486996594d),
new NpgsqlTypes.NpgsqlLine(a: 0.03004686297948045d, b: 0.6852180547007607d, c: 0.2680791510201622d),
new NpgsqlTypes.NpgsqlLine(a: 0.7810901990131025d, b: 0.6044558050308106d, c: 0.26302535440707964d),
new NpgsqlTypes.NpgsqlLine(a: 0.480159132162864d, b: 0.4645205296310947d, c: 0.7683832811844898d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4252662549655565d, b: 0.07069357065232207d, c: 0.3700903259866496d),
new NpgsqlTypes.NpgsqlLine(a: 0.6685007794391538d, b: 0.7790965188293622d, c: 0.8892727217010398d),
new NpgsqlTypes.NpgsqlLine(a: 0.8353479187474846d, b: 0.7458514520304399d, c: 0.3841019563692617d),
new NpgsqlTypes.NpgsqlLine(a: 0.13924312615387002d, b: 0.5003835890009123d, c: 0.7776854450039238d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18201286457539423d, b: 0.6683736442531039d, c: 0.9122544504332766d),
new NpgsqlTypes.NpgsqlLine(a: 0.35193956098564405d, b: 0.8672145503379797d, c: 0.8351150700904387d),
new NpgsqlTypes.NpgsqlLine(a: 0.9729598275097036d, b: 0.9039420269234479d, c: 0.8182863508652559d),
new NpgsqlTypes.NpgsqlLine(a: 0.26825097187313574d, b: 0.6923436963618772d, c: 0.5092076096460106d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6233851299500772d, b: 0.8055648958205108d, c: 0.7002536971167966d),
new NpgsqlTypes.NpgsqlLine(a: 0.6063387286141668d, b: 0.7485413490024538d, c: 0.5825656286213198d),
new NpgsqlTypes.NpgsqlLine(a: 0.2942641646012266d, b: 0.9560635003419556d, c: 0.8221670058600702d),
new NpgsqlTypes.NpgsqlLine(a: 0.7200363843316048d, b: 0.9071126196337804d, c: 0.7258920358252594d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0236158516926247d, b: 0.8967298752547644d, c: 0.11955686752778594d),
new NpgsqlTypes.NpgsqlLine(a: 0.7345120230156689d, b: 0.544430075201632d, c: 0.009872045028730292d),
new NpgsqlTypes.NpgsqlLine(a: 0.9366479283670931d, b: 0.2208007319591616d, c: 0.47904251839376233d),
new NpgsqlTypes.NpgsqlLine(a: 0.28028294427419465d, b: 0.6869000709152765d, c: 0.16342706470057433d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.273923895076562d, b: 0.4038168204877981d, c: 0.07479490601316963d),
new NpgsqlTypes.NpgsqlLine(a: 0.19311508450322346d, b: 0.013877005283649102d, c: 0.07798543058326246d),
new NpgsqlTypes.NpgsqlLine(a: 0.32122668200167714d, b: 0.5092445352262656d, c: 0.800648921349491d),
new NpgsqlTypes.NpgsqlLine(a: 0.3686823551928805d, b: 0.37959393879802517d, c: 0.7180001944425931d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22749400726883584d, b: 0.12258239032417428d, c: 0.7895171124515756d),
new NpgsqlTypes.NpgsqlLine(a: 0.06154324429916569d, b: 0.8700132179527003d, c: 0.9011432950341911d),
new NpgsqlTypes.NpgsqlLine(a: 0.07643700082275817d, b: 0.5086911388044146d, c: 0.8037850996517575d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2716218351732005d, b: 0.8993663192211041d, c: 0.6045476665424417d),
new NpgsqlTypes.NpgsqlLine(a: 0.6314964582672808d, b: 0.6793050432957798d, c: 0.7595848438682153d),
new NpgsqlTypes.NpgsqlLine(a: 0.2279576415531115d, b: 0.7629370990147475d, c: 0.6976291274458805d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.315310144451849d, b: 0.9078435257951494d, c: 0.7050877170004198d),
new NpgsqlTypes.NpgsqlLine(a: 0.14200514933526842d, b: 0.20495220362618416d, c: 0.48325506465987844d),
new NpgsqlTypes.NpgsqlLine(a: 0.4954566975334094d, b: 0.919113809740185d, c: 0.6328730171300948d),
new NpgsqlTypes.NpgsqlLine(a: 0.18805909440763913d, b: 0.7122465528959792d, c: 0.9126854000092967d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26412537249005563d, b: 0.2633815362858334d, c: 0.6291468603806417d),
new NpgsqlTypes.NpgsqlLine(a: 0.7368007735783166d, b: 0.26447184616962094d, c: 0.1156877490269933d),
new NpgsqlTypes.NpgsqlLine(a: 0.29312144712791066d, b: 0.9543180854946159d, c: 0.9963888839329298d),
new NpgsqlTypes.NpgsqlLine(a: 0.16815299618363544d, b: 0.852677091525865d, c: 0.5434382971859416d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7570721839536981d, b: 0.3333580259996135d, c: 0.09308909072742755d),
new NpgsqlTypes.NpgsqlLine(a: 0.7985574678235d, b: 0.42907432292510184d, c: 0.4714440817298723d),
new NpgsqlTypes.NpgsqlLine(a: 0.18252255668388417d, b: 0.37842304991852316d, c: 0.13468597257048742d),
new NpgsqlTypes.NpgsqlLine(a: 0.596195544710414d, b: 0.15370852589658168d, c: 0.5873708997107278d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30059728536548214d, b: 0.2109817494780204d, c: 0.7439401540028953d),
new NpgsqlTypes.NpgsqlLine(a: 0.9663056795410944d, b: 0.2607581233470667d, c: 0.8809015378221527d),
new NpgsqlTypes.NpgsqlLine(a: 0.39957062711264313d, b: 0.9595905531320287d, c: 0.07960849311032303d),
new NpgsqlTypes.NpgsqlLine(a: 0.26331139697926087d, b: 0.794159856446021d, c: 0.1292050135355468d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8305014675907793d, b: 0.2214080280722095d, c: 0.09886619274320185d),
new NpgsqlTypes.NpgsqlLine(a: 0.48357971689451096d, b: 0.4933946921436302d, c: 0.8507115682345011d),
new NpgsqlTypes.NpgsqlLine(a: 0.7052959060295264d, b: 0.9659226200199205d, c: 0.7192704555972251d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.37252249660375536d, b: 0.0388449958105368d, c: 0.7746104070529642d),
new NpgsqlTypes.NpgsqlLine(a: 0.5827220793818235d, b: 0.8765163973904446d, c: 0.1113289044131136d),
new NpgsqlTypes.NpgsqlLine(a: 0.2244913947171172d, b: 0.08917101498005642d, c: 0.6397598078208651d),
new NpgsqlTypes.NpgsqlLine(a: 0.9018347722301564d, b: 0.49261582737322585d, c: 0.29706504936341316d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6853656779431583d, b: 0.645259162668194d, c: 0.9622198726509223d),
new NpgsqlTypes.NpgsqlLine(a: 0.38026294771688274d, b: 0.6714807950321988d, c: 0.6632319085226056d),
new NpgsqlTypes.NpgsqlLine(a: 0.8600139120779559d, b: 0.8319304392788742d, c: 0.1763095663509675d),
new NpgsqlTypes.NpgsqlLine(a: 0.39248536167651304d, b: 0.06429845483945407d, c: 0.40866833937895475d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31479363809880057d, b: 0.4963598652362331d, c: 0.2839864262667794d),
new NpgsqlTypes.NpgsqlLine(a: 0.1946080036468183d, b: 0.18452716184027995d, c: 0.602369093303379d),
new NpgsqlTypes.NpgsqlLine(a: 0.6064698514869319d, b: 0.4357334859712606d, c: 0.9745500910137397d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10168596710886135d, b: 0.9173430830373526d, c: 0.274016765708766d),
new NpgsqlTypes.NpgsqlLine(a: 0.5026942464739294d, b: 0.10702528011267909d, c: 0.8385040848833262d),
new NpgsqlTypes.NpgsqlLine(a: 0.8222960001587359d, b: 0.13285260674331012d, c: 0.26827831208272057d),
new NpgsqlTypes.NpgsqlLine(a: 0.6651910185058794d, b: 0.543630081656622d, c: 0.4516980735200835d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4119242754287644d, b: 0.3470115082598656d, c: 0.5854787337464258d),
new NpgsqlTypes.NpgsqlLine(a: 0.6421962461598745d, b: 0.6665273035731449d, c: 0.48614752063219646d),
new NpgsqlTypes.NpgsqlLine(a: 0.06423627494910411d, b: 0.7872717543121908d, c: 0.4799718162842599d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0928908014656511d, b: 0.22884691917262956d, c: 0.6242240412465299d),
new NpgsqlTypes.NpgsqlLine(a: 0.8241833357881166d, b: 0.8381824994653972d, c: 0.21734899448239497d),
new NpgsqlTypes.NpgsqlLine(a: 0.6097786524588176d, b: 0.38729242291369514d, c: 0.3096994361211134d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8985927940545851d, b: 0.8768474819477093d, c: 0.41009781754569596d),
new NpgsqlTypes.NpgsqlLine(a: 0.30770559210149384d, b: 0.33809322765124716d, c: 0.17887778386108188d),
new NpgsqlTypes.NpgsqlLine(a: 0.15272147170514405d, b: 0.6854843095351592d, c: 0.3748004252715307d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8344684917151726d, b: 0.6058400354325509d, c: 0.21823741909276018d),
new NpgsqlTypes.NpgsqlLine(a: 0.8257682994747182d, b: 0.07396609033399348d, c: 0.3390454360530345d),
new NpgsqlTypes.NpgsqlLine(a: 0.27878515959568506d, b: 0.2972855827626081d, c: 0.14567362061720646d),
new NpgsqlTypes.NpgsqlLine(a: 0.6285144545288819d, b: 0.42505484631060186d, c: 0.16839341399827235d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11917863747343371d, b: 0.3402680317739163d, c: 0.6500591691249152d),
new NpgsqlTypes.NpgsqlLine(a: 0.27961992070130337d, b: 0.3153839221301372d, c: 0.5302121670223695d),
new NpgsqlTypes.NpgsqlLine(a: 0.9114640032227254d, b: 0.4503221590089621d, c: 0.41957483080838287d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6245193070233153d, b: 0.6728245130907519d, c: 0.08320474097578912d),
new NpgsqlTypes.NpgsqlLine(a: 0.6898092406773969d, b: 0.8342055367496455d, c: 0.6080106363435925d),
new NpgsqlTypes.NpgsqlLine(a: 0.43040072169479016d, b: 0.3788101475566965d, c: 0.8173342689616858d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7413703683501548d, b: 0.22208722362649003d, c: 0.34089677624514214d),
new NpgsqlTypes.NpgsqlLine(a: 0.6601937633037056d, b: 0.27107912190079864d, c: 0.40070120159104317d),
new NpgsqlTypes.NpgsqlLine(a: 0.4415903465662374d, b: 0.24915400114993214d, c: 0.010229306949216088d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7082173496010329d, b: 0.9060514569009995d, c: 0.35236472076703507d),
new NpgsqlTypes.NpgsqlLine(a: 0.12479753780178249d, b: 0.6117401557438334d, c: 0.4832912995030558d),
new NpgsqlTypes.NpgsqlLine(a: 0.12845986148087496d, b: 0.8219405987488926d, c: 0.693149250426115d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5132728547091282d, b: 0.6051412265240588d, c: 0.10755367727430865d),
new NpgsqlTypes.NpgsqlLine(a: 0.906233141624132d, b: 0.2963202962569227d, c: 0.8445817542478004d),
new NpgsqlTypes.NpgsqlLine(a: 0.7804030060365317d, b: 0.7462963684019409d, c: 0.8545602130570925d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9782647752642484d, b: 0.4283265530269331d, c: 0.9253939684670581d),
new NpgsqlTypes.NpgsqlLine(a: 0.4284289802938527d, b: 0.42874750441438425d, c: 0.584200530536609d),
new NpgsqlTypes.NpgsqlLine(a: 0.6416860318230931d, b: 0.6741213391201143d, c: 0.34636725685301883d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5770295597445708d, b: 0.12157788970809491d, c: 0.13173327876005914d),
new NpgsqlTypes.NpgsqlLine(a: 0.9696062883543463d, b: 0.7890328625628907d, c: 0.38775869482983183d),
new NpgsqlTypes.NpgsqlLine(a: 0.17057903275975428d, b: 0.19565642537549233d, c: 0.34174078434443855d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4463148096687465d, b: 0.11055419955019552d, c: 0.6001726267233678d),
new NpgsqlTypes.NpgsqlLine(a: 0.2605151041995545d, b: 0.3431122117776857d, c: 0.5283377587556863d),
new NpgsqlTypes.NpgsqlLine(a: 0.40858889854979974d, b: 0.07694406982157698d, c: 0.13786457232975424d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16681929696936837d, b: 0.5706286159921926d, c: 0.7589279191414464d),
new NpgsqlTypes.NpgsqlLine(a: 0.6605423436334483d, b: 0.8926792448225925d, c: 0.43023941022329626d),
new NpgsqlTypes.NpgsqlLine(a: 0.8436628320038825d, b: 0.9271758626870623d, c: 0.6136984850688383d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3013784381225152d, b: 0.27893363362547485d, c: 0.16473252812313233d),
new NpgsqlTypes.NpgsqlLine(a: 0.2154380802059438d, b: 0.5999671607844952d, c: 0.6058372869507977d),
new NpgsqlTypes.NpgsqlLine(a: 0.4410959520879125d, b: 0.14539395006617373d, c: 0.9038332392317869d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.014944458222297397d, b: 0.8974093894360329d, c: 0.9463987809240673d),
new NpgsqlTypes.NpgsqlLine(a: 0.7060750140435083d, b: 0.28897092922856216d, c: 0.040118700251040584d),
new NpgsqlTypes.NpgsqlLine(a: 0.11412563547687782d, b: 0.46461506577456313d, c: 0.26916258407424776d),
new NpgsqlTypes.NpgsqlLine(a: 0.7192468434941057d, b: 0.5175235399623045d, c: 0.5443817823367694d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9584002001208713d, b: 0.3194458754752094d, c: 0.0327982726400009d),
new NpgsqlTypes.NpgsqlLine(a: 0.6341702698978705d, b: 0.5233733488365261d, c: 0.917454160387857d),
new NpgsqlTypes.NpgsqlLine(a: 0.12971207524815143d, b: 0.30960158210508104d, c: 0.31452873059602915d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4268858798317303d, b: 0.4255740822301992d, c: 0.4620145967834065d),
new NpgsqlTypes.NpgsqlLine(a: 0.5926046096260338d, b: 0.7382485912499949d, c: 0.39846439776051945d),
new NpgsqlTypes.NpgsqlLine(a: 0.31541311144437756d, b: 0.9808388946867497d, c: 0.060490052812429584d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31258563136418727d, b: 0.9148646530373555d, c: 0.6104343294867995d),
new NpgsqlTypes.NpgsqlLine(a: 0.07142593178314505d, b: 0.733247951819668d, c: 0.5493896437786496d),
new NpgsqlTypes.NpgsqlLine(a: 0.17454490308435466d, b: 0.21316728971150822d, c: 0.4131429054066076d),
new NpgsqlTypes.NpgsqlLine(a: 0.3425079512384439d, b: 0.08106059585833014d, c: 0.3173204775215589d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34998845007608625d, b: 0.7064151399912989d, c: 0.24709476922136886d),
new NpgsqlTypes.NpgsqlLine(a: 0.028099729809688445d, b: 0.6120694512243114d, c: 0.0412893236486469d),
new NpgsqlTypes.NpgsqlLine(a: 0.7804418936505916d, b: 0.8680907841815395d, c: 0.5175798171186334d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14217823333174495d, b: 0.6495968215406965d, c: 0.8422823420585972d),
new NpgsqlTypes.NpgsqlLine(a: 0.9191690351117545d, b: 0.11802243645920107d, c: 0.2993292684625156d),
new NpgsqlTypes.NpgsqlLine(a: 0.36381073994152835d, b: 0.39232975996098995d, c: 0.5568859919010766d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.47779951477148286d, b: 0.47491973897291706d, c: 0.2851056921414631d),
new NpgsqlTypes.NpgsqlLine(a: 0.8368405093671356d, b: 0.12728109488727024d, c: 0.23414692188391673d),
new NpgsqlTypes.NpgsqlLine(a: 0.13190607778473895d, b: 0.8588832935510841d, c: 0.024605117506637963d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3754601579047234d, b: 0.7019736902493583d, c: 0.6018498806871034d),
new NpgsqlTypes.NpgsqlLine(a: 0.4696730508309137d, b: 0.8292092563145486d, c: 0.3004742146764573d),
new NpgsqlTypes.NpgsqlLine(a: 0.5629272266012815d, b: 0.34295400594679004d, c: 0.5827896280262786d),
new NpgsqlTypes.NpgsqlLine(a: 0.979996701163126d, b: 0.2712645686367857d, c: 0.5389070248968139d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5320084689346111d, b: 0.021068569831585338d, c: 0.3268813332873036d),
new NpgsqlTypes.NpgsqlLine(a: 0.6454196379965618d, b: 0.3312852300908956d, c: 0.28849371606341d),
new NpgsqlTypes.NpgsqlLine(a: 0.8904941730348557d, b: 0.8099840715266755d, c: 0.292373771696566d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5967274339791325d, b: 0.10365940097463067d, c: 0.7645644910033312d),
new NpgsqlTypes.NpgsqlLine(a: 0.7875515856376649d, b: 0.21895268585710448d, c: 0.9452229279277168d),
new NpgsqlTypes.NpgsqlLine(a: 0.5031136752043986d, b: 0.4861056087176634d, c: 0.9964244986924432d),
new NpgsqlTypes.NpgsqlLine(a: 0.5526368406595165d, b: 0.43581755088057206d, c: 0.4482477411356992d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9979197370688916d, b: 0.4165980692204002d, c: 0.27456194409111245d),
new NpgsqlTypes.NpgsqlLine(a: 0.04282132514416981d, b: 0.5100024753565474d, c: 0.7989554142288187d),
new NpgsqlTypes.NpgsqlLine(a: 0.6507937286129699d, b: 0.9173873101956652d, c: 0.8819210261726548d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8127839030778277d, b: 0.3086495591898001d, c: 0.4208222660617025d),
new NpgsqlTypes.NpgsqlLine(a: 0.5890891139202831d, b: 0.002444629709657309d, c: 0.33506925561356715d),
new NpgsqlTypes.NpgsqlLine(a: 0.1303176012617837d, b: 0.6252929722883176d, c: 0.5347481837925352d),
new NpgsqlTypes.NpgsqlLine(a: 0.4579011371994236d, b: 0.6629749291434203d, c: 0.40231635080298367d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.010305401118892887d, b: 0.11197265098538689d, c: 0.37105721236987177d),
new NpgsqlTypes.NpgsqlLine(a: 0.5020202702959534d, b: 0.7494287633399564d, c: 0.6128891379534612d),
new NpgsqlTypes.NpgsqlLine(a: 0.9232861632220525d, b: 0.514633532487812d, c: 0.25648817750524044d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12225340275430874d, b: 0.3162285173712026d, c: 0.4345729834398373d),
new NpgsqlTypes.NpgsqlLine(a: 0.7641223988926914d, b: 0.40259401181534216d, c: 0.7169570932419959d),
new NpgsqlTypes.NpgsqlLine(a: 0.6522550018594948d, b: 0.634347024042747d, c: 0.15932233189627798d),
new NpgsqlTypes.NpgsqlLine(a: 0.6892915548640771d, b: 0.7866642529148268d, c: 0.9173640234167418d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.024481541425782516d, b: 0.224018326538324d, c: 0.731128543419053d),
new NpgsqlTypes.NpgsqlLine(a: 0.7728197950349385d, b: 0.8441553912142936d, c: 0.07276148683905403d),
new NpgsqlTypes.NpgsqlLine(a: 0.09150162128988237d, b: 0.1448529693568137d, c: 0.5289365020636582d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49768982328551703d, b: 0.8047441524190195d, c: 0.44818213724748057d),
new NpgsqlTypes.NpgsqlLine(a: 0.09129322541530294d, b: 0.7908930374145682d, c: 0.98575060643456d),
new NpgsqlTypes.NpgsqlLine(a: 0.18780792489686182d, b: 0.18284995164887619d, c: 0.4274950371974795d),
new NpgsqlTypes.NpgsqlLine(a: 0.8869189689296552d, b: 0.2260786965778836d, c: 0.2070254447308728d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9725236232811102d, b: 0.3457232538822089d, c: 0.23906105895303265d),
new NpgsqlTypes.NpgsqlLine(a: 0.2485687632975221d, b: 0.22775853527154255d, c: 0.9906743327076207d),
new NpgsqlTypes.NpgsqlLine(a: 0.8915158835739992d, b: 0.11312596216344939d, c: 0.1082343836545473d),
new NpgsqlTypes.NpgsqlLine(a: 0.11270693086926398d, b: 0.955947740773507d, c: 0.881771392171624d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7736470962849653d, b: 0.6073622953484215d, c: 0.8778673731957722d),
new NpgsqlTypes.NpgsqlLine(a: 0.035659130781441783d, b: 0.02974162347793685d, c: 0.4678523739504591d),
new NpgsqlTypes.NpgsqlLine(a: 0.31258046064242373d, b: 0.06527191461765935d, c: 0.7601014912998034d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 3.7696299903133834E-05d, b: 0.42454973537963936d, c: 0.7025366799933718d),
new NpgsqlTypes.NpgsqlLine(a: 0.8032807834358568d, b: 0.5636107006423514d, c: 0.21676418089083171d),
new NpgsqlTypes.NpgsqlLine(a: 0.9353341588026306d, b: 0.919619789792326d, c: 0.26927239039916484d),
new NpgsqlTypes.NpgsqlLine(a: 0.7038289270362467d, b: 0.44334937892948434d, c: 0.211637842300198d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4964002787910988d, b: 0.6442633824489138d, c: 0.5738247419247893d),
new NpgsqlTypes.NpgsqlLine(a: 0.6533023784632072d, b: 0.9597996442629041d, c: 0.354807176577816d),
new NpgsqlTypes.NpgsqlLine(a: 0.4028415804934068d, b: 0.6607363109210409d, c: 0.901616246478559d),
new NpgsqlTypes.NpgsqlLine(a: 0.8883785909223809d, b: 0.8087830579151123d, c: 0.8157785875826965d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09261737721465846d, b: 0.18518226596489273d, c: 0.009672728049105683d),
new NpgsqlTypes.NpgsqlLine(a: 0.5200037802653198d, b: 0.9017623419306537d, c: 0.7147673922623532d),
new NpgsqlTypes.NpgsqlLine(a: 0.7863839693567045d, b: 0.31810002961997474d, c: 0.13799088009125293d),
new NpgsqlTypes.NpgsqlLine(a: 0.5710013121257878d, b: 0.30922333582276185d, c: 0.5252982037953945d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6468045124786427d, b: 0.22375078548111982d, c: 0.8311614348424605d),
new NpgsqlTypes.NpgsqlLine(a: 0.3856400755900916d, b: 0.5384565649125638d, c: 0.8244594959880456d),
new NpgsqlTypes.NpgsqlLine(a: 0.822636424951318d, b: 0.014282346967394388d, c: 0.9216856464466304d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9675199013255874d, b: 0.4588962397071582d, c: 0.7536370511935597d),
new NpgsqlTypes.NpgsqlLine(a: 0.12440599928513352d, b: 0.23108634904202507d, c: 0.712496538074205d),
new NpgsqlTypes.NpgsqlLine(a: 0.5902074539115645d, b: 0.11335410983096939d, c: 0.9899955422755321d),
new NpgsqlTypes.NpgsqlLine(a: 0.6916460218326757d, b: 0.862320579559758d, c: 0.47554138135551804d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9349644184846744d, b: 0.7807193202672826d, c: 0.06390031019744313d),
new NpgsqlTypes.NpgsqlLine(a: 0.9402029005425364d, b: 0.4320918095932399d, c: 0.22299703525728287d),
new NpgsqlTypes.NpgsqlLine(a: 0.9534652960995897d, b: 0.49764500517295573d, c: 0.8007374338613179d),
new NpgsqlTypes.NpgsqlLine(a: 0.44231424352675497d, b: 0.940307387077784d, c: 0.6606644925555695d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49485882125154135d, b: 0.016380371870443056d, c: 0.008347895695926533d),
new NpgsqlTypes.NpgsqlLine(a: 0.15851296091476574d, b: 0.5185848318588695d, c: 0.7527986324517963d),
new NpgsqlTypes.NpgsqlLine(a: 0.5570082366556628d, b: 0.3069029094004305d, c: 0.41247443267904393d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.845932748610794d, b: 0.9816279173636017d, c: 0.19331132051358002d),
new NpgsqlTypes.NpgsqlLine(a: 0.9722029919217139d, b: 0.18838533287386539d, c: 0.012466513116276112d),
new NpgsqlTypes.NpgsqlLine(a: 0.7609839564063838d, b: 0.3914986627444075d, c: 0.7486776566755869d),
new NpgsqlTypes.NpgsqlLine(a: 0.3052499154866434d, b: 0.9181998981291529d, c: 0.9296912438528735d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2623187400623932d, b: 0.41774026500659234d, c: 0.04979645164766744d),
new NpgsqlTypes.NpgsqlLine(a: 0.31898315552839074d, b: 0.24890936477075865d, c: 0.44959267095326005d),
new NpgsqlTypes.NpgsqlLine(a: 0.40659252881014596d, b: 0.5972631717664026d, c: 0.2500014465415501d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4734413938101768d, b: 0.5377733480945686d, c: 0.39188805471792154d),
new NpgsqlTypes.NpgsqlLine(a: 0.4510572974042085d, b: 0.3139753811577044d, c: 0.3319127442304576d),
new NpgsqlTypes.NpgsqlLine(a: 0.24891038144472166d, b: 0.49367716946382223d, c: 0.2812534237126203d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9161568676849111d, b: 0.9996253981523405d, c: 0.7910989979216412d),
new NpgsqlTypes.NpgsqlLine(a: 0.11349725312552161d, b: 0.4805945798546235d, c: 0.373534320300011d),
new NpgsqlTypes.NpgsqlLine(a: 0.9963577790524911d, b: 0.5247054328863301d, c: 0.12784867176104608d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6177830623834164d, b: 0.9641250759607262d, c: 0.09104955985630825d),
new NpgsqlTypes.NpgsqlLine(a: 0.982088441748743d, b: 0.03882608117027253d, c: 0.3589128791896574d),
new NpgsqlTypes.NpgsqlLine(a: 0.6936240210780479d, b: 0.27681347701872905d, c: 0.6542405942864707d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4252662549655565d, b: 0.07069357065232207d, c: 0.3700903259866496d),
new NpgsqlTypes.NpgsqlLine(a: 0.6685007794391538d, b: 0.7790965188293622d, c: 0.8892727217010398d),
new NpgsqlTypes.NpgsqlLine(a: 0.8353479187474846d, b: 0.7458514520304399d, c: 0.3841019563692617d),
new NpgsqlTypes.NpgsqlLine(a: 0.13924312615387002d, b: 0.5003835890009123d, c: 0.7776854450039238d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.273923895076562d, b: 0.4038168204877981d, c: 0.07479490601316963d),
new NpgsqlTypes.NpgsqlLine(a: 0.19311508450322346d, b: 0.013877005283649102d, c: 0.07798543058326246d),
new NpgsqlTypes.NpgsqlLine(a: 0.32122668200167714d, b: 0.5092445352262656d, c: 0.800648921349491d),
new NpgsqlTypes.NpgsqlLine(a: 0.3686823551928805d, b: 0.37959393879802517d, c: 0.7180001944425931d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26412537249005563d, b: 0.2633815362858334d, c: 0.6291468603806417d),
new NpgsqlTypes.NpgsqlLine(a: 0.7368007735783166d, b: 0.26447184616962094d, c: 0.1156877490269933d),
new NpgsqlTypes.NpgsqlLine(a: 0.29312144712791066d, b: 0.9543180854946159d, c: 0.9963888839329298d),
new NpgsqlTypes.NpgsqlLine(a: 0.16815299618363544d, b: 0.852677091525865d, c: 0.5434382971859416d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 75, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 57, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 79, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 113, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 172, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 166))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 66, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI), typeof(NpgsqlLinelineArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                await ((INpgsqlLineArraylineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                ((INpgsqlLineArraylineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

