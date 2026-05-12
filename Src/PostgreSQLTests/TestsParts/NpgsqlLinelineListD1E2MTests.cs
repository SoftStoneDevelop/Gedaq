

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8265081467235273d, b: 0.6323364870532179d, c: 0.41342844877798945d),

new NpgsqlTypes.NpgsqlLine(a: 0.8582201240396735d, b: 0.03833305788693275d, c: 0.0025316635370241647d),

new NpgsqlTypes.NpgsqlLine(a: 0.7352314029784613d, b: 0.29068620871028306d, c: 0.25073987098555506d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1085669542235046d, b: 0.3183422049599023d, c: 0.7025012830453917d),

new NpgsqlTypes.NpgsqlLine(a: 0.7830140413218853d, b: 0.7836456774109188d, c: 0.035197121715000224d),

new NpgsqlTypes.NpgsqlLine(a: 0.0488270968811817d, b: 0.8859128718048243d, c: 0.8497528572088517d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6630817303820328d, b: 0.07923467181577126d, c: 0.3968184996118067d),

new NpgsqlTypes.NpgsqlLine(a: 0.047115765044008606d, b: 0.2908882506439572d, c: 0.5284315622265475d),

new NpgsqlTypes.NpgsqlLine(a: 0.47709581059122974d, b: 0.3230219483892979d, c: 0.46298138404644407d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6890989718106607d, b: 0.8996626939287595d, c: 0.24838211537751642d),

new NpgsqlTypes.NpgsqlLine(a: 0.6278323032504303d, b: 0.5363571686932076d, c: 0.17453316276609576d),

new NpgsqlTypes.NpgsqlLine(a: 0.9542710890554901d, b: 0.9945504375227194d, c: 0.6868774104232552d),

new NpgsqlTypes.NpgsqlLine(a: 0.1819021917889483d, b: 0.13111987504934786d, c: 0.3700536284909395d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4822894470374851d, b: 0.6374735013349839d, c: 0.7856875636337004d),

new NpgsqlTypes.NpgsqlLine(a: 0.6125282816966369d, b: 0.8655789274128548d, c: 0.9910543024918891d),

new NpgsqlTypes.NpgsqlLine(a: 0.8881670446900409d, b: 0.8924148972472006d, c: 0.029787981908102834d),

new NpgsqlTypes.NpgsqlLine(a: 0.9033580096172317d, b: 0.9260180907497d, c: 0.12906463118693945d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5054537732915443d, b: 0.051350765946252874d, c: 0.662063044333602d),

new NpgsqlTypes.NpgsqlLine(a: 0.798157191642421d, b: 0.3922466979587764d, c: 0.8972182563781905d),

new NpgsqlTypes.NpgsqlLine(a: 0.4737143117089355d, b: 0.2857365425063134d, c: 0.11006235241691897d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8361040816443199d, b: 0.9427845378724189d, c: 0.5117123087086994d),

new NpgsqlTypes.NpgsqlLine(a: 0.9339376118378365d, b: 0.46909277059840526d, c: 0.9012394809297416d),

new NpgsqlTypes.NpgsqlLine(a: 0.48515785320261995d, b: 0.9311558634735217d, c: 0.265591619040377d),

new NpgsqlTypes.NpgsqlLine(a: 0.6300391145231867d, b: 0.7059528469923824d, c: 0.19847165902333697d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4217805504755998d, b: 0.7847505311028173d, c: 0.16072236767091397d),

new NpgsqlTypes.NpgsqlLine(a: 0.9427395536790423d, b: 0.3394231080470723d, c: 0.5770264620855949d),

new NpgsqlTypes.NpgsqlLine(a: 0.6686583098745001d, b: 0.711082716136697d, c: 0.8518914395011676d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.404927804778486d, b: 0.43934746574679184d, c: 0.20978620299999606d),

new NpgsqlTypes.NpgsqlLine(a: 0.8692303085374357d, b: 0.5610639495024426d, c: 0.28656716746220456d),

new NpgsqlTypes.NpgsqlLine(a: 0.19830625348399167d, b: 0.4654422390363262d, c: 0.33733638478002403d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5344779748846797d, b: 0.326923057119479d, c: 0.41853405184870873d),

new NpgsqlTypes.NpgsqlLine(a: 0.09279395163239967d, b: 0.5001895642567317d, c: 0.39933252899420135d),

new NpgsqlTypes.NpgsqlLine(a: 0.9201417776416194d, b: 0.5575490285033102d, c: 0.9806721711796356d),

