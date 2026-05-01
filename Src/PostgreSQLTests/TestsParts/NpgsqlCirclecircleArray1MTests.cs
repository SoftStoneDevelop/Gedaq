

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08820370974187697d, y: 0.5750649651732874d), radius: 0.980463954436422d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9216055392668849d, y: 0.2786443937509492d), radius: 0.16972056462212992d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6845608001653719d, y: 0.08113627620514896d), radius: 0.37902788252239816d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36024630765173316d, y: 0.954011834701632d), radius: 0.5547042653716326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27407880276533114d, y: 0.5036402674527599d), radius: 0.4082779639700528d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.339101576120311d, y: 0.05653226613147355d), radius: 0.6687065709777494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650643047146283d, y: 0.3414971058197307d), radius: 0.7286582358248033d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7680976980222388d, y: 0.7583465156809193d), radius: 0.4945656753785004d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5501875235273669d, y: 0.20490975654214028d), radius: 0.09056617559438884d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3398085445555147d, y: 0.1762642138161219d), radius: 0.024788136566960772d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6614047128959955d, y: 0.4250260944552242d), radius: 0.7102858362360269d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.675641896740853d, y: 0.0059776200611781904d), radius: 0.5786841956910591d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1735195092089542d, y: 0.6963747181901054d), radius: 0.030144175380161786d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08618966127759098d, y: 0.7436748357488844d), radius: 0.3258629848170901d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8441487290329382d, y: 0.27374856345108567d), radius: 0.56865041092446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6253188134597635d, y: 0.1751128374222135d), radius: 0.20943771158722968d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9338701616366797d, y: 0.07346465751960707d), radius: 0.5036430821084267d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35441156233329263d, y: 0.26753592065724763d), radius: 0.8663239809759821d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018244653922528276d, y: 0.9096387914637402d), radius: 0.4135828268960178d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.627672120499804d, y: 0.05562046688755806d), radius: 0.25990951146650976d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4262251436273734d, y: 0.1917915848576871d), radius: 0.636847214300999d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5930419817897604d, y: 0.37415230207870553d), radius: 0.5173642989438558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.518857761671768d, y: 0.815663824120608d), radius: 0.11076221077254345d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5642477883416581d, y: 0.33916826484731677d), radius: 0.8019076746272155d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4160097430487196d, y: 0.5271511283305411d), radius: 0.6840039109925167d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8861030723740111d, y: 0.9829910246360231d), radius: 0.6755097411769662d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5824688171272493d, y: 0.8106599488102842d), radius: 0.3349509935971329d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04826513699599688d, y: 0.8819583684015111d), radius: 0.6004979234744091d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8509671436988322d, y: 0.9373009778090113d), radius: 0.03499567675381843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03520850986123836d, y: 0.003702837304849216d), radius: 0.8754651413145923d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5433791674794749d, y: 0.4255656206456214d), radius: 0.038138109715987856d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048743867790044804d, y: 0.5143355187493752d), radius: 0.9907141618896161d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6754503687460546d, y: 0.7088585854693095d), radius: 0.92363223145418d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.715035469873958d, y: 0.5083320349694225d), radius: 0.9958720341322201d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40722234289310244d, y: 0.07489708636936021d), radius: 0.5881345641810819d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7703729527891091d, y: 0.49487423982176937d), radius: 0.5130237239762198d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5990871496307116d, y: 0.1872875125828185d), radius: 0.37662580597541306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3701340956905882d, y: 0.6422065385438338d), radius: 0.9468938362294367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9771247473115902d, y: 0.9145112447163088d), radius: 0.7408944507249995d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44393919219923506d, y: 0.09327691875210486d), radius: 0.8993702337353534d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2690146457638505d, y: 0.7721833264916425d), radius: 0.8008704086772118d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016069283887001795d, y: 0.3989344720924799d), radius: 0.521334766014133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6416574880786076d, y: 0.6140690420751536d), radius: 0.5566094276406485d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31550150647548847d, y: 0.5493528019722228d), radius: 0.09710861183143049d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05584559059200889d, y: 0.3203690110920847d), radius: 0.4110873773251156d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23755856500007666d, y: 0.6773087997122741d), radius: 0.5249341519828906d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26218956717923736d, y: 0.16047356147079372d), radius: 0.629475920855068d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040841694553164776d, y: 0.6858904604266303d), radius: 0.04515328086163628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39233847924879006d, y: 0.9313262186700336d), radius: 0.7236614445908647d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.017652518007576834d, y: 0.3417799395150848d), radius: 0.3631672264777014d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02106212294846921d, y: 0.983534257232952d), radius: 0.8393665119170844d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6253793094167867d, y: 0.14430708586319008d), radius: 0.5355578944606146d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2520991846883197d, y: 0.46466352197054384d), radius: 0.42656682272989743d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7433281960037447d, y: 0.3372811850366859d), radius: 0.8287806844284926d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49919676208863906d, y: 0.5669185143080403d), radius: 0.6021446884942258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2622143500100361d, y: 0.488892824933849d), radius: 0.7155464539830814d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29093527703124367d, y: 0.5830973434968465d), radius: 0.2330808663095013d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6902419499852372d, y: 0.671945707960241d), radius: 0.8012344494786241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2613005430016285d, y: 0.7619481330465514d), radius: 0.5018275623660589d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.217919850214641d, y: 0.18635761729102085d), radius: 0.06173453834919407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18680915783579022d, y: 0.8847797972574236d), radius: 0.9758120825722116d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.233943330043758d, y: 0.7681334349496249d), radius: 0.08111753269638122d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1541942687504163d, y: 0.9230758666354799d), radius: 0.40049570154115754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9491500979616566d, y: 0.47016325326645014d), radius: 0.8475607138013584d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33155148918329147d, y: 0.3526577267151335d), radius: 0.21169663100495595d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36156067434092376d, y: 0.8026159620083161d), radius: 0.08764965221709653d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9915224144008268d, y: 0.15582907720541783d), radius: 0.5881003078480576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6294218254229107d, y: 0.052732259983016005d), radius: 0.8717113332607177d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7690982938780173d, y: 0.20322003304691771d), radius: 0.10226052763195237d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8237529276005011d, y: 0.8990186570817318d), radius: 0.20700530845832488d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38251261763685496d, y: 0.17591634991605754d), radius: 0.4244043564767924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6565223312937503d, y: 0.4355565152901394d), radius: 0.8163543158198564d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5843689038210312d, y: 0.29605900344832925d), radius: 0.06298956141798207d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16082147218145326d, y: 0.3105456499819408d), radius: 0.5099044764437136d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9551824249187025d, y: 0.4925796976770108d), radius: 0.13152294789710073d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8245979631110038d, y: 0.32946819886406353d), radius: 0.44488835969410345d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18209651315998554d, y: 0.9683917433105893d), radius: 0.7409472450025233d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13542196539255147d, y: 0.1991246890092253d), radius: 0.8539968099757292d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2918697081962186d, y: 0.8492454872524354d), radius: 0.2494798179911204d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13665082876425938d, y: 0.6573848870496686d), radius: 0.635849719096048d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9305544115558698d, y: 0.42233091252165955d), radius: 0.025904608084054592d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41318394522023294d, y: 0.6099395197343025d), radius: 0.21009115207223483d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31056071365712834d, y: 0.5194496599861954d), radius: 0.151208654597218d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11007177803077628d, y: 0.612891002025233d), radius: 0.42806734673845126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7734962740446357d, y: 0.6196507754166374d), radius: 0.4020180493297749d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5029377392266972d, y: 0.02067280557625295d), radius: 0.6038889073411733d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5968661542203881d, y: 0.6753421670500163d), radius: 0.07187522607067454d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8346275424008287d, y: 0.697441482304297d), radius: 0.5115927848472077d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8603766536028956d, y: 0.10616720053835416d), radius: 0.15740157086506512d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23701103020771597d, y: 0.9304683564628379d), radius: 0.8971897531938057d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9981548979417566d, y: 0.957673437180129d), radius: 0.9196854935113737d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48421259315617615d, y: 0.20938356131278502d), radius: 0.261651954258719d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40725321755011623d, y: 0.23372999785277482d), radius: 0.7141379720495634d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5516885519600273d, y: 0.9166862429097943d), radius: 0.4054238332560838d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9162040844314212d, y: 0.14706305942172926d), radius: 0.6919755193156045d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7047144246286337d, y: 0.5064842244431654d), radius: 0.22895908052910952d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28509709838256914d, y: 0.3192291551610219d), radius: 0.9965282286518874d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.667061438477444d, y: 0.20688510462638565d), radius: 0.034211469664689576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7944965491458972d, y: 0.1415455715364594d), radius: 0.06123328190557664d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.320689315057367d, y: 0.7642846077296951d), radius: 0.8392052515725803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3233385848728605d, y: 0.608857320074231d), radius: 0.21580878898998468d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8153915334571769d, y: 0.8584184440322532d), radius: 0.011221856323880619d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6441494556443986d, y: 0.4790890585205453d), radius: 0.6764297344694445d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36650486990593545d, y: 0.9078156170841116d), radius: 0.9899183162730958d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7629262075093414d, y: 0.7158254652797985d), radius: 0.42757685695891545d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686448517321566d, y: 0.8186709877695806d), radius: 0.3993098534469981d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025822812034441145d, y: 0.28956795050550244d), radius: 0.5800842802848477d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5865476713946458d, y: 0.0855637866657728d), radius: 0.2491208105725995d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027511088347579205d, y: 0.6603086985859526d), radius: 0.5948239294378995d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7722333554687136d, y: 0.7347024597242654d), radius: 0.7541490998012901d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5208343146827757d, y: 0.7368383680959737d), radius: 0.5023715184725253d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5164064440523136d, y: 0.02912185486074126d), radius: 0.3102696633862878d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10216418929742621d, y: 0.482566026367245d), radius: 0.6295159120850777d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4886166809814181d, y: 0.5266283565209788d), radius: 0.47131725843463046d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.450132461121299d, y: 0.7026695207118738d), radius: 0.5428493608023441d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7092750021320066d, y: 0.7526249510608932d), radius: 0.3316667184644515d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8712138656473096d, y: 0.20922815410130513d), radius: 0.7017373930799382d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9368790707732038d, y: 0.9821664644988104d), radius: 0.8553913118763222d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23553360220354447d, y: 0.37571108397595887d), radius: 0.8021097405330685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08175534679960417d, y: 0.6007397634481438d), radius: 0.4375493295306404d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47815658523980065d, y: 0.3108110086432174d), radius: 0.7242234657358738d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7984676428856896d, y: 0.04242494243194528d), radius: 0.07358471684972367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5963313638334208d, y: 0.4834633061854239d), radius: 0.11514600866221247d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8814515454410856d, y: 0.9660711240589521d), radius: 0.38432528404963684d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9620783757034899d, y: 0.5659713535923355d), radius: 0.30883521680324577d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9015861504361615d, y: 0.47293902961737166d), radius: 0.7750435441047259d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21905475696598586d, y: 0.9824918434223802d), radius: 0.31664434563890564d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9374002077390475d, y: 0.15150736678724785d), radius: 0.45560453302379866d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18203302036481428d, y: 0.4754958165082551d), radius: 0.4794905599921676d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8700112111531193d, y: 0.6023307266664057d), radius: 0.66995364243908d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9997597652990025d, y: 0.4146695922815452d), radius: 0.0695507531704469d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12158841332027015d, y: 0.4596046533892333d), radius: 0.41572103048170883d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19404913444334548d, y: 0.01066230823692449d), radius: 0.6571629804939265d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6168231563396518d, y: 0.44315045943497466d), radius: 0.2638871758050578d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9265185651641525d, y: 0.5933468323045975d), radius: 0.9604758011007397d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14642062973650338d, y: 0.8840390322080338d), radius: 0.17178627592301599d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7217920459960205d, y: 0.8586172813340871d), radius: 0.5436083568821374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28931282344994136d, y: 0.9564926581289916d), radius: 0.4885870579425715d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9634912006894438d, y: 0.37291413158166364d), radius: 0.5754622466821876d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7222198554229778d, y: 0.05315763655761663d), radius: 0.7631747220989629d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7919025184031271d, y: 0.5333554374937566d), radius: 0.9191628272937497d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5242801255663213d, y: 0.86067537996513d), radius: 0.7422588237523635d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8148913907100583d, y: 0.5269293742923489d), radius: 0.16102117443866415d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15348169668190137d, y: 0.8506935482386466d), radius: 0.08185324648676051d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6636364494226155d, y: 0.15096299399040114d), radius: 0.3940222124159184d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5388486998005406d, y: 0.28202690185174895d), radius: 0.30892435440059374d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34352533631251225d, y: 0.7006852805255712d), radius: 0.8152756073830025d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4262694856229464d, y: 0.7848408316497009d), radius: 0.6431698809413205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18266230601317746d, y: 0.9167079753525893d), radius: 0.02491615146955073d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023145961267627246d, y: 0.3460002824471018d), radius: 0.7406726963680851d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11492147960630583d, y: 0.2774696262258819d), radius: 0.5275222578938292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3928382770401322d, y: 0.5273659772697482d), radius: 0.12144770594723919d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09183833849186607d, y: 0.8619240326754058d), radius: 0.35430653694313874d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6281284029352998d, y: 0.34795324312948184d), radius: 0.36886361528521794d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7660789118052053d, y: 0.1635890729116477d), radius: 0.13115694036328662d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8954783952675076d, y: 0.08084069037892849d), radius: 0.9095741008368635d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4322353133462694d, y: 0.28319748726614646d), radius: 0.8606482970974595d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38427777582851974d, y: 0.5373019552148587d), radius: 0.13368275144801378d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8491921583779095d, y: 0.06436304696846296d), radius: 0.8883097430347539d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31223123320152935d, y: 0.7565107997787635d), radius: 0.8290551395800528d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6281000131679895d, y: 0.4884303585793439d), radius: 0.47971202822514813d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02969141024986799d, y: 0.0974390936889925d), radius: 0.4569765572028306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7342089937340287d, y: 0.13106195258667974d), radius: 0.9563261209957815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8995239977953631d, y: 0.00433364251411017d), radius: 0.7410870784140027d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.67558122316435d, y: 0.6457130046703148d), radius: 0.9403772836278261d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5542664755202733d, y: 0.44886259859243993d), radius: 0.7283898860036135d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6455589131065053d, y: 0.1145737734482194d), radius: 0.9488250585821112d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08086813660991143d, y: 0.6772096419019592d), radius: 0.9334009281483736d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5054907186696728d, y: 0.9385950083674232d), radius: 0.4090123268104031d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49108230775625517d, y: 0.20737480928371554d), radius: 0.4173686265602202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3951337153883553d, y: 0.11075654414681435d), radius: 0.2722115590009271d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5510583990895701d, y: 0.7047670828258616d), radius: 0.11224311204728166d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8401822166665965d, y: 0.731815586897599d), radius: 0.7795836456857705d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5978068409274783d, y: 0.20283304311707628d), radius: 0.5921119449253038d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15680440064512735d, y: 0.9137953009855673d), radius: 0.3324920223178137d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878217047904011d, y: 0.15644893512615043d), radius: 0.3290698595049236d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8006977742194304d, y: 0.39731831797862815d), radius: 0.47950424349926224d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7831634719582625d, y: 0.7805883296949786d), radius: 0.048233990958435724d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5528532660249753d, y: 0.7395974751082302d), radius: 0.007517997124108167d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6250029128901599d, y: 0.5362477221526508d), radius: 0.09234952650048411d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1288337636403234d, y: 0.6370751774293497d), radius: 0.4640485855332631d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06987280999823264d, y: 0.38156797840404677d), radius: 0.8633139166385017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41093038702877016d, y: 0.9078145758929098d), radius: 0.8579615302787628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6808997655345191d, y: 0.2931951158462791d), radius: 0.9981697230790573d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10081536789210854d, y: 0.5150208564496271d), radius: 0.0014847137589478754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9624950221139343d, y: 0.08653918292522167d), radius: 0.17129932674376003d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37201308345904494d, y: 0.4798193274280542d), radius: 0.7638067903526655d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9540420383213754d, y: 0.8077472198049935d), radius: 0.1800672362941953d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6969383704581701d, y: 0.7908759449701308d), radius: 0.26178825352060464d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47588181836767496d, y: 0.3859650542343299d), radius: 0.7543061608560888d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47934758520586096d, y: 0.6842595053175192d), radius: 0.2673163368578715d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6918129482709585d, y: 0.018544551389448882d), radius: 0.13864397670563822d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11458767136697012d, y: 0.16956938243964714d), radius: 0.5856943639397431d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2962579329261191d, y: 0.7463059542544908d), radius: 0.03546835583059382d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23466558327608456d, y: 0.16860027356177043d), radius: 0.0874272360316154d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3447811453714902d, y: 0.4266839026758904d), radius: 0.3230983267506189d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22045014912358896d, y: 0.7658070804164883d), radius: 0.29282903739218025d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.62581371973373d, y: 0.5165975396614232d), radius: 0.07452635680436082d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8642097446435318d, y: 0.48533473260983007d), radius: 0.09085125835074381d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9065687982399255d, y: 0.7715061297947607d), radius: 0.30622317012531786d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2910982839056798d, y: 0.6329687957564188d), radius: 0.6911782478143638d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36553454292020326d, y: 0.025283120104671264d), radius: 0.6565128420566948d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6344629159861257d, y: 0.39844487786679883d), radius: 0.36342797029363116d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45111225066239724d, y: 0.2815181150068963d), radius: 0.6260275577906129d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4063983229736029d, y: 0.2548551378952595d), radius: 0.7902213238935739d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7234123155475533d, y: 0.8847989397278215d), radius: 0.006532119023665128d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05350092176614851d, y: 0.9515432322494022d), radius: 0.9057360437596566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3927419985954146d, y: 0.7230181108053592d), radius: 0.6790770828462971d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018799846400122555d, y: 0.7115607028712893d), radius: 0.6973489480501258d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5541566440384221d, y: 0.5880194434457483d), radius: 0.8533467437127326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8234420721273212d, y: 0.013945767450229019d), radius: 0.21558039690892972d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03345172204169555d, y: 0.9466084031837437d), radius: 0.36511620485432084d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9894294571253268d, y: 0.7997020501795213d), radius: 0.9707670167354168d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22573641158888702d, y: 0.9445702884946633d), radius: 0.4064894332252189d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1204560008773472d, y: 0.4465595986834897d), radius: 0.49916448448107853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1520101966621319d, y: 0.5886495554255364d), radius: 0.662374122653588d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5684083406933518d, y: 0.3616258409053198d), radius: 0.577591618126882d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6780587277705796d, y: 0.5948658473887423d), radius: 0.8446808236164144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11033590684682026d, y: 0.666713545510488d), radius: 0.5439610794502922d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4675453844736699d, y: 0.4792112179900131d), radius: 0.8554817928586406d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.711626761740509d, y: 0.648170477801177d), radius: 0.26117773760041374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38452743965076996d, y: 0.00337283332947913d), radius: 0.002906230434285506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7961198011084616d, y: 0.6399908573496949d), radius: 0.8522504508655162d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32111639729699604d, y: 0.8224786697495181d), radius: 0.47154094293607607d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41682353149781504d, y: 0.7202636328097632d), radius: 0.21122459190496512d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02911158296547056d, y: 0.32915956883635156d), radius: 0.2761057795951176d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17483270554550456d, y: 0.60722038611796d), radius: 0.0950603299065893d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27151009164795237d, y: 0.192733071088939d), radius: 0.3759328304489922d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06757440352393818d, y: 0.23826263468381048d), radius: 0.429444062560407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7431470833260237d, y: 0.408172662935003d), radius: 0.3684612720787199d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9725245395625112d, y: 0.7610474356656962d), radius: 0.03794103600598964d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4030520628529022d, y: 0.23389226276661346d), radius: 0.993707158808916d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2301286769487524d, y: 0.05307021995877892d), radius: 0.7719828159498592d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7263338108839844d, y: 0.7191346704256968d), radius: 0.9504014864517134d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30434466073236754d, y: 0.2643896467512362d), radius: 0.6336710816110558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9170600095400987d, y: 0.7660814852435219d), radius: 0.9514011266159957d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8279388753698833d, y: 0.7426681774047103d), radius: 0.739314672506897d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8138965081182197d, y: 0.6184196061692141d), radius: 0.9215931909533714d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3466923887581065d, y: 0.6546553490133764d), radius: 0.26787526672285433d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9805788653303613d, y: 0.06918773084978802d), radius: 0.006039202467734706d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5361322564586841d, y: 0.9930899319700262d), radius: 0.6495811154871739d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7473725580875735d, y: 0.16834928630592194d), radius: 0.3992748478774343d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2665027408285665d, y: 0.8334787602161507d), radius: 0.701989472939394d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8413628247663237d, y: 0.09560115604706887d), radius: 0.20354826556256966d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6325901150051304d, y: 0.8151677608860369d), radius: 0.08696731553765957d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21025509096254114d, y: 0.2865276822758993d), radius: 0.6677620252925751d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.946416429535768d, y: 0.13347150057351898d), radius: 0.2423971872399685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8771745850881693d, y: 0.9074807938041469d), radius: 0.40258823739895755d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.382711779426834d, y: 0.4698614249333505d), radius: 0.865737260022207d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9630564488951877d, y: 0.851099099872506d), radius: 0.7913864422162905d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5083681808880789d, y: 0.2950497436170242d), radius: 0.3680431942140837d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47902750643674696d, y: 0.7195748193737251d), radius: 0.779078900258812d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6208270350739314d, y: 0.27369876702787244d), radius: 0.9076616465091996d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8547076759537497d, y: 0.05796276271097123d), radius: 0.4416604156121853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48562668623835026d, y: 0.21597838046907658d), radius: 0.5466460533090709d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8943707537143366d, y: 0.9359262186194828d), radius: 0.7774849626748376d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.942446864842325d, y: 0.04353669039135488d), radius: 0.025672121320045704d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7263553081401832d, y: 0.26054868887848504d), radius: 0.9085365283136977d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34772538328847824d, y: 0.5655519702483919d), radius: 0.8500449570780007d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2744709855082791d, y: 0.0061979145548654024d), radius: 0.38774613101001754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07322243778860049d, y: 0.895213480199927d), radius: 0.5570785928038773d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.558914942080579d, y: 0.0586760754223834d), radius: 0.1516342207157767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9646149989658424d, y: 0.9855909693068278d), radius: 0.7517498464303112d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6902419499852372d, y: 0.671945707960241d), radius: 0.8012344494786241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2613005430016285d, y: 0.7619481330465514d), radius: 0.5018275623660589d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.217919850214641d, y: 0.18635761729102085d), radius: 0.06173453834919407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18680915783579022d, y: 0.8847797972574236d), radius: 0.9758120825722116d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5843689038210312d, y: 0.29605900344832925d), radius: 0.06298956141798207d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16082147218145326d, y: 0.3105456499819408d), radius: 0.5099044764437136d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9551824249187025d, y: 0.4925796976770108d), radius: 0.13152294789710073d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 156;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 84, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 23, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 151, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 143, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 26, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 94, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 143, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[29], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[30], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[30], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI), typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                await ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

