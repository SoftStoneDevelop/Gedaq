

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08141138960596805d, y: 0.37514729719563544d), radius: 0.6454271467146758d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44050926236875054d, y: 0.680029748360227d), radius: 0.310348731855406d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5181292651772487d, y: 0.0687850627999308d), radius: 0.1370489415764683d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7681883504283905d, y: 0.26205462060987994d), radius: 0.8739467261957309d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404577587852495d, y: 0.7115189472500469d), radius: 0.9462731140844527d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9397474351194232d, y: 0.4788542898141728d), radius: 0.05517894694794656d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2994221490117289d, y: 0.3132777932926093d), radius: 0.46792865420031915d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5532910019833283d, y: 0.2839674831742738d), radius: 0.1314453629107447d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.654703564501252d, y: 0.5206749237878101d), radius: 0.5557469799397605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5720014673370777d, y: 0.9620117468612092d), radius: 0.1501644884897907d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7339822443388055d, y: 0.7232702059311641d), radius: 0.936874358772881d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6135276658868802d, y: 0.31795712422827427d), radius: 0.8993948237283816d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4847440633704656d, y: 0.10590409510242826d), radius: 0.4375040624387504d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7560796284079391d, y: 0.27928026695368835d), radius: 0.5816477960315525d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11058917040084759d, y: 0.5007374941189071d), radius: 0.015751935622263846d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3185293515909001d, y: 0.2591925542851151d), radius: 0.6459685690856856d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3443611250542643d, y: 0.15698153227771117d), radius: 0.3878055208170538d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.248045020469978d, y: 0.4457771052564532d), radius: 0.3095429227463218d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6532487664882702d, y: 0.1961413199870886d), radius: 0.7870108246645572d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005425041496731953d, y: 0.48260093440546814d), radius: 0.40907943456582496d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11831485560960409d, y: 0.7311937405709342d), radius: 0.7783313596287428d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7655471676308659d, y: 0.5777932548887089d), radius: 0.16861482299735453d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6285535685770295d, y: 0.890783028934215d), radius: 0.9938867036102622d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9460426278773418d, y: 0.6695489614168066d), radius: 0.5171881601468785d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14011099191210896d, y: 0.22943166949548355d), radius: 0.7435766242174418d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44447922308974197d, y: 0.5340177311732102d), radius: 0.5087136314425161d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.581939809055915d, y: 0.07130487975153121d), radius: 0.7840352587780245d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.300966891715873d, y: 0.7102157574500018d), radius: 0.029645466011463117d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14196363355678399d, y: 0.8289556514707744d), radius: 0.1427809762816713d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44132445399884035d, y: 0.09731353482290217d), radius: 0.7757327579731774d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15140243851521584d, y: 0.2981658316877004d), radius: 0.5972539121403173d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010936993681700646d, y: 0.7304066022887638d), radius: 0.8726522058030801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11242374774643216d, y: 0.5241254554072466d), radius: 0.22922360240841633d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2891868650636765d, y: 0.49716714650328186d), radius: 0.8942181195424612d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05332869127247586d, y: 0.04321458997695338d), radius: 0.9546936695867957d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3484158827774405d, y: 0.6852639498351858d), radius: 0.26106208268261766d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8245845516283749d, y: 0.28793067009422824d), radius: 0.8800535396650568d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2740942677152901d, y: 0.6527804398993051d), radius: 0.7253837632234273d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7269266014165153d, y: 0.9293930653085273d), radius: 0.06769226357996572d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7290971668454995d, y: 0.060530918609190354d), radius: 0.299959755067726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7603149271460096d, y: 0.04939365071761892d), radius: 0.24174312163427492d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9556110451644967d, y: 0.5888250195906558d), radius: 0.9291302428189209d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6091340427738768d, y: 0.43194761670143966d), radius: 0.9193999508275417d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9333981021359705d, y: 0.16176588752550913d), radius: 0.14640927890026145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8959087098859773d, y: 0.3376612994181424d), radius: 0.1889779945655794d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.033654895380807126d, y: 0.047869092305888206d), radius: 0.42445396231896904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008642252688628393d, y: 0.5854615187868083d), radius: 0.3549612006015972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2464467392577936d, y: 0.541225383104207d), radius: 0.07267621668667801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5902731688573054d, y: 0.9782901494505746d), radius: 0.7000252547062494d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05599596423614184d, y: 0.32661273010207303d), radius: 0.8586902294338751d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39941168800732085d, y: 0.8021682876089894d), radius: 0.312818523110446d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7312970539287277d, y: 0.14126257685682908d), radius: 0.9637559046393767d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2789195583987619d, y: 0.8947861005891404d), radius: 0.04926450609477173d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37458682913039565d, y: 0.07026920936221459d), radius: 0.3495842494022673d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3404877234112511d, y: 0.18435667890033813d), radius: 0.0641613270246223d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4622043711466355d, y: 0.5152937767556696d), radius: 0.3140606176297761d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2050145384426738d, y: 0.27521220616377684d), radius: 0.06651575175843849d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7656491643321721d, y: 0.7767539294395465d), radius: 0.1445656109792962d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5185814876696073d, y: 0.3673073084273055d), radius: 0.23942627224497692d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4747363774146557d, y: 0.06147283983293261d), radius: 0.5128098538905236d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8239177644538053d, y: 0.1591200238233148d), radius: 0.5444549032602367d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5073646955991227d, y: 0.3353476592253709d), radius: 0.4240060785552183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9098665337395124d, y: 0.47105667813758834d), radius: 0.6326307680517361d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7269998228624289d, y: 0.6682813945825322d), radius: 0.016393737127555874d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9473397518578262d, y: 0.015525242591406974d), radius: 0.42763525792088597d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6174630805068267d, y: 0.6297736539879527d), radius: 0.795294546210581d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016097317734599548d, y: 0.846788755517142d), radius: 0.6504370592060302d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.729379636883882d, y: 0.6812468961175927d), radius: 0.871247410348502d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9240511723239093d, y: 0.20933686339875757d), radius: 0.3376822957760922d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5681192100412941d, y: 0.44320515835093555d), radius: 0.7145369289402161d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6669992684208139d, y: 0.7845815427995202d), radius: 0.08600256678863627d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24463547724694745d, y: 0.7074892385849969d), radius: 0.08994023401462492d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11714393789157473d, y: 0.19286141187416372d), radius: 0.10345540814598764d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8682561000339174d, y: 0.1320701201129557d), radius: 0.19712582927254518d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19172605316186242d, y: 0.4151188377056354d), radius: 0.35363366903743465d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5184275830699249d, y: 0.7218880584858604d), radius: 0.07784278197474814d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4512192704366328d, y: 0.9082077034787268d), radius: 0.3283054347127998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6988434550307354d, y: 0.8629369390751138d), radius: 0.6054566338225631d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20539305734551483d, y: 0.5740554582542272d), radius: 0.5333208343803663d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34985283147689905d, y: 0.42035088353863725d), radius: 0.23741441535880126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7094496792403796d, y: 0.48794675161171996d), radius: 0.5006572860426536d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39039708414028274d, y: 0.9562284441757907d), radius: 0.9506352977802672d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9154963773447928d, y: 0.7138600411595211d), radius: 0.504743473971988d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4078950566799291d, y: 0.7130937938518229d), radius: 0.33326153630714217d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8972436521008763d, y: 0.09995869109962785d), radius: 0.6917641865261411d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7414047009576831d, y: 0.9352118480230113d), radius: 0.3883106152775604d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4848412996159952d, y: 0.6100247027389629d), radius: 0.14757352859363815d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5173227417346516d, y: 0.9474691801337237d), radius: 0.183391921075987d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6449245168581457d, y: 0.831586099765317d), radius: 0.8215606684985903d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2950262647599313d, y: 0.5447324234908054d), radius: 0.9520542063476244d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35114140037498986d, y: 0.025033649658499524d), radius: 0.21251099412884344d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39339444491134956d, y: 0.4046917003286563d), radius: 0.14818617091488784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8349515584249909d, y: 0.35460259508347025d), radius: 0.7145140173021644d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6108162892119764d, y: 0.24685014898755608d), radius: 0.8649864147444377d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34473287790982154d, y: 0.4521586299322805d), radius: 0.5578906911536569d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5305734353196049d, y: 0.6549547133017046d), radius: 0.7861730683870936d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16312670552465314d, y: 0.5161638414189842d), radius: 0.15457702729191003d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9604216312040044d, y: 0.5958328339033828d), radius: 0.3753751732371221d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5732221452590871d, y: 0.5391152777437025d), radius: 0.7802098674966133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3173426392576244d, y: 0.5779826606979035d), radius: 0.29876679351949886d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5150842351537553d, y: 0.16420025468456523d), radius: 0.05251404562949091d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.710972939871142d, y: 0.785341587968793d), radius: 0.1198728281806054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4781697566151185d, y: 0.49465958968379176d), radius: 0.333991481913379d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9609223193174957d, y: 0.5781245222224226d), radius: 0.25172299205908133d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8725880672604813d, y: 0.10223668272659803d), radius: 0.7795871055854089d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4704941509354128d, y: 0.6465178737106428d), radius: 0.8870198654433883d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9907042616377157d, y: 0.3041089938180951d), radius: 0.8679553684860777d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3397297778499172d, y: 0.30712210292667985d), radius: 0.13746653584595125d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7492754486801531d, y: 0.08930551298867673d), radius: 0.6104318538808468d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4758574877460998d, y: 0.8439920563835568d), radius: 0.5645303242006419d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5839520874971704d, y: 0.14180099099460552d), radius: 0.9827454515896925d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45281627262730983d, y: 0.7530308508338911d), radius: 0.4858589642326052d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46173073496118877d, y: 0.6072676602818692d), radius: 0.9875401447284833d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4374644574555897d, y: 0.4982240123546271d), radius: 0.515228123557826d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.690565563691393d, y: 0.7943947552824095d), radius: 0.5640848569709997d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42824531233991303d, y: 0.8350181128410068d), radius: 0.45785840848302806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8665569650633407d, y: 0.953029314847762d), radius: 0.5838328142248496d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24667199251401528d, y: 0.773254272523959d), radius: 0.4664359596459732d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3847629346101007d, y: 0.7696597288466799d), radius: 0.7453984509772986d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08204872990913359d, y: 0.5650633652877493d), radius: 0.8128815748622881d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.466084890760344d, y: 0.3865506686725818d), radius: 0.13419177969327545d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2600724192706625d, y: 0.7205026762621252d), radius: 0.09938027437948926d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5573247445633668d, y: 0.627613966344119d), radius: 0.026406715978778972d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7110249513382412d, y: 0.22714948370324617d), radius: 0.9541944706488716d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22529879055441004d, y: 0.7831061459226021d), radius: 0.1651949165158093d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06212062002994234d, y: 0.39430496156395767d), radius: 0.788755088564612d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12240811603865043d, y: 0.07903787966652209d), radius: 0.7939285196707586d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06721788687409158d, y: 0.2886829967821126d), radius: 0.6263568132870965d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44550392663419003d, y: 0.8265746462069103d), radius: 0.5139874737072595d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3304522161960838d, y: 0.1055756726999143d), radius: 0.7465223322317384d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9746772474560454d, y: 0.6969419595214673d), radius: 0.9199008086856245d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9691960521636247d, y: 0.41618419345519664d), radius: 0.967040415358048d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4827054330171089d, y: 0.6213895163093135d), radius: 0.5433069006448183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7399867216601277d, y: 0.34470703523653723d), radius: 0.5450491341426605d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12582211343687233d, y: 0.518625277606877d), radius: 0.0137446930743792d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10030767236475102d, y: 0.3605783301960701d), radius: 0.4297365759321006d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.979491778715812d, y: 0.8135760146437063d), radius: 0.6927314722140233d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27411593018068325d, y: 0.7715889014885355d), radius: 0.6361004952521727d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2256978601871703d, y: 0.4108224631388422d), radius: 0.6765283158413237d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24831403673645536d, y: 0.4934768315201805d), radius: 0.6419170628204327d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.825368274648027d, y: 0.21154124393163776d), radius: 0.8777112860293709d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9337091260267983d, y: 0.6200509782809024d), radius: 0.6543180957047069d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6503628949617222d, y: 0.5078104882740859d), radius: 0.5622075686148309d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5645128683431611d, y: 0.7007392127377047d), radius: 0.5859930229058875d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6111012285332873d, y: 0.6149525707420639d), radius: 0.4494889922287899d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.307601065648488d, y: 0.345020778708263d), radius: 0.5469426546997423d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8512376421105695d, y: 0.8240733624178879d), radius: 0.6687456218080589d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6415642581695268d, y: 0.06796182295014175d), radius: 0.3072879067682135d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5434981595154585d, y: 0.1502173609912829d), radius: 0.9269714724726309d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023023286335338344d, y: 0.8909078338146192d), radius: 0.11764958477680776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27193278744304505d, y: 0.3737586986876318d), radius: 0.20328096229820714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7640664417602795d, y: 0.8286405318580334d), radius: 0.4120737953935355d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5798740269646993d, y: 0.12921845985195224d), radius: 0.6065821270238329d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8414264291813323d, y: 0.2774597095547148d), radius: 0.10792424752275254d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9622305240356768d, y: 0.8100836616138237d), radius: 0.7086484724050577d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45472734959790195d, y: 0.3093071372415138d), radius: 0.2800062326463558d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25512069510017765d, y: 0.1613942454081665d), radius: 0.8392862513646699d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2763765206545632d, y: 0.720179396953723d), radius: 0.04951687134312999d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5651476821416936d, y: 0.96582366571716d), radius: 0.2589948712944393d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5680623623703639d, y: 0.5206951612350829d), radius: 0.45125061446594306d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4096063727913454d, y: 0.5583338267220894d), radius: 0.2308535765266405d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39034527089514237d, y: 0.27000020210827047d), radius: 0.9363046577274773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20508458458807488d, y: 0.2301434349698388d), radius: 0.32109140138094994d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6332996247838641d, y: 0.7256654178784913d), radius: 0.13475206320372868d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4308713213001183d, y: 0.5381516467223197d), radius: 0.24997793703761984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.820361364552787d, y: 0.43830887607233193d), radius: 0.9068800403306606d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4077234793822343d, y: 0.9674752264353588d), radius: 0.5873805192987909d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4723071415741611d, y: 0.27959220451854616d), radius: 0.6628495152425727d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22986116290772707d, y: 0.6804864301239579d), radius: 0.17791938393292783d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19016755695348553d, y: 0.8303321128486119d), radius: 0.14993143729317737d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6442125464139692d, y: 0.45922177971665556d), radius: 0.12557324124612412d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6394954665658908d, y: 0.8491912900277879d), radius: 0.9741948325431508d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7964140475969619d, y: 0.9948430844213779d), radius: 0.9380230802932071d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10490367273836654d, y: 0.29460331907782544d), radius: 0.1405838395892829d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7252025933977364d, y: 0.5357497090806793d), radius: 0.23854818866868288d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6841173476897491d, y: 0.037977253956588686d), radius: 0.4562294141664399d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9448901013359373d, y: 0.031726290451094874d), radius: 0.48235818750492465d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3799543710604957d, y: 0.1167526609459486d), radius: 0.21546521604006041d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42902836515796505d, y: 0.28232094045850087d), radius: 0.25115886959534073d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32437227984894756d, y: 0.46677852610632464d), radius: 0.04098270594447839d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050912462504927d, y: 0.3411562375056303d), radius: 0.09645826906831634d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.537315566828453d, y: 0.7322801838330594d), radius: 0.7843667041556198d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8766821532603097d, y: 0.9837735634049638d), radius: 0.2297227627768792d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13042090305160992d, y: 0.4232268742479197d), radius: 0.03520732510161195d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42497863912260436d, y: 0.5204811462977771d), radius: 0.15439781114753715d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6953527571492593d, y: 0.0885655252172799d), radius: 0.9700039224797717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6400506811477829d, y: 0.15732733556708411d), radius: 0.0816987588863739d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3677357414139464d, y: 0.061551886894016916d), radius: 0.7249921533053698d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8493465814561455d, y: 0.3965894863221727d), radius: 0.8484919229185088d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7964425805843792d, y: 0.8135460993519701d), radius: 0.8529280237104911d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9058798911228407d, y: 0.7984647005510542d), radius: 0.716649592459012d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7231214939407709d, y: 0.08321253902500025d), radius: 0.3186074126838119d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46220139088764645d, y: 0.5310525863411464d), radius: 0.9880593794886157d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26631650766066883d, y: 0.19581434167562972d), radius: 0.5295600621051109d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4953430705209113d, y: 0.5772598031616659d), radius: 0.31391662630587314d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9344522611698818d, y: 0.6463881597798504d), radius: 0.3400933925633113d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8135445623298424d, y: 0.49650387316160993d), radius: 0.9445348016464334d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3130197115385499d, y: 0.34333094784003004d), radius: 0.9240919014038307d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9003805187293155d, y: 0.5463010624585235d), radius: 0.2871686175624719d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1035435117930047d, y: 0.38726395420936377d), radius: 0.9974207193760317d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.999939989047536d, y: 0.977067001651066d), radius: 0.7552358046323843d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0019199557550944046d, y: 0.46605755499361035d), radius: 0.8799755454075222d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9450274442846275d, y: 0.22589263940914717d), radius: 0.5088328191182245d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3370522003472216d, y: 0.46256478804670376d), radius: 0.28325659086675226d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.576844617209704d, y: 0.16012871617514013d), radius: 0.6484526114225821d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5862797263555863d, y: 0.9874517822064021d), radius: 0.7562138784634903d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9761830405319769d, y: 0.5023308262653357d), radius: 0.6079352954102378d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20673451372783558d, y: 0.018399225260092744d), radius: 0.6091912216622172d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6938043426503759d, y: 0.8913360225913751d), radius: 0.4991772053108685d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08233313852140023d, y: 0.3685724334583417d), radius: 0.835888155301732d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14271386252235385d, y: 0.4290400877740098d), radius: 0.98961250457613d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.380968488646485d, y: 0.7981391958649485d), radius: 0.8281005621159385d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48844841018474083d, y: 0.6567367490789584d), radius: 0.32058690367762976d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13231362159938087d, y: 0.30630261811868675d), radius: 0.07034372073166884d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1480328824515501d, y: 0.20071392109893293d), radius: 0.49567939645915016d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9000364255688611d, y: 0.2817232776365123d), radius: 0.3991610908515194d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5959101646792309d, y: 0.09476248426934275d), radius: 0.890160766409972d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9342599855399004d, y: 0.35834947715285526d), radius: 0.7579888973670857d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318309963831254d, y: 0.5858148178804098d), radius: 0.49205657027752525d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9005605122756284d, y: 0.24732479548647535d), radius: 0.6010773727334621d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07913637904179638d, y: 0.17734610187748845d), radius: 0.0019122580723414107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42581281871079335d, y: 0.8976564517488375d), radius: 0.47526077856402993d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018242454017594723d, y: 0.8186206524973658d), radius: 0.1494429969951273d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01006921280122175d, y: 0.8277966573849804d), radius: 0.6359751233043679d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28839482648678305d, y: 0.8494411744748943d), radius: 0.27221501938867065d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15130669710541478d, y: 0.4021101046269644d), radius: 0.37483286404388305d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026905475602686413d, y: 0.6805192844057991d), radius: 0.8893867944301225d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10020029130802344d, y: 0.19888096602509375d), radius: 0.7205338315024602d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9896381313888798d, y: 0.9953532864549498d), radius: 0.4237060798282629d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2024857451899731d, y: 0.647476250165653d), radius: 0.8789785420756071d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07136730581508322d, y: 0.21992213706516872d), radius: 0.47480878827634776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16273555746738055d, y: 0.06005292456689115d), radius: 0.672606830589889d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0456370843645304d, y: 0.5877016877479699d), radius: 0.39889229507199453d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16952143021322452d, y: 0.37526601296706075d), radius: 0.39731397239665245d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3192672185474482d, y: 0.18927761042268387d), radius: 0.5379669833606257d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3886312403687091d, y: 0.9214332214416034d), radius: 0.027253185377903888d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4995632573294716d, y: 0.6875519186803744d), radius: 0.13510992545348555d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2485119381369233d, y: 0.4104154125713618d), radius: 0.8817923779170448d),

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
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 102, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 115, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 53, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 82, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 88, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 132, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray2M),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2M>(15);

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
                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