new NpgsqlTypes.NpgsqlLine(a: 0.5919869601643485d, b: 0.26754044320581694d, c: 0.6727660156670835d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02742179880864848d, b: 0.04973974143053972d, c: 0.6752791091685494d),

new NpgsqlTypes.NpgsqlLine(a: 0.37273115054198835d, b: 0.9172238243986373d, c: 0.9499355585418163d),

new NpgsqlTypes.NpgsqlLine(a: 0.35741520461237164d, b: 0.0854687888490383d, c: 0.01926800286096131d),

new NpgsqlTypes.NpgsqlLine(a: 0.6932390865349988d, b: 0.7324682163674685d, c: 0.7508187831712015d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4645358948277054d, b: 0.6345002219928594d, c: 0.019761879805802574d),

new NpgsqlTypes.NpgsqlLine(a: 0.4431538397851307d, b: 0.25208559434118716d, c: 0.6780710832756204d),

new NpgsqlTypes.NpgsqlLine(a: 0.045634832523954505d, b: 0.11043778448260844d, c: 0.9328760028913325d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1640096547346307d, b: 0.3732821802161911d, c: 0.9356268095217437d),

new NpgsqlTypes.NpgsqlLine(a: 0.5688973824209579d, b: 0.8055434307177436d, c: 0.8026414584716407d),

new NpgsqlTypes.NpgsqlLine(a: 0.08119766930029393d, b: 0.5150165141549753d, c: 0.8533741772900787d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14648341325541803d, b: 0.5887366274995743d, c: 0.9399387718114682d),

new NpgsqlTypes.NpgsqlLine(a: 0.5987918365719176d, b: 0.8519067044656063d, c: 0.9302191411143097d),

new NpgsqlTypes.NpgsqlLine(a: 0.8443087914733066d, b: 0.9890322125660291d, c: 0.2736714325200654d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9508951163620564d, b: 0.3107623418399693d, c: 0.7180546494943265d),

new NpgsqlTypes.NpgsqlLine(a: 0.5769294033437592d, b: 0.09568104686673773d, c: 0.680414913956382d),

new NpgsqlTypes.NpgsqlLine(a: 0.9470242929662753d, b: 0.5400041108546149d, c: 0.986426573457524d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.986555770325843d, b: 0.187600565100277d, c: 0.7015822770916853d),

new NpgsqlTypes.NpgsqlLine(a: 0.11874285672331075d, b: 0.5106073277691158d, c: 0.7744974619131815d),

new NpgsqlTypes.NpgsqlLine(a: 0.41666264527256325d, b: 0.9907062283101589d, c: 0.7366891165068792d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6587397909761783d, b: 0.6999061031293712d, c: 0.3549329646525641d),

new NpgsqlTypes.NpgsqlLine(a: 0.43164767637271195d, b: 0.7858704336345715d, c: 0.36996367223437154d),

new NpgsqlTypes.NpgsqlLine(a: 0.9733666536551586d, b: 0.15090227874688578d, c: 0.3575197263268205d),

new NpgsqlTypes.NpgsqlLine(a: 0.945286090061962d, b: 0.8413025740480587d, c: 0.626906553325885d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.94939071018934d, b: 0.4576312548666689d, c: 0.8208090745049329d),

new NpgsqlTypes.NpgsqlLine(a: 0.1156238053120886d, b: 0.5103025296538923d, c: 0.4890469572966065d),

new NpgsqlTypes.NpgsqlLine(a: 0.7242727832376846d, b: 0.6580126640349439d, c: 0.6197987379464137d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7642276279697395d, b: 0.25779350941918355d, c: 0.9335292881216677d),

new NpgsqlTypes.NpgsqlLine(a: 0.5800888353177438d, b: 0.1879864384718276d, c: 0.570114600701497d),

new NpgsqlTypes.NpgsqlLine(a: 0.36032273421331484d, b: 0.6457055982666566d, c: 0.6257659113080205d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43304937728787185d, b: 0.5278970781214567d, c: 0.3376328537170462d),

new NpgsqlTypes.NpgsqlLine(a: 0.2018239764437545d, b: 0.4752733320261111d, c: 0.4763508502741626d),

new NpgsqlTypes.NpgsqlLine(a: 0.3684934029131618d, b: 0.13481116294448592d, c: 0.717062358251758d),

new NpgsqlTypes.NpgsqlLine(a: 0.13403437770109028d, b: 0.548861834023546d, c: 0.20711623417990754d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16108231173104726d, b: 0.7022179956744866d, c: 0.8195547503952667d),

new NpgsqlTypes.NpgsqlLine(a: 0.03919029941671892d, b: 0.47349508313939204d, c: 0.24903373916200633d),

