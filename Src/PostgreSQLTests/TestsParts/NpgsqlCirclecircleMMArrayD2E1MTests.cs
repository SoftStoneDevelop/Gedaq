

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
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5326208033752037d, y: 0.6870336083382131d), radius: 0.4096004735090327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8367748718635281d, y: 0.6879746313394148d), radius: 0.14288179679102642d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09367900896183146d, y: 0.3770456147011696d), radius: 0.9474469086146755d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9003332785556288d, y: 0.5800142870727572d), radius: 0.6779005023624004d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4904085467713093d, y: 0.09535136690325663d), radius: 0.34726680491043793d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9770201591076301d, y: 0.38419878785944694d), radius: 0.026391155379499653d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4562949143736874d, y: 0.9995785974785744d), radius: 0.42658489966757773d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.928436353404735d, y: 0.6581092770945824d), radius: 0.36420293849472185d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8977582146805969d, y: 0.16737970560724735d), radius: 0.7936400630090547d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10975932310509529d, y: 0.4151694418874178d), radius: 0.09801098540679765d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48130553861179026d, y: 0.5258763354551937d), radius: 0.25034951746591183d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3893839773472877d, y: 0.23782080685357943d), radius: 0.02239075140284852d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7001183303280775d, y: 0.5062920593134695d), radius: 0.26995813923175116d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.66679429729208d, y: 0.7510482076444812d), radius: 0.2627053023469471d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17110562245565064d, y: 0.09096595403481378d), radius: 0.4256249540155407d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38451064456167494d, y: 0.38382067200087d), radius: 0.697911568209141d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18449856085429484d, y: 0.8674146789310473d), radius: 0.889964958814456d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2006228787634563d, y: 0.6889694086141298d), radius: 0.44953985564119914d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15475644839778036d, y: 0.20937190907935654d), radius: 0.7941514188056249d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4191971098203301d, y: 0.048634054537801896d), radius: 0.9548965168613716d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47897248694050987d, y: 0.703432387045056d), radius: 0.5071331557548363d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21690938010694372d, y: 0.6270670474739631d), radius: 0.35503863705871597d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2445633676926381d, y: 0.05833470538236607d), radius: 0.17029444136052108d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21677422367708643d, y: 0.9714405293292689d), radius: 0.5289930764593646d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8146330107904002d, y: 0.6211298258931743d), radius: 0.8625563156102264d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.601428282030949d, y: 0.2807114812188348d), radius: 0.5662703148182364d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3732691541144174d, y: 0.8531789029435859d), radius: 0.837048698788809d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1906665849995104d, y: 0.5212084939841377d), radius: 0.9410587297028541d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8313325185721971d, y: 0.5160426799093794d), radius: 0.7266720204025527d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18369311674997924d, y: 0.9789764198726039d), radius: 0.9889275369401214d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7689678361090693d, y: 0.5350098081661889d), radius: 0.10182328586787037d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3489227722911027d, y: 0.8146798776825975d), radius: 0.2997291741215554d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37227886728868564d, y: 0.3360341304692649d), radius: 0.27572443318578743d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.046237662835722615d, y: 0.18925488669449386d), radius: 0.4453725126409743d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7197496033771023d, y: 0.8580094565783042d), radius: 0.15532567240502526d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39426827825110944d, y: 0.3765624535235942d), radius: 0.09625921315288599d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1755258998323479d, y: 0.9038145363120409d), radius: 0.1051577702760843d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9897235302876115d, y: 0.40856414163051225d), radius: 0.3270994184446413d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2981568244354117d, y: 0.2893649615897561d), radius: 0.6681590659658767d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.944924495488141d, y: 0.6710102898251993d), radius: 0.6304322364358661d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2710833905679354d, y: 0.33368038947200684d), radius: 0.018780966581694036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4380807586360488d, y: 0.10200675523740987d), radius: 0.6183431535594108d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0808664129323664d, y: 0.3814959187666992d), radius: 0.6534734231019216d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7039344572572178d, y: 0.24069885729484275d), radius: 0.2151843010845068d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7588746460991095d, y: 0.5568692455327497d), radius: 0.5677922590282317d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.029666948567825147d, y: 0.7050396844485697d), radius: 0.7496826216717032d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30718292191479235d, y: 0.7837376257025054d), radius: 0.7904948884849392d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42503659418502704d, y: 0.20253916681267425d), radius: 0.5971950912578167d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3907612762960698d, y: 0.05762484369772958d), radius: 0.17816200973570706d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7768220360822284d, y: 0.3354024450358788d), radius: 0.6940205797887932d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8161774623049575d, y: 0.058705580195074214d), radius: 0.9860895042649278d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1584325222016416d, y: 0.24197847010726414d), radius: 0.44818852939594456d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7889421016583718d, y: 0.7695156249347042d), radius: 0.9668881678352238d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7121465382097146d, y: 0.45698486983064657d), radius: 0.9863469195009416d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7301120987536355d, y: 0.7736768873459916d), radius: 0.7359468482278972d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8819293152940976d, y: 0.3450573413856065d), radius: 0.8510416368321545d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.788175880991116d, y: 0.2377056018557231d), radius: 0.3852949776508535d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08594961613600693d, y: 0.6826290880409001d), radius: 0.8174167987112366d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49272286326349035d, y: 0.6853117962049673d), radius: 0.7949440214277003d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7176836009182717d, y: 0.6069207318023422d), radius: 0.5092616941726562d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3715641803817583d, y: 0.1478112600239755d), radius: 0.7753711932098457d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6760363089544232d, y: 0.8089138377835383d), radius: 0.37195669882039784d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20760770039021847d, y: 0.27875992239766567d), radius: 0.3071652063329591d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10480727612915652d, y: 0.39421547680684266d), radius: 0.24123607327595675d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8754148610322523d, y: 0.5011993019368943d), radius: 0.6051814478565524d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8196540470187407d, y: 0.6211519724504843d), radius: 0.8638590840762815d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3686284223221158d, y: 0.19915715552767022d), radius: 0.9613801050362901d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3199861400329749d, y: 0.6924378692131319d), radius: 0.4071859018040517d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6261536541567037d, y: 0.31183178392728983d), radius: 0.08188657579847691d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21887215298970042d, y: 0.9134701758590706d), radius: 0.3542230240089236d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17794402969765122d, y: 0.40269018482120544d), radius: 0.04617050694553837d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006040827335269228d, y: 0.2559420378456271d), radius: 0.9410825104026833d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9092126987654914d, y: 0.9144258163467957d), radius: 0.7902410172878351d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44026950194495995d, y: 0.7817384740712917d), radius: 0.02711055998244405d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5362412857559997d, y: 0.28322260474652183d), radius: 0.1803831600134529d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9361146968430423d, y: 0.43432801440814395d), radius: 0.9727762820298564d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606266755249503d, y: 0.6193892893260463d), radius: 0.7521727678933723d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24686361907397247d, y: 0.31627360066569143d), radius: 0.7953836151729966d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9980999787917243d, y: 0.7181453880038918d), radius: 0.2542816601836174d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24134662834745968d, y: 0.687525095155661d), radius: 0.9568303772764429d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5207071312795251d, y: 0.059058044202808246d), radius: 0.3405870471482164d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15451659170947163d, y: 0.8920878258533999d), radius: 0.6502385588039175d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9311688735583084d, y: 0.24866859315323508d), radius: 0.5008848599334277d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.901710786465178d, y: 0.3755868350663598d), radius: 0.6979990303710618d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9489248634645177d, y: 0.9284828885290496d), radius: 0.01119059652320864d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47349577940235177d, y: 0.41117358698012985d), radius: 0.04431262141937664d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18913815592251337d, y: 0.19892860539726653d), radius: 0.03268803086644512d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19240341608015032d, y: 0.32440729756265774d), radius: 0.8623719757590469d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8964965176242509d, y: 0.27702626798324725d), radius: 0.49795083056076916d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9014912053963974d, y: 0.06691098067999324d), radius: 0.5910255777905814d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42347216476439486d, y: 0.5643533775263841d), radius: 0.9009843078750374d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13692715583951676d, y: 0.2420070192528111d), radius: 0.2380689764947469d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9048289452460054d, y: 0.66911409913521d), radius: 0.3968863666333282d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3519206512082721d, y: 0.7936097846467111d), radius: 0.11957589164420002d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7811782783065258d, y: 0.8143304282662915d), radius: 0.07412839524116877d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7893017705225603d, y: 0.423439829059602d), radius: 0.5335799941805232d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16100768397854393d, y: 0.2000827583126208d), radius: 0.38272044758195944d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3777472863715413d, y: 0.3327868946727969d), radius: 0.2850736919546635d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8225941015921038d, y: 0.7826995846922582d), radius: 0.2646089273665777d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7552202084689383d, y: 0.14822998632344397d), radius: 0.6232446353571065d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7769680336930719d, y: 0.5035462300565563d), radius: 0.33421581572565073d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5728226304828024d, y: 0.3795660549475267d), radius: 0.25326607206921614d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5598608357528022d, y: 0.07615458662188135d), radius: 0.7083648331724005d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16505702732332939d, y: 0.21401329502599453d), radius: 0.5214433099517141d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9632176456855056d, y: 0.8095189193091813d), radius: 0.7345344952996523d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9495763164383778d, y: 0.9114662898598267d), radius: 0.5426542940310782d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019718062568292005d, y: 0.4434432516849187d), radius: 0.17435852866833346d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0709658413880393d, y: 0.6277724143669664d), radius: 0.6744071812604198d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6577757869762215d, y: 0.5150468091980468d), radius: 0.22143215477421951d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2541176396166518d, y: 0.32544839315023355d), radius: 0.22947430758894494d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17869736337268272d, y: 0.9357604496568808d), radius: 0.9281811783994016d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9759198406902231d, y: 0.5788604693459646d), radius: 0.06279107324729438d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.991081292451083d, y: 0.6995414827590766d), radius: 0.8641691484973363d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9443073692663095d, y: 0.4602886259667034d), radius: 0.9318128183513701d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5865582292436692d, y: 0.4984247983685579d), radius: 0.3805911548879506d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16945218252414296d, y: 0.13997948757260525d), radius: 0.3756901324125298d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32568995660348343d, y: 0.02524862150770113d), radius: 0.5362269861956086d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16139156180897352d, y: 0.20308184121587325d), radius: 0.31495046905567026d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9273853418373409d, y: 0.4267695764475802d), radius: 0.056370777787081106d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5769069723810256d, y: 0.7839063190826493d), radius: 0.0487345694665301d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7065521244991583d, y: 0.5816687434400277d), radius: 0.7491593040168848d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2192012714758853d, y: 0.6585044790857122d), radius: 0.5481169906466207d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08024339465122521d, y: 0.27055738437365506d), radius: 0.5374034427138256d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5418232237807635d, y: 0.48771009043520386d), radius: 0.8387057890403351d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4607371118383584d, y: 0.5531474139087678d), radius: 0.443241311070234d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17580614623388535d, y: 0.5347784051026859d), radius: 0.23395462690920443d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7346507121434094d, y: 0.29570364478040745d), radius: 0.17036041303336558d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9004606295456212d, y: 0.14817613341655367d), radius: 0.5215895013493688d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7770414033625778d, y: 0.20716033562001535d), radius: 0.9165482195078806d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23376732286128588d, y: 0.23539535318264637d), radius: 0.19332081118696398d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39417632460443475d, y: 0.10839715029316188d), radius: 0.1495245460040775d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8967483832332135d, y: 0.2525871530585163d), radius: 0.17993105454112968d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9455944243883472d, y: 0.11379107345800565d), radius: 0.9408931651558203d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44152711120747123d, y: 0.10531426690055012d), radius: 0.5893135868922756d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5011369730869993d, y: 0.17065292042362434d), radius: 0.06972813216813623d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3646669208630938d, y: 0.25870243734317655d), radius: 0.4508934138247852d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0057499739631151625d, y: 0.13825826991552348d), radius: 0.9045109851278006d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3705149256146961d, y: 0.24279500737487147d), radius: 0.23486163283218098d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4266570619473734d, y: 0.6965896437580151d), radius: 0.31370089110829646d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29491449307598827d, y: 0.1300624571256449d), radius: 0.01962429869840554d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008176325154136688d, y: 0.924108078832784d), radius: 0.4964540134265769d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03749517507922018d, y: 0.060357346848047166d), radius: 0.8944397131560731d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08029702954239615d, y: 0.9600950992801099d), radius: 0.19832169890245488d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5842715432485834d, y: 0.7997348393820111d), radius: 0.1484949006601869d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.268871447441243d, y: 0.7975165552419852d), radius: 0.13587605554946092d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5771177343373693d, y: 0.39923393040939237d), radius: 0.30464967265378406d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7653887878979402d, y: 0.6753719723880088d), radius: 0.8622691155054484d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5129596304334784d, y: 0.8231730561247782d), radius: 0.36344179744508276d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023742901827542573d, y: 0.6820124108588796d), radius: 0.7315044128498455d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6067126883836275d, y: 0.5927682254370452d), radius: 0.9818793972930276d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43096797138077625d, y: 0.9267831090985349d), radius: 0.33015988552839715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6614350030630985d, y: 0.48983781299533213d), radius: 0.05082610659453901d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28688629161842827d, y: 0.47132904350938387d), radius: 0.9729789841471267d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5824185684595703d, y: 0.4793952083397194d), radius: 0.7513416770909576d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32232346593336425d, y: 0.459794034141652d), radius: 0.7175126564815878d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11413935752422144d, y: 0.7179483592836791d), radius: 0.0032243792598367627d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7758773320048978d, y: 0.5506585118905483d), radius: 0.6396895687555558d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8259633967236825d, y: 0.6630892510236706d), radius: 0.41883807443997345d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7774835939742047d, y: 0.8364006685778669d), radius: 0.0326279521504067d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49913030710424844d, y: 0.5112665408643606d), radius: 0.23368795938592124d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6289970743656847d, y: 0.2439539066108164d), radius: 0.920789783435408d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5073993692151582d, y: 0.00458572553884562d), radius: 0.6934782037282909d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.752811890243421d, y: 0.5315876368413263d), radius: 0.9341845105828609d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8290976254552742d, y: 0.9514572261197697d), radius: 0.8923597722328839d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2828547600723692d, y: 0.11783083969853947d), radius: 0.9628099178294962d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026428500001288935d, y: 0.014923615860417683d), radius: 0.4716487137481544d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3229738556489046d, y: 0.6092154294230134d), radius: 0.12107306653419159d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9909432515564286d, y: 0.9237582790322553d), radius: 0.2517508520241669d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.042170215238583664d, y: 0.37402152861486104d), radius: 0.7380528690005153d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34237246348615613d, y: 0.1473685135297912d), radius: 0.6501522202235926d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3873496073214474d, y: 0.6769922534407778d), radius: 0.28949250142281513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5254075571637519d, y: 0.4188414629074506d), radius: 0.7775408110334877d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4406921525858357d, y: 0.4636032208161346d), radius: 0.6728474170588168d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7381875815704494d, y: 0.4378289120431046d), radius: 0.6242478086890947d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7013265985624363d, y: 0.6167704922947282d), radius: 0.021354980092807896d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23137054668318935d, y: 0.34400426795337014d), radius: 0.49717209230896164d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01923722753386503d, y: 0.8323139522839408d), radius: 0.18487253696780825d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8292878069469614d, y: 0.48523978341773544d), radius: 0.7134666756081242d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10839021736894705d, y: 0.3724697557492679d), radius: 0.6915033228975693d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4164255079753918d, y: 0.09849304104992163d), radius: 0.7180645893240539d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296777521488199d, y: 0.7931723430206294d), radius: 0.3989511872149273d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6719461720751625d, y: 0.5704438842674883d), radius: 0.7148007960281072d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2712768471025512d, y: 0.08871343070947513d), radius: 0.7886786935927418d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10651855952043066d, y: 0.06915581423392936d), radius: 0.7308819827886669d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8881429496215876d, y: 0.5137709997784704d), radius: 0.8289555584334672d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20376394171523093d, y: 0.06563830254993341d), radius: 0.7468907558827304d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8705427707048548d, y: 0.7194024617175506d), radius: 0.2919439251628023d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4047089360009227d, y: 0.4263875871163898d), radius: 0.3808780403206211d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5831541644049958d, y: 0.8786667114980001d), radius: 0.6370802866030081d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5813862804055318d, y: 0.9740384939877247d), radius: 0.5414399391552359d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09421190091398224d, y: 0.2459337683731092d), radius: 0.8306510337553212d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22438070393352394d, y: 0.9579290012871411d), radius: 0.6041768981176239d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7151036000761913d, y: 0.3139677221007975d), radius: 0.9743710914544259d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20610628574752032d, y: 0.7013360570603769d), radius: 0.7762126695698848d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7322373327195636d, y: 0.9511950745155938d), radius: 0.04958618161427164d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7231883082573489d, y: 0.4676319866391341d), radius: 0.23537908658778162d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8037016094895367d, y: 0.22807193718269048d), radius: 0.08685457575444522d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9046945769571056d, y: 0.4745629338952869d), radius: 0.4639554098562173d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9959244369635969d, y: 0.10258843474719215d), radius: 0.8234310991323641d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1196891566378806d, y: 0.1658834024808935d), radius: 0.6587790745553184d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06118754842539775d, y: 0.7423466124257518d), radius: 0.546091193318667d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021211019651751428d, y: 0.5471711322934937d), radius: 0.29824552836804796d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9777225705482491d, y: 0.6277486912285386d), radius: 0.028510141948706935d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3534362164343794d, y: 0.8265909169648734d), radius: 0.26732810142185937d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8339914345334195d, y: 0.5632907711616726d), radius: 0.5496412657040568d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08888926608595271d, y: 0.5206321168895506d), radius: 0.48391107880139683d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47710919212021097d, y: 0.34500182261963586d), radius: 0.004021047504933373d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9408122115262599d, y: 0.15469857174108648d), radius: 0.08077922924503844d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.984837905191048d, y: 0.16830563287338496d), radius: 0.8948803204464679d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.77807515536361d, y: 0.6936025522777958d), radius: 0.903994010872966d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2193336956137687d, y: 0.9582036224710887d), radius: 0.30684105727560196d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4579433901307186d, y: 0.08626357755792535d), radius: 0.44337576398539535d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4937003995396181d, y: 0.9933284573964054d), radius: 0.08159076497494644d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9698660387440697d, y: 0.05190015326370423d), radius: 0.7654137121915566d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6324749560309469d, y: 0.6813991863235198d), radius: 0.7841335702965022d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6525166178241499d, y: 0.4118637523590054d), radius: 0.003632811641506084d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1535102034598178d, y: 0.2530813515730721d), radius: 0.242307067432312d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05736998049089315d, y: 0.7854918326667384d), radius: 0.02591452371696623d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6084305797792737d, y: 0.45295564445659176d), radius: 0.9119063690061949d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19687326336074007d, y: 0.18006521210872817d), radius: 0.23365840855873798d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6563709027816657d, y: 0.6016148420323064d), radius: 0.33621724943140274d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8311753246366617d, y: 0.146449998207142d), radius: 0.5479827036243048d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7660628551202078d, y: 0.12265755874197659d), radius: 0.9718904457176434d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8959311732274424d, y: 0.45255939634656417d), radius: 0.17870382754430114d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008563255864881603d, y: 0.6796633647400322d), radius: 0.11101735009603264d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20765479319735636d, y: 0.30424190454561806d), radius: 0.41355766200585453d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2688829196946634d, y: 0.9683764679873175d), radius: 0.31303880497510583d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6711543053497269d, y: 0.024279527200242845d), radius: 0.04495082526004368d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5987456292686155d, y: 0.11656231410751683d), radius: 0.7477611519453052d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08382620268813734d, y: 0.9383449576022581d), radius: 0.1794658091942094d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38083977189527274d, y: 0.9648090949057194d), radius: 0.19859101078897057d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5243884280560699d, y: 0.9844007114238821d), radius: 0.49035573867717897d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4724529710963583d, y: 0.9675281572218214d), radius: 0.7438152718946266d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22834291818077912d, y: 0.07023796248941183d), radius: 0.9721012828140176d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3001298151551528d, y: 0.7020981931189011d), radius: 0.9153144889423522d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6787336358828736d, y: 0.9122140749284552d), radius: 0.4279756238276513d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9381234498932508d, y: 0.2706156974120014d), radius: 0.12599644525475262d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5977023022939965d, y: 0.03691584145606397d), radius: 0.757614651037217d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.627713306511591d, y: 0.7591313471917286d), radius: 0.06501822446702199d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08506129328099132d, y: 0.2936223105009479d), radius: 0.7118358553742711d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7947336294734023d, y: 0.9304739292046011d), radius: 0.15667248346672147d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35655969743588045d, y: 0.08363928933672349d), radius: 0.5398633104474702d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8429388427971407d, y: 0.7764663441803501d), radius: 0.8635321494923371d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5203716462707657d, y: 0.6351096295854136d), radius: 0.8533126292227107d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12147426331152156d, y: 0.398579486211751d), radius: 0.8090198543919115d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013079351367128123d, y: 0.8906728886239021d), radius: 0.7005300907637095d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9288367962842227d, y: 0.8584342698548719d), radius: 0.22008849308733747d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12574842222882154d, y: 0.4834785255319365d), radius: 0.4573510767712461d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.696984715234121d, y: 0.18452314548204685d), radius: 0.7644092947686516d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5332304291318318d, y: 0.41809663893258686d), radius: 0.09786131844532431d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03251455086668131d, y: 0.9424558720024835d), radius: 0.8366873954277612d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.001904151112079977d, y: 0.42346049652748086d), radius: 0.6910979610738931d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7623045062327024d, y: 0.05272533539223101d), radius: 0.6524033007105995d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02080714908139991d, y: 0.20157913204914946d), radius: 0.6064728603697023d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683868604567219d, y: 0.49971454563708007d), radius: 0.7120205669249395d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14274279283779923d, y: 0.9341639336253005d), radius: 0.27571908981095894d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13239300944173837d, y: 0.8340887551957334d), radius: 0.4887425583523959d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2855745351064166d, y: 0.12456508141196321d), radius: 0.7822821771148895d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6734354702540999d, y: 0.6720050663831416d), radius: 0.4925525002066372d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9547401086499354d, y: 0.19730512265805167d), radius: 0.10716047164816411d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12042759898618194d, y: 0.20493940615709771d), radius: 0.35291766577437356d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2044736714458537d, y: 0.9558933783329345d), radius: 0.7280635724117398d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6955713697578678d, y: 0.5319406112703197d), radius: 0.32208340820939374d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3632102543635186d, y: 0.66227437223943d), radius: 0.429241252456262d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5062981228376924d, y: 0.42525781788315464d), radius: 0.3401071542425771d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4867235858833643d, y: 0.7874088315047715d), radius: 0.8919960566557861d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8334423805267855d, y: 0.05228778111963983d), radius: 0.6112267571147202d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07703650736347267d, y: 0.21791238321758544d), radius: 0.08457592483995335d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5068207846821373d, y: 0.2624193771666882d), radius: 0.7562477286253411d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8649075998201655d, y: 0.3685149337929058d), radius: 0.5169600183921758d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32471105152554325d, y: 0.4322956495998118d), radius: 0.3606423163799769d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03512738350722633d, y: 0.1734693842560665d), radius: 0.4183030731045294d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7766512697120769d, y: 0.6027328583622426d), radius: 0.45854937722236766d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6570225288566872d, y: 0.1551795865760941d), radius: 0.6170110396458959d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8118550683784168d, y: 0.15404379298052207d), radius: 0.17039849910272964d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17271527064504166d, y: 0.5487418905824838d), radius: 0.249174806103169d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3615351885625363d, y: 0.883417380490309d), radius: 0.23478941817186272d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3874058114915233d, y: 0.7754878114585361d), radius: 0.43825224740832536d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3954600199579107d, y: 0.23550280687602265d), radius: 0.054276258633282226d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8083206586870905d, y: 0.9774279858988806d), radius: 0.5847882967899779d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9236578238556067d, y: 0.3647813544465093d), radius: 0.5383066384300611d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25366800033929304d, y: 0.550105502158178d), radius: 0.9692285265911464d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6121205735633385d, y: 0.6505321069400559d), radius: 0.12208278936256844d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17689961713273794d, y: 0.8360103557026004d), radius: 0.04044672338690458d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8731268000103216d, y: 0.5369503937498581d), radius: 0.32569190990531505d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48547272228360416d, y: 0.5109760584134054d), radius: 0.5772598670514617d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4222395105839475d, y: 0.4516607480427792d), radius: 0.3359354688714675d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7785424049502829d, y: 0.8549627373977253d), radius: 0.7179125378084267d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08415240303240368d, y: 0.5764632203740941d), radius: 0.1391652032018641d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5006501194932285d, y: 0.2887210558180384d), radius: 0.0170043364464747d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018576399734685056d, y: 0.823083304499822d), radius: 0.04847897109929389d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6195441505368499d, y: 0.21125186198729706d), radius: 0.39209920640540663d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33967374161861796d, y: 0.9953426408868775d), radius: 0.792436412439847d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9205933949615891d, y: 0.3450042625245774d), radius: 0.9472896193760911d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06855098672334081d, y: 0.9145753713700131d), radius: 0.2805906153230724d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45521778900897214d, y: 0.12334647941982457d), radius: 0.8857047404234114d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6699403093201105d, y: 0.6846765284674801d), radius: 0.22200462853843905d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9196371823391988d, y: 0.385210025255163d), radius: 0.48996050225651266d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30734558699676784d, y: 0.9794201983918892d), radius: 0.08946172853981993d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02215371042674874d, y: 0.6419637907775013d), radius: 0.9601556286209829d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11270925988708635d, y: 0.6061084152600535d), radius: 0.8376423872981271d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2475843315532873d, y: 0.8335372921275997d), radius: 0.9112322418936915d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7233737289543595d, y: 0.3053778993651849d), radius: 0.7547916614046055d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25239242172969156d, y: 0.6537747421035933d), radius: 0.5479584458622343d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7837787876402574d, y: 0.9416934927391964d), radius: 0.881185759959957d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09766804418954211d, y: 0.11605694960800872d), radius: 0.11566209111568948d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23637557788338703d, y: 0.8206714143393233d), radius: 0.26482372926467346d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37914179908118595d, y: 0.6130791813665426d), radius: 0.8595605830262985d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02307772231969485d, y: 0.982721182748303d), radius: 0.20250084010452407d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6405514887454874d, y: 0.5064826899079263d), radius: 0.17109480724284676d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12866802766498964d, y: 0.7214555802839206d), radius: 0.9071356811887891d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6136978965945927d, y: 0.46961277848174077d), radius: 0.7171448879982224d), }, },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9452296670545092d, y: 0.8247266499273112d), radius: 0.6766630763259477d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28663040380358495d, y: 0.03262588484297413d), radius: 0.216184027412753d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9966746625529515d, y: 0.3197215974110311d), radius: 0.13017845894058377d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7779823509285018d, y: 0.48213435058800747d), radius: 0.12826311780141775d), }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9456310014207129d, y: 0.4971046889691897d), radius: 0.4389165207709178d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37154042123651754d, y: 0.9220950318977429d), radius: 0.4277247354246295d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9557832487825881d, y: 0.3924999022462202d), radius: 0.4556388026746616d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17311702851597688d, y: 0.951962838698221d), radius: 0.7156467009678932d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7224447030216341d, y: 0.43551786107083523d), radius: 0.05413133033342288d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8944178063993498d, y: 0.8864934520075557d), radius: 0.028781282381290296d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6067437332679368d, y: 0.8209024261403038d), radius: 0.28637307331166184d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11009705965892547d, y: 0.06202268323547122d), radius: 0.597154686227433d), }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6245885676214087d, y: 0.47303815987361064d), radius: 0.19564696184576225d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9702085947233416d, y: 0.2533076100647861d), radius: 0.8841673453428849d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296870629588858d, y: 0.7015190311953091d), radius: 0.951286095057475d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32239381383088994d, y: 0.22677478948172558d), radius: 0.8148874252508287d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3478601265895531d, y: 0.7555742733145856d), radius: 0.38479310790813204d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8449166750158612d, y: 0.10561453993950876d), radius: 0.5283395522409061d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33326521787178964d, y: 0.14017290680230532d), radius: 0.7569633076670117d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9245168508309248d, y: 0.2085265627633739d), radius: 0.7254929469424876d), }, },
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3715641803817583d, y: 0.1478112600239755d), radius: 0.7753711932098457d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6760363089544232d, y: 0.8089138377835383d), radius: 0.37195669882039784d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20760770039021847d, y: 0.27875992239766567d), radius: 0.3071652063329591d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10480727612915652d, y: 0.39421547680684266d), radius: 0.24123607327595675d), }, }));
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
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606266755249503d, y: 0.6193892893260463d), radius: 0.7521727678933723d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24686361907397247d, y: 0.31627360066569143d), radius: 0.7953836151729966d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9980999787917243d, y: 0.7181453880038918d), radius: 0.2542816601836174d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24134662834745968d, y: 0.687525095155661d), radius: 0.9568303772764429d), }, }));
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
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9489248634645177d, y: 0.9284828885290496d), radius: 0.01119059652320864d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47349577940235177d, y: 0.41117358698012985d), radius: 0.04431262141937664d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18913815592251337d, y: 0.19892860539726653d), radius: 0.03268803086644512d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19240341608015032d, y: 0.32440729756265774d), radius: 0.8623719757590469d), }, }));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.991081292451083d, y: 0.6995414827590766d), radius: 0.8641691484973363d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9443073692663095d, y: 0.4602886259667034d), radius: 0.9318128183513701d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5865582292436692d, y: 0.4984247983685579d), radius: 0.3805911548879506d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16945218252414296d, y: 0.13997948757260525d), radius: 0.3756901324125298d), }, }));
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 129;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 103, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 59, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 81, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 16, query1, 42, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 16, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 132, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 123, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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

