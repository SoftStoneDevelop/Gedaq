

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9874490658881048d, y: 0.47493304202598496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16853448957544603d, y: 0.19489139224832153d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08535183721406758d, y: 0.8761445378031433d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29048033213306423d, y: 0.14954037035137668d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11643562780260008d, y: 0.6519608265209723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07412862925517694d, y: 0.7090885182983886d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32433447906243695d, y: 0.4060049157103336d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17314055268117456d, y: 0.5712756110319377d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9762104710952223d, y: 0.23453055988306504d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2466517614613999d, y: 0.122923178674059d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8918203090331476d, y: 0.11974260336169662d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9445477144871653d, y: 0.9018837808214956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43497755472590405d, y: 0.2966482902120987d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9420802061416744d, y: 0.15189602969002036d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9428497595464439d, y: 0.2861785760135197d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23781842556049193d, y: 0.8000511945687081d),
new NpgsqlTypes.NpgsqlPoint(x: 0.144720232091206d, y: 0.9436678691959591d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4366095207093402d, y: 0.5722920959283935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9453342697093521d, y: 0.2804207230815732d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2777989402505524d, y: 0.38112018456639074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09557742242153111d, y: 0.616587400754771d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26552634888939075d, y: 0.0017081707844527338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17117666114987362d, y: 0.7946312252367391d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10631871775376278d, y: 0.01704098997142156d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30336641467297365d, y: 0.0051509043834391255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9798622727936126d, y: 0.26278513087203137d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04741774613847338d, y: 0.552984660761908d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7119152423609006d, y: 0.8410128533795195d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11155406380666988d, y: 0.6678461967953134d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42516786269825635d, y: 0.5909960118731643d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24127975603100138d, y: 0.059920391353253444d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46008089482457626d, y: 0.9355458308483938d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12474970596279134d, y: 0.3446858917009751d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0682241648068348d, y: 0.822123994910182d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44389681399585545d, y: 0.03401031511649533d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06529001451890215d, y: 0.47440273214820305d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16495149987985414d, y: 0.3848408370947559d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15072587920596547d, y: 0.4022626831522832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9158961954021616d, y: 0.7017252451967506d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4945739949264055d, y: 0.6786916992043942d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20187923821762266d, y: 0.4658733701436846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5756452935342322d, y: 0.0756903686241126d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32345364578156766d, y: 0.7495766097853289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03112823859080116d, y: 0.789291268307316d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30088375716090887d, y: 0.7369848493401658d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4599263300428752d, y: 0.4856596676276139d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7037551817729744d, y: 0.9433605484471814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04416011112157614d, y: 0.1808152026010621d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9720881829999909d, y: 0.7319529341869445d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27164876087243006d, y: 0.0791804999883734d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8956781914091623d, y: 0.38170547449981285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1666422140183519d, y: 0.9465048145878165d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7607365609446722d, y: 0.956466976909064d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9975929277972649d, y: 0.07417966417846678d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6009278204946168d, y: 0.7528021011579382d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6183032831895614d, y: 0.7258152762952222d),
new NpgsqlTypes.NpgsqlPoint(x: 0.015755796409504086d, y: 0.7393568997173728d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44152060553950734d, y: 0.3430362312199692d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3136777210254783d, y: 0.33796430684553647d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7607822486710197d, y: 0.459204633194522d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5623593063925528d, y: 0.2297230974037353d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28530048918781636d, y: 0.6051574260839949d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12326801277627042d, y: 0.5661832116381548d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9014516192309919d, y: 0.7141646349328138d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10740211776698394d, y: 0.2789396378570025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28791489345535703d, y: 0.8762297066819508d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5035442922542723d, y: 0.15764622801832529d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2985057211302994d, y: 0.7386312161008486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9593240721750438d, y: 0.8798238972048217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29235761718573117d, y: 0.5999523400773666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14734029924581127d, y: 0.27430360961135214d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6507263032712169d, y: 0.8549562960091986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.618121363546043d, y: 0.0805759220224973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0929962777355271d, y: 0.5011158180697355d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23498104657153973d, y: 0.13904669388376867d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41949053061359365d, y: 0.17744244230711081d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4456381863972977d, y: 0.6318536747897727d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9155899240184684d, y: 0.10210557407787679d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22582448576541492d, y: 0.6086394193880672d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5249677216169865d, y: 0.12425978742619981d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8952503927698698d, y: 0.6763818556670633d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9800293562899612d, y: 0.9642042872162166d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8404162874072822d, y: 0.3563127521431113d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1831211209453777d, y: 0.46102561718374635d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1632433977333395d, y: 0.6194853096043463d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6854630384679932d, y: 0.025133398522741213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4979643361747169d, y: 0.3965133037542242d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6306831430836307d, y: 0.3345350325612769d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6642729186719195d, y: 0.9031786207662738d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9867752544022731d, y: 0.22793519109654103d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9650532562902483d, y: 0.05813171045422494d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6606580843781945d, y: 0.03812682278466062d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24768336676618952d, y: 0.7451588483385664d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4564724049490695d, y: 0.9899420205232354d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9215134063215317d, y: 0.45072546411943004d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20958469121710221d, y: 0.1700669061153528d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8575172621122791d, y: 0.3140103164664102d),
new NpgsqlTypes.NpgsqlPoint(x: 0.427703678099145d, y: 0.5021854183893283d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34030071907532344d, y: 0.9304078656363928d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4429096587200304d, y: 0.21002179018157163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7492945137175491d, y: 0.4321197382984797d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43370583017064146d, y: 0.7229166526510258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.280455781058188d, y: 0.7322504196459951d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7795174656393608d, y: 0.08980144766222853d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8721576452936325d, y: 0.5057507833845604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15950927433991557d, y: 0.7571957985104277d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2979232057483385d, y: 0.9307870940987569d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9144504573526733d, y: 0.08823102648520564d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06681320669446456d, y: 0.13823293530134206d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44973770358509646d, y: 0.45947231977789904d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19694084359892394d, y: 0.9419148534528681d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.001974319488312948d, y: 0.5180518513461385d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30441191588427174d, y: 0.18927604849395008d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8416952545936189d, y: 0.1583723423805059d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7266242037517545d, y: 0.7978392981275332d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9876959876896974d, y: 0.19396383450189947d),
new NpgsqlTypes.NpgsqlPoint(x: 0.009133220326222768d, y: 0.1294895372691688d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11691305654561646d, y: 0.625504988304055d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2952096629254545d, y: 0.7925444279930615d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07753354134128987d, y: 0.8620340083785661d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6318385768231425d, y: 0.6013119662214329d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6423282261458699d, y: 0.0204728756868785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9735800625293676d, y: 0.776009114087878d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44395510906458713d, y: 0.6436921212785442d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5163589348581417d, y: 0.5503902361057417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9961931349064957d, y: 0.690562068422026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5689392115053709d, y: 0.3148427563918388d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9789145577067385d, y: 0.3327947138985555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.759643050438419d, y: 0.08623956874783145d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6372290392551508d, y: 0.954649196425583d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28063788697474523d, y: 0.4353940411126054d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1943448330787657d, y: 0.9757678722493884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5126392439227849d, y: 0.4004879156318726d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9789680701259791d, y: 0.6260650841618962d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.764623325533235d, y: 0.9537020534972518d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5923385049567879d, y: 0.5471784220187828d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19129067055281268d, y: 0.6294195924810132d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9050208977753793d, y: 0.5768436504043745d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7640416020786033d, y: 0.25696978204731435d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3542845835492786d, y: 0.7055995199264404d),
new NpgsqlTypes.NpgsqlPoint(x: 0.998512714311762d, y: 0.6286356508850306d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.830984106618174d, y: 0.5496874524783245d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38092603017173754d, y: 0.34179734687135144d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5175297081086618d, y: 0.9077284863687628d),
new NpgsqlTypes.NpgsqlPoint(x: 0.806562414985063d, y: 0.528556885482448d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6028670855658214d, y: 0.9903633483076902d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19052540503171256d, y: 0.038823617582807834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35883357299458185d, y: 0.02980759249182785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20160460641415467d, y: 0.5320396422753252d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9365043381201642d, y: 0.7054632197656479d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2787044402761648d, y: 0.06261832930694788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4449352100123788d, y: 0.11214556296144007d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42279561023324697d, y: 0.7295937723224842d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7909762185804246d, y: 0.49978114378460636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9739576094760326d, y: 0.9191023778806935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19136597319575388d, y: 0.7893725896522654d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7569504995871692d, y: 0.07242909055805025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6882059470506415d, y: 0.10785111044780882d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5010440912644542d, y: 0.09665277125482774d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7195072608263784d, y: 0.34697382901025897d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7518018544461991d, y: 0.7498335713880665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2305725569845234d, y: 0.14803494724755373d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32365114591386834d, y: 0.14120282471254952d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8139145718255536d, y: 0.6167299035676421d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5140306948672764d, y: 0.1965527391008769d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2490692165912557d, y: 0.9315212587162244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40290506464196185d, y: 0.04002764894125421d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03347504678319735d, y: 0.9621840563338815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6221441202754507d, y: 0.8261934395733993d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5657013921388653d, y: 0.137791575529691d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7874146983036506d, y: 0.5837948705600233d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46530866581302066d, y: 0.8611062673308079d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5958411368628438d, y: 0.22229483352649537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5544525737254996d, y: 0.37938587340257757d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5536426387453002d, y: 0.44344996280448945d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7414998700621077d, y: 0.057289701595189535d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1124741949876723d, y: 0.7449031640085908d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7032937638024812d, y: 0.3286203373502915d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.031771107228305784d, y: 0.6269821675642784d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9688512840565457d, y: 0.6300003130307609d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07575168333347815d, y: 0.09379701997181722d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2589092416324189d, y: 0.10545341588983193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1820278742692213d, y: 0.5650140613201929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3097274416633905d, y: 0.7459227828252416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1407220111904145d, y: 0.2653240409048747d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9954711961163157d, y: 0.4215965951424391d),
new NpgsqlTypes.NpgsqlPoint(x: 0.014966840144699955d, y: 0.46215247134510984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7746000496754967d, y: 0.7639018155147674d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48725833602073076d, y: 0.19018036096061508d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.426498015998521d, y: 0.2111877412803419d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7532485747757885d, y: 0.8531483477130817d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14115516706105125d, y: 0.058940592809068715d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6079529206687314d, y: 0.5645706759367289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6479319425756301d, y: 0.9450942329263239d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3739134459208563d, y: 0.9044952889090621d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7157082395133902d, y: 0.5216352165868308d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3614816358935711d, y: 0.025103974629152703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7043171249889679d, y: 0.4374298495275807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9254872431308765d, y: 0.21871043883267116d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6026219888253654d, y: 0.8907783828185487d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6543539738288783d, y: 0.4329967511305082d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2924845383863842d, y: 0.8292587520389609d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9698754825008501d, y: 0.8609932738350097d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21570899095491847d, y: 0.16158085891202534d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7433058808324687d, y: 0.7057460463183686d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47914955396594194d, y: 0.9498726342959706d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07525185340540363d, y: 0.03218780268833199d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36804307928908453d, y: 0.9619449979006616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3358898879350837d, y: 0.3727492622345018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1829612998279152d, y: 0.18059407473342393d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5055342605264971d, y: 0.5139060284212449d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44937733855434314d, y: 0.2420702206037525d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6965559668921482d, y: 0.5861261678886457d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16740470247280503d, y: 0.6064709127692788d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44331253734254306d, y: 0.09580938235145275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.780105622528473d, y: 0.6127060118326344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7991518675949655d, y: 0.814216256859701d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2824465066541132d, y: 0.679076381267122d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4884394533789739d, y: 0.2695302637893333d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36111606100861315d, y: 0.7041776129795785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3199923770216667d, y: 0.48129853281267d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8474245612548562d, y: 0.24000652988720717d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5056604463449549d, y: 0.038484857577179454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5721895998412533d, y: 0.2353504852251408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6391694767956388d, y: 0.7478756301797496d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4954011868130529d, y: 0.9079613455966562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8422853627460396d, y: 0.6173626344439266d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8728903704564644d, y: 0.5938038532818428d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2728001073063354d, y: 0.9888188555671314d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4151322344568802d, y: 0.350366438111846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9579976755420582d, y: 0.9521201043045023d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48966575965468606d, y: 0.016229207148808822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.910486711724089d, y: 0.45338397747355175d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9879646289742893d, y: 0.01858748039801117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4513126993080002d, y: 0.1406241271367521d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2660222303017016d, y: 0.7212313519358801d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6160736003897023d, y: 0.09300074313506124d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8784460870421559d, y: 0.38043629362215636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7002324949434999d, y: 0.482944675486072d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4175923799273412d, y: 0.09197214518936714d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7021353503385284d, y: 0.03474229796480832d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5488522602729811d, y: 0.9737413527516069d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9642786938412639d, y: 0.6376120361499037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6123207513337521d, y: 0.09243788749535942d),
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
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4945739949264055d, y: 0.6786916992043942d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20187923821762266d, y: 0.4658733701436846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5756452935342322d, y: 0.0756903686241126d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2985057211302994d, y: 0.7386312161008486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9593240721750438d, y: 0.8798238972048217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29235761718573117d, y: 0.5999523400773666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14734029924581127d, y: 0.27430360961135214d),
}));
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1632433977333395d, y: 0.6194853096043463d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6854630384679932d, y: 0.025133398522741213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4979643361747169d, y: 0.3965133037542242d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6306831430836307d, y: 0.3345350325612769d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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

                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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

                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
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

                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatchAsync(connection, 4, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
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
                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatch(connection, 58, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