new NpgsqlTypes.NpgsqlLine(a: 0.7005558695548952d, b: 0.5510126202318274d, c: 0.6642184734794566d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06437063707298063d, b: 0.8695818275742857d, c: 0.5941030002546305d),

new NpgsqlTypes.NpgsqlLine(a: 0.8538333946668758d, b: 0.10934075022378087d, c: 0.632552375271704d),

new NpgsqlTypes.NpgsqlLine(a: 0.02576220450075828d, b: 0.002792625531026327d, c: 0.7434463627194406d),

new NpgsqlTypes.NpgsqlLine(a: 0.8975381185520498d, b: 0.7801576541964409d, c: 0.07249178413574875d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22848931002624007d, b: 0.5410969256501389d, c: 0.6539548740334069d),

new NpgsqlTypes.NpgsqlLine(a: 0.3411207759295327d, b: 0.0344391721652082d, c: 0.6333377828772973d),

new NpgsqlTypes.NpgsqlLine(a: 0.8334762967804524d, b: 0.9906672189324949d, c: 0.06288890258200908d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5890510612073193d, b: 0.298453102288771d, c: 0.11282770693642818d),

new NpgsqlTypes.NpgsqlLine(a: 0.946602917747996d, b: 0.7793582745163589d, c: 0.2972418630429432d),

new NpgsqlTypes.NpgsqlLine(a: 0.07963114947055938d, b: 0.7946694322257933d, c: 0.3753623651894128d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6317739066693715d, b: 0.4815628092274391d, c: 0.8060321558713289d),

new NpgsqlTypes.NpgsqlLine(a: 0.7878120047216148d, b: 0.8703582553533423d, c: 0.63690709668483d),

new NpgsqlTypes.NpgsqlLine(a: 0.3047240654876885d, b: 0.47139573706603666d, c: 0.25201381864443284d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0016233544405398481d, b: 0.07004618829932052d, c: 0.9534744559040452d),

new NpgsqlTypes.NpgsqlLine(a: 0.18961802068197953d, b: 0.43596344955587096d, c: 0.21428322310216197d),

new NpgsqlTypes.NpgsqlLine(a: 0.6271530925007772d, b: 0.8478849138069411d, c: 0.17714068266485172d),

new NpgsqlTypes.NpgsqlLine(a: 0.41464349855435245d, b: 0.33630136553721823d, c: 0.12475525893312844d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31827836496579787d, b: 0.7280673206084833d, c: 0.2666399468910374d),

new NpgsqlTypes.NpgsqlLine(a: 0.2988394133245875d, b: 0.741334678093129d, c: 0.41786588126993074d),

new NpgsqlTypes.NpgsqlLine(a: 0.4907731827958145d, b: 0.5937064024190423d, c: 0.4073119462561383d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4152146454486024d, b: 0.9929449981937473d, c: 0.49272105097349506d),

new NpgsqlTypes.NpgsqlLine(a: 0.29255191121372837d, b: 0.5167686673466815d, c: 0.647722969461557d),

new NpgsqlTypes.NpgsqlLine(a: 0.7705861106566048d, b: 0.39128124165615996d, c: 0.0480070407627563d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5245867797411069d, b: 0.19220903349924867d, c: 0.20911871826758932d),

new NpgsqlTypes.NpgsqlLine(a: 0.6143165904654428d, b: 0.13735247384994864d, c: 0.916240796688948d),

new NpgsqlTypes.NpgsqlLine(a: 0.02239902258798665d, b: 0.3012079696607458d, c: 0.7781916443459558d),

new NpgsqlTypes.NpgsqlLine(a: 0.1392819930923216d, b: 0.6959214657979708d, c: 0.14781284202014233d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18004487888285226d, b: 0.401685405164652d, c: 0.7643222110265288d),

new NpgsqlTypes.NpgsqlLine(a: 0.8147162053048177d, b: 0.3036608569012432d, c: 0.6082879466128173d),

new NpgsqlTypes.NpgsqlLine(a: 0.11629319193879673d, b: 0.18885885251275225d, c: 0.026242944343081276d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7054236268997406d, b: 0.8469620312408517d, c: 0.41090023684140364d),

new NpgsqlTypes.NpgsqlLine(a: 0.43554136880782823d, b: 0.2868412850747949d, c: 0.18238264750635602d),

new NpgsqlTypes.NpgsqlLine(a: 0.23550017308800764d, b: 0.7018604468294025d, c: 0.9864997180691573d),

new NpgsqlTypes.NpgsqlLine(a: 0.2828117718448422d, b: 0.01620921963569477d, c: 0.18290697719944615d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02937062769095211d, b: 0.8215197450181664d, c: 0.5250643759231686d),

new NpgsqlTypes.NpgsqlLine(a: 0.5913498030546798d, b: 0.6033853359109967d, c: 0.9033842267568822d),

new NpgsqlTypes.NpgsqlLine(a: 0.13232216765736216d, b: 0.5892974829755433d, c: 0.5969516224752675d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.879790395671572d, b: 0.2501022576331102d, c: 0.12631275321370894d),

new NpgsqlTypes.NpgsqlLine(a: 0.757060073184331d, b: 0.06896600046612389d, c: 0.9473143161800243d),

new NpgsqlTypes.NpgsqlLine(a: 0.5297989673423503d, b: 0.8673602010350018d, c: 0.4681721348383553d),

new NpgsqlTypes.NpgsqlLine(a: 0.3374560304623271d, b: 0.5658564716099309d, c: 0.28777621748820437d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.650118729381738d, b: 0.506601226615473d, c: 0.252676670311497d),

new NpgsqlTypes.NpgsqlLine(a: 0.4659069520281862d, b: 0.36076483402965465d, c: 0.5049564951191551d),

new NpgsqlTypes.NpgsqlLine(a: 0.2793732800086063d, b: 0.4214638042570328d, c: 0.32918470694189916d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23514777216155913d, b: 0.8623355397084367d, c: 0.6667601857304897d),

new NpgsqlTypes.NpgsqlLine(a: 0.5111671888100893d, b: 0.41598861576053947d, c: 0.49857958455262663d),

new NpgsqlTypes.NpgsqlLine(a: 0.7269633768103728d, b: 0.23687887209029468d, c: 0.028883811341921417d),

new NpgsqlTypes.NpgsqlLine(a: 0.4171936095569233d, b: 0.7968930246533269d, c: 0.49858337352102855d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44766148370726944d, b: 0.5799080678273715d, c: 0.8210765140135972d),

new NpgsqlTypes.NpgsqlLine(a: 0.3722946811965757d, b: 0.8848371735381503d, c: 0.2779187342612903d),

new NpgsqlTypes.NpgsqlLine(a: 0.18905705880935575d, b: 0.8317845650014429d, c: 0.8932770134861411d),

new NpgsqlTypes.NpgsqlLine(a: 0.2583332326561303d, b: 0.8331210734272332d, c: 0.576038516856996d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27719982853446723d, b: 0.9479285910377229d, c: 0.9129508057449784d),

new NpgsqlTypes.NpgsqlLine(a: 0.9637259882458655d, b: 0.44320091387383165d, c: 0.9421846345877638d),

new NpgsqlTypes.NpgsqlLine(a: 0.9708523172680699d, b: 0.31282974802333874d, c: 0.1663448697525136d),

new NpgsqlTypes.NpgsqlLine(a: 0.23383595676772317d, b: 0.45995478081703567d, c: 0.18128806149978327d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8148787945557301d, b: 0.06988859270702641d, c: 0.5639311492844858d),

new NpgsqlTypes.NpgsqlLine(a: 0.34254337922382894d, b: 0.713223879672704d, c: 0.9464061617109333d),

new NpgsqlTypes.NpgsqlLine(a: 0.4964170159517104d, b: 0.08800374576869885d, c: 0.2707844149812738d),

new NpgsqlTypes.NpgsqlLine(a: 0.9371950672293577d, b: 0.23657982275811285d, c: 0.3822514395661991d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.38819935657160376d, b: 0.7516830067516542d, c: 0.9884612485839712d),

new NpgsqlTypes.NpgsqlLine(a: 0.5639583555958949d, b: 0.8223865313941274d, c: 0.3940531476969742d),

new NpgsqlTypes.NpgsqlLine(a: 0.08623854628268268d, b: 0.35665195379201053d, c: 0.2556629960310175d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.00648374046753708d, b: 0.22206037099236253d, c: 0.20250596974014057d),

new NpgsqlTypes.NpgsqlLine(a: 0.9740192806926219d, b: 0.6456636132849126d, c: 0.47797168834099346d),

new NpgsqlTypes.NpgsqlLine(a: 0.3332662761146763d, b: 0.4577625110259075d, c: 0.9468337434272021d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20146628426747848d, b: 0.6638159374163007d, c: 0.802462480183023d),

new NpgsqlTypes.NpgsqlLine(a: 0.4376763861868035d, b: 0.8012313575353952d, c: 0.9864765249646443d),

new NpgsqlTypes.NpgsqlLine(a: 0.2619487054578524d, b: 0.8774214152160377d, c: 0.8803875415500035d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02702163588311668d, b: 0.39037351472226145d, c: 0.5196751170007219d),

new NpgsqlTypes.NpgsqlLine(a: 0.566854510153004d, b: 0.10610897370398797d, c: 0.5314445822870623d),

new NpgsqlTypes.NpgsqlLine(a: 0.6971023105690639d, b: 0.9979773235924364d, c: 0.6704638604627751d),

new NpgsqlTypes.NpgsqlLine(a: 0.3562975791415728d, b: 0.7836033992327257d, c: 0.7254389144294611d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4778823475526063d, b: 0.6391305755002393d, c: 0.05586511912788006d),

new NpgsqlTypes.NpgsqlLine(a: 0.48440355068119345d, b: 0.213103865213084d, c: 0.29677440424047796d),

new NpgsqlTypes.NpgsqlLine(a: 0.2951448833309269d, b: 0.39724843526564013d, c: 0.15899697343090924d),

new NpgsqlTypes.NpgsqlLine(a: 0.9148598650854873d, b: 0.35005050133226157d, c: 0.445045580505834d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.434492871109888d, b: 0.5299704925022366d, c: 0.998981554022614d),

new NpgsqlTypes.NpgsqlLine(a: 0.0036447353698468854d, b: 0.78393038454334d, c: 0.30691825472682155d),

new NpgsqlTypes.NpgsqlLine(a: 0.556926643505605d, b: 0.9836520191068945d, c: 0.7469224470364597d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7658899622143339d, b: 0.6546656541310364d, c: 0.3808222799739224d),

new NpgsqlTypes.NpgsqlLine(a: 0.7512513088863696d, b: 0.3657136388514963d, c: 0.36319184415166283d),

new NpgsqlTypes.NpgsqlLine(a: 0.05901841082770798d, b: 0.8571912468052407d, c: 0.47469203786791936d),

new NpgsqlTypes.NpgsqlLine(a: 0.7594345177068491d, b: 0.7633144381717408d, c: 0.9250191854250917d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8687646297836407d, b: 0.7675180993752729d, c: 0.7434729639872796d),

new NpgsqlTypes.NpgsqlLine(a: 0.8939408970678762d, b: 0.4898159664511449d, c: 0.4349885619320937d),

new NpgsqlTypes.NpgsqlLine(a: 0.7396238033345642d, b: 0.5738819121074127d, c: 0.6706135077669859d),

new NpgsqlTypes.NpgsqlLine(a: 0.9249915483337788d, b: 0.026829543460305638d, c: 0.9363959199959122d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4296345799446333d, b: 0.5050602689955451d, c: 0.43443861662375116d),

new NpgsqlTypes.NpgsqlLine(a: 0.00013070080996868683d, b: 0.6339819623722588d, c: 0.7941850114202874d),

new NpgsqlTypes.NpgsqlLine(a: 0.02491210277955358d, b: 0.3906303961617198d, c: 0.5213967734791892d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.308647160831508d, b: 0.8820760356200771d, c: 0.7933293178273855d),

new NpgsqlTypes.NpgsqlLine(a: 0.4705582155663741d, b: 0.25019817767846386d, c: 0.27348398527477114d),

new NpgsqlTypes.NpgsqlLine(a: 0.28516834864510765d, b: 0.8031119101190828d, c: 0.12473564846703789d),

new NpgsqlTypes.NpgsqlLine(a: 0.8520501563753364d, b: 0.42856961600834065d, c: 0.14705451957549998d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44098823563994216d, b: 0.42684975220424815d, c: 0.7888296687015618d),

new NpgsqlTypes.NpgsqlLine(a: 0.3505393862071089d, b: 0.597411239397519d, c: 0.9596836073038955d),

new NpgsqlTypes.NpgsqlLine(a: 0.8175618914843065d, b: 0.58198643099735d, c: 0.39669887091984635d),

new NpgsqlTypes.NpgsqlLine(a: 0.41159959092373144d, b: 0.5291256281707443d, c: 0.8945264605929477d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2943310625289455d, b: 0.7442954926133367d, c: 0.8125369039277585d),

new NpgsqlTypes.NpgsqlLine(a: 0.2501480805182975d, b: 0.3300263247645763d, c: 0.09413411427278418d),

new NpgsqlTypes.NpgsqlLine(a: 0.7898636189490313d, b: 0.6738980645785103d, c: 0.6033271702092268d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.227629427287512d, b: 0.7399216840134445d, c: 0.4167477106393125d),

new NpgsqlTypes.NpgsqlLine(a: 0.7929600573902145d, b: 0.737362152921779d, c: 0.1814940813762127d),

new NpgsqlTypes.NpgsqlLine(a: 0.8556006105304521d, b: 0.3683766870914216d, c: 0.5234607920408223d),

new NpgsqlTypes.NpgsqlLine(a: 0.6341890642183465d, b: 0.5323063050799945d, c: 0.61759126867891d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7063529083159854d, b: 0.7383857630420617d, c: 0.0012878532976797752d),

new NpgsqlTypes.NpgsqlLine(a: 0.3638436237582774d, b: 0.26925096161057605d, c: 0.22360507982525846d),

new NpgsqlTypes.NpgsqlLine(a: 0.45041821455428d, b: 0.611254656717748d, c: 0.036297193839735176d),

new NpgsqlTypes.NpgsqlLine(a: 0.3376926389675039d, b: 0.5507362295860769d, c: 0.7029283094632184d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8911546814311181d, b: 0.993075393151115d, c: 0.05656083001837675d),

new NpgsqlTypes.NpgsqlLine(a: 0.2517239619533138d, b: 0.5251327693121861d, c: 0.8730825850501311d),

new NpgsqlTypes.NpgsqlLine(a: 0.3470225566462465d, b: 0.5190545677504581d, c: 0.4116387145821391d),

new NpgsqlTypes.NpgsqlLine(a: 0.4302120387630639d, b: 0.0066043626919174425d, c: 0.5695727000632476d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8135736578861865d, b: 0.7674521533260286d, c: 0.7938838183862564d),

new NpgsqlTypes.NpgsqlLine(a: 0.33202475334532333d, b: 0.6872586291365529d, c: 0.3785947806478681d),

new NpgsqlTypes.NpgsqlLine(a: 0.6383569638604398d, b: 0.022560838621689783d, c: 0.4841256704117102d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8052563460715688d, b: 0.045046145381686054d, c: 0.6190895814963344d),

new NpgsqlTypes.NpgsqlLine(a: 0.3886884096602593d, b: 0.312557476430123d, c: 0.8756707193052179d),

new NpgsqlTypes.NpgsqlLine(a: 0.3083347618693696d, b: 0.26023508553499963d, c: 0.538442670693248d),

new NpgsqlTypes.NpgsqlLine(a: 0.37215499997109425d, b: 0.4800111493757603d, c: 0.6378895283837173d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7605855887926071d, b: 0.8387695648680051d, c: 0.02671381768544656d),

new NpgsqlTypes.NpgsqlLine(a: 0.31922760853716026d, b: 0.6241588478558205d, c: 0.32691218112522746d),

new NpgsqlTypes.NpgsqlLine(a: 0.15601622939574233d, b: 0.9754399879262133d, c: 0.7664989280480511d),

new NpgsqlTypes.NpgsqlLine(a: 0.5851275488031663d, b: 0.4968566380632188d, c: 0.7891179899756745d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8273345785735485d, b: 0.7752498470246881d, c: 0.3970204493967524d),

new NpgsqlTypes.NpgsqlLine(a: 0.09413961103494883d, b: 0.7730837995530533d, c: 0.47953151089420787d),

new NpgsqlTypes.NpgsqlLine(a: 0.7491329741761631d, b: 0.9287953647676619d, c: 0.9081766010522397d),

new NpgsqlTypes.NpgsqlLine(a: 0.6566001014475439d, b: 0.17726960171201078d, c: 0.26404039613237396d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4553275246553371d, b: 0.1339477670136614d, c: 0.514958343319864d),

new NpgsqlTypes.NpgsqlLine(a: 0.7734667487615114d, b: 0.859959475779565d, c: 0.3038332227589092d),

new NpgsqlTypes.NpgsqlLine(a: 0.4369679049392815d, b: 0.5087249486644128d, c: 0.17369345608993247d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28563666154088996d, b: 0.6723113117316097d, c: 0.9011020166616387d),

new NpgsqlTypes.NpgsqlLine(a: 0.8522665961109676d, b: 0.3141935906280441d, c: 0.9712955892748361d),

new NpgsqlTypes.NpgsqlLine(a: 0.9111431438218465d, b: 0.2568918064110355d, c: 0.8187969677185702d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3702952017549823d, b: 0.2127665996334588d, c: 0.9790761625805011d),

new NpgsqlTypes.NpgsqlLine(a: 0.7062724773330192d, b: 0.29957572852865044d, c: 0.3334926485953078d),

new NpgsqlTypes.NpgsqlLine(a: 0.1379192953165559d, b: 0.8130549732932298d, c: 0.7746239409127741d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9198756483312228d, b: 0.532780143885864d, c: 0.7783343222521054d),

new NpgsqlTypes.NpgsqlLine(a: 0.2558183237140119d, b: 0.0034690269238940585d, c: 0.6775397159674333d),

new NpgsqlTypes.NpgsqlLine(a: 0.9106958348714156d, b: 0.13963567276358357d, c: 0.9880310422648396d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7422223640019758d, b: 0.9796495040448909d, c: 0.7683971688439865d),

new NpgsqlTypes.NpgsqlLine(a: 0.07807725758591288d, b: 0.4231572914191707d, c: 0.3812129037728945d),

new NpgsqlTypes.NpgsqlLine(a: 0.8171515936051231d, b: 0.7173058260270962d, c: 0.9292783527857681d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0038372773620365397d, b: 0.9590873985771928d, c: 0.261391924206837d),

new NpgsqlTypes.NpgsqlLine(a: 0.37913454837866334d, b: 0.9514564134166074d, c: 0.8282762479424167d),

new NpgsqlTypes.NpgsqlLine(a: 0.7512809019614375d, b: 0.11720272345109883d, c: 0.5766351763296123d),

new NpgsqlTypes.NpgsqlLine(a: 0.6843807779583497d, b: 0.0024388330317960394d, c: 0.9805587913600593d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6648962122053341d, b: 0.09877865675107189d, c: 0.8965491165137194d),

new NpgsqlTypes.NpgsqlLine(a: 0.4035464673115766d, b: 0.3692986504486212d, c: 0.7210295783079788d),

new NpgsqlTypes.NpgsqlLine(a: 0.3290830673043097d, b: 0.09302696108865194d, c: 0.48075495306395d),

new NpgsqlTypes.NpgsqlLine(a: 0.7116796907997858d, b: 0.4320697029470376d, c: 0.22114316754083796d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6897360822428521d, b: 0.4661246126765777d, c: 0.4092506217884362d),

new NpgsqlTypes.NpgsqlLine(a: 0.6169122931916289d, b: 0.4630183136318672d, c: 0.13794754593859304d),

new NpgsqlTypes.NpgsqlLine(a: 0.8332219148930817d, b: 0.8977896687032785d, c: 0.2638834994507646d),

new NpgsqlTypes.NpgsqlLine(a: 0.9703869694360856d, b: 0.2675149363442614d, c: 0.4384248428884825d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04190687235283874d, b: 0.09307535430532266d, c: 0.7099634106461592d),

new NpgsqlTypes.NpgsqlLine(a: 0.5178623419590405d, b: 0.2304996405259796d, c: 0.42651577967023224d),

new NpgsqlTypes.NpgsqlLine(a: 0.9611296510073709d, b: 0.1263153924709567d, c: 0.6274078056722628d),

new NpgsqlTypes.NpgsqlLine(a: 0.2872195535638129d, b: 0.9035656068911505d, c: 0.7621699370716208d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45445375798735954d, b: 0.10734666470993892d, c: 0.30799051362903485d),

new NpgsqlTypes.NpgsqlLine(a: 0.27767851366647645d, b: 0.7542923821390376d, c: 0.056778400330984136d),

new NpgsqlTypes.NpgsqlLine(a: 0.18207379968453352d, b: 0.5468307079801306d, c: 0.4228166557160352d),

new NpgsqlTypes.NpgsqlLine(a: 0.06997300831299025d, b: 0.41027050997333403d, c: 0.34237397868998587d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4525868028720619d, b: 0.9883341606849797d, c: 0.9410887602098186d),

new NpgsqlTypes.NpgsqlLine(a: 0.7489684691417433d, b: 0.21259935265166974d, c: 0.04260851470022642d),

new NpgsqlTypes.NpgsqlLine(a: 0.2815071382799538d, b: 0.06517172319911624d, c: 0.46152157986042897d),

new NpgsqlTypes.NpgsqlLine(a: 0.48641044154802915d, b: 0.4599828676825477d, c: 0.9118102750927383d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.276103996953704d, b: 0.0027745112952533013d, c: 0.5262339946415937d),

new NpgsqlTypes.NpgsqlLine(a: 0.5706759354828695d, b: 0.5088491522846341d, c: 0.9185638710669508d),

new NpgsqlTypes.NpgsqlLine(a: 0.9260085499985451d, b: 0.2101226401694818d, c: 0.5748371734328526d),

new NpgsqlTypes.NpgsqlLine(a: 0.4936816060073286d, b: 0.9078052771367733d, c: 0.6173483730972291d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05573186539766517d, b: 0.14431968012810215d, c: 0.8750333105691185d),

new NpgsqlTypes.NpgsqlLine(a: 0.01813213497425048d, b: 0.007349975611179893d, c: 0.503987691788924d),

new NpgsqlTypes.NpgsqlLine(a: 0.4594162469328148d, b: 0.8558060815513073d, c: 0.5628406790794743d),

new NpgsqlTypes.NpgsqlLine(a: 0.4092282148758766d, b: 0.8174856357253848d, c: 0.45409685086837004d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31655629438495425d, b: 0.7307586635515229d, c: 0.7863710921459376d),

new NpgsqlTypes.NpgsqlLine(a: 0.7408854296724777d, b: 0.0038131876018379085d, c: 0.7488196747987388d),

new NpgsqlTypes.NpgsqlLine(a: 0.02635341709309713d, b: 0.724359732782071d, c: 0.24656189329342104d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5436221071386051d, b: 0.011857752592752346d, c: 0.3225205696996013d),

new NpgsqlTypes.NpgsqlLine(a: 0.20490713666003668d, b: 0.5999441210190697d, c: 0.7103640656800927d),

new NpgsqlTypes.NpgsqlLine(a: 0.9287671409781436d, b: 0.8294145075384116d, c: 0.030090879270432414d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3682449486167737d, b: 0.8037327741502147d, c: 0.8762068519315963d),

new NpgsqlTypes.NpgsqlLine(a: 0.8599914553128745d, b: 0.2542045873020704d, c: 0.4672597597617677d),

new NpgsqlTypes.NpgsqlLine(a: 0.25468620479374504d, b: 0.05728326238717685d, c: 0.5714666999483485d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8433399647021838d, b: 0.7797136803843706d, c: 0.45554773375996727d),

new NpgsqlTypes.NpgsqlLine(a: 0.5800882453849905d, b: 0.12106549004206468d, c: 0.11322542115853074d),

new NpgsqlTypes.NpgsqlLine(a: 0.9488177974888842d, b: 0.8224751200319824d, c: 0.6415966884475406d),

new NpgsqlTypes.NpgsqlLine(a: 0.20683995706498592d, b: 0.8199243056137296d, c: 0.474128824195409d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35434237309403727d, b: 0.36279026413427684d, c: 0.4215125801727093d),

new NpgsqlTypes.NpgsqlLine(a: 0.8138282500265985d, b: 0.057157366396454745d, c: 0.20295486915300487d),

new NpgsqlTypes.NpgsqlLine(a: 0.8965356069213587d, b: 0.6068220785260031d, c: 0.22126656042705461d),

new NpgsqlTypes.NpgsqlLine(a: 0.7934137031458408d, b: 0.3406269290250904d, c: 0.7492919368743923d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5763029824127492d, b: 0.5257264321509695d, c: 0.5464863715125395d),

new NpgsqlTypes.NpgsqlLine(a: 0.944840411210283d, b: 0.7447882885187976d, c: 0.8691216902714088d),

new NpgsqlTypes.NpgsqlLine(a: 0.09208569799116961d, b: 0.04590964620353766d, c: 0.5476222272845174d),

new NpgsqlTypes.NpgsqlLine(a: 0.3144488590388834d, b: 0.8923424548247605d, c: 0.4266109680129615d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8311778841304487d, b: 0.974088270055985d, c: 0.9346173440113504d),

new NpgsqlTypes.NpgsqlLine(a: 0.40500621760149813d, b: 0.02791096670251636d, c: 0.11291003110981057d),

new NpgsqlTypes.NpgsqlLine(a: 0.09762332686652964d, b: 0.3634710435642905d, c: 0.19975767183756032d),

new NpgsqlTypes.NpgsqlLine(a: 0.8666421310698491d, b: 0.755454914112654d, c: 0.46935897461791654d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 200,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5975023767291034d, b: 0.566581137255387d, c: 0.6930291630006395d),

new NpgsqlTypes.NpgsqlLine(a: 0.14834529996753554d, b: 0.857161123433063d, c: 0.9340629780564578d),

new NpgsqlTypes.NpgsqlLine(a: 0.25019562457276057d, b: 0.5715087232821958d, c: 0.07784204235159331d),

new NpgsqlTypes.NpgsqlLine(a: 0.045828673692461575d, b: 0.9542825147665677d, c: 0.09754321412482503d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 192;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 179;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 143, query1, 187, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 68, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 154, query1, 187, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 21, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 124, query1, 187, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 192, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 143, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 162, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 11, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 50, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[13], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[14], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[15], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI), typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

