

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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.018161826064743036d, b: 0.45270436297367833d, c: 0.845710296689907d),
new NpgsqlTypes.NpgsqlLine(a: 0.7675463570406548d, b: 0.22514785530867099d, c: 0.8163457744378502d),
new NpgsqlTypes.NpgsqlLine(a: 0.8074816647867012d, b: 0.862755770216892d, c: 0.9988689321368794d),
new NpgsqlTypes.NpgsqlLine(a: 0.5542054595302275d, b: 0.1423093651203836d, c: 0.8517729497316897d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7074347921962456d, b: 0.20721279046522623d, c: 0.5800546715179657d),
new NpgsqlTypes.NpgsqlLine(a: 0.6880393530477944d, b: 0.9956528144068917d, c: 0.7741519021106779d),
new NpgsqlTypes.NpgsqlLine(a: 0.9672561038295103d, b: 0.06513842588891905d, c: 0.6293633606215968d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3970742566935114d, b: 0.8384532310718416d, c: 0.22124948009796608d),
new NpgsqlTypes.NpgsqlLine(a: 0.17980892388732528d, b: 0.9250251790832753d, c: 0.16629020672614736d),
new NpgsqlTypes.NpgsqlLine(a: 0.06799977402498025d, b: 0.6682218937674049d, c: 0.08456044175560773d),
new NpgsqlTypes.NpgsqlLine(a: 0.5107017571747068d, b: 0.30287015894064717d, c: 0.2620863158452176d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8362940839195477d, b: 0.8125367763307516d, c: 0.6272748639884549d),
new NpgsqlTypes.NpgsqlLine(a: 0.49711929028362656d, b: 0.8461875508604834d, c: 0.44619201672718356d),
new NpgsqlTypes.NpgsqlLine(a: 0.19170635763100907d, b: 0.32576128968015994d, c: 0.8073475892171801d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.464541425318055d, b: 0.10247667023785212d, c: 0.14326193437599155d),
new NpgsqlTypes.NpgsqlLine(a: 0.8493777303883147d, b: 0.9829190695869074d, c: 0.12845900242652653d),
new NpgsqlTypes.NpgsqlLine(a: 0.9283296631756248d, b: 0.6507137180461282d, c: 0.6644414271001932d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33829735224431634d, b: 0.36891125481240805d, c: 0.011928573589673919d),
new NpgsqlTypes.NpgsqlLine(a: 0.9738555476259398d, b: 0.4593734760126036d, c: 0.3826119010342267d),
new NpgsqlTypes.NpgsqlLine(a: 0.8948993916197144d, b: 0.10102990108341436d, c: 0.27648269427011185d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.424730279973784d, b: 0.477664293844833d, c: 0.734316503739256d),
new NpgsqlTypes.NpgsqlLine(a: 0.9534370889838094d, b: 0.17220883667426334d, c: 0.19345232744748908d),
new NpgsqlTypes.NpgsqlLine(a: 0.31668035974796327d, b: 0.10254040141929643d, c: 0.7205975432453442d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.44467432193481704d, b: 0.6772494592097466d, c: 0.014748405448347546d),
new NpgsqlTypes.NpgsqlLine(a: 0.9587144594646442d, b: 0.6440466677132821d, c: 0.0402532407035503d),
new NpgsqlTypes.NpgsqlLine(a: 0.9628893021046518d, b: 0.9413608538191081d, c: 0.5541559823275555d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7046816265097854d, b: 0.27278726019575705d, c: 0.3790593928391123d),
new NpgsqlTypes.NpgsqlLine(a: 0.15544030320722457d, b: 0.45933394328382593d, c: 0.9883064647326313d),
new NpgsqlTypes.NpgsqlLine(a: 0.6479510231885007d, b: 0.32072345454631457d, c: 0.41894456293820914d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03601879520583051d, b: 0.7507080720590519d, c: 0.6247202355313894d),
new NpgsqlTypes.NpgsqlLine(a: 0.8609085546685449d, b: 0.9566768032442284d, c: 0.4798074414569037d),
new NpgsqlTypes.NpgsqlLine(a: 0.5179300310802131d, b: 0.016208847716722596d, c: 0.7792359132680661d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.58757878634374d, b: 0.6625462795904401d, c: 0.8571637270996827d),
new NpgsqlTypes.NpgsqlLine(a: 0.3877446569917482d, b: 0.5075257066330201d, c: 0.9245319872755456d),
new NpgsqlTypes.NpgsqlLine(a: 0.648103970011773d, b: 0.8195986271933163d, c: 0.6206737243352156d),
new NpgsqlTypes.NpgsqlLine(a: 0.5820456342769691d, b: 0.7083794025599938d, c: 0.5521504131426378d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17938324456161903d, b: 0.9220511981221395d, c: 0.645162972442288d),
new NpgsqlTypes.NpgsqlLine(a: 0.6844097727957426d, b: 0.7547639175152142d, c: 0.855823763379482d),
new NpgsqlTypes.NpgsqlLine(a: 0.16981199060838914d, b: 0.43947646989965705d, c: 0.19221084604350136d),
new NpgsqlTypes.NpgsqlLine(a: 0.56342058931322d, b: 0.18276518401417052d, c: 0.7250534510191202d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2997756675354508d, b: 0.6986966001916957d, c: 0.16392085478257978d),
new NpgsqlTypes.NpgsqlLine(a: 0.9744795480282229d, b: 0.33287677258820947d, c: 0.0252321516491395d),
new NpgsqlTypes.NpgsqlLine(a: 0.6173484294698811d, b: 0.7744731947895965d, c: 0.11210565976599196d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32830119623553033d, b: 0.8698710750973673d, c: 0.05053832254564916d),
new NpgsqlTypes.NpgsqlLine(a: 0.9220175854276109d, b: 0.3862669873012091d, c: 0.3031482179772089d),
new NpgsqlTypes.NpgsqlLine(a: 0.06874390652412699d, b: 0.31786523007233514d, c: 0.4801394870133999d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7970421835903604d, b: 0.18980695124989455d, c: 0.3057898134695741d),
new NpgsqlTypes.NpgsqlLine(a: 0.7367407856596306d, b: 0.5648509389756254d, c: 0.3630939779857314d),
new NpgsqlTypes.NpgsqlLine(a: 0.5838135130109234d, b: 0.602057714814129d, c: 0.06068092486043797d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8833875377773683d, b: 0.14064419380399473d, c: 0.652904185031598d),
new NpgsqlTypes.NpgsqlLine(a: 0.31425028716529146d, b: 0.5575686407441973d, c: 0.6152278811552656d),
new NpgsqlTypes.NpgsqlLine(a: 0.8990141071364655d, b: 0.6608405587389281d, c: 0.4846263839638614d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9696086107623592d, b: 0.17270261204724457d, c: 0.08852273775704955d),
new NpgsqlTypes.NpgsqlLine(a: 0.9711355366105584d, b: 0.006626423806363024d, c: 0.22127525714338436d),
new NpgsqlTypes.NpgsqlLine(a: 0.31652528718260475d, b: 0.7679914294800276d, c: 0.23797008047917134d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6310890660211113d, b: 0.15431289695680173d, c: 0.9185847347252878d),
new NpgsqlTypes.NpgsqlLine(a: 0.7335336750029751d, b: 0.6232623969832704d, c: 0.8910369040530318d),
new NpgsqlTypes.NpgsqlLine(a: 0.8577667680504544d, b: 0.7919496690414483d, c: 0.33214558558667384d),
new NpgsqlTypes.NpgsqlLine(a: 0.6524439970644597d, b: 0.4640834081778361d, c: 0.8017780965382685d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9047954732383058d, b: 0.29147105553555197d, c: 0.015033167152118665d),
new NpgsqlTypes.NpgsqlLine(a: 0.5246292718306784d, b: 0.5755919685642429d, c: 0.37325104267283327d),
new NpgsqlTypes.NpgsqlLine(a: 0.8356600328299908d, b: 0.2657988254672916d, c: 0.5941540917425018d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9075371454848437d, b: 0.0984757423411311d, c: 0.9382899421502773d),
new NpgsqlTypes.NpgsqlLine(a: 0.1441071913088129d, b: 0.3466198282231925d, c: 0.038275661711293596d),
new NpgsqlTypes.NpgsqlLine(a: 0.6771286647571236d, b: 0.06429298853723875d, c: 0.5296853282083368d),
new NpgsqlTypes.NpgsqlLine(a: 0.9509592162283911d, b: 0.4539116776188675d, c: 0.38888264995984834d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19789665958665403d, b: 0.8183874452013024d, c: 0.5415185748863016d),
new NpgsqlTypes.NpgsqlLine(a: 0.6675437304200404d, b: 0.8186629908830441d, c: 0.10355093859201259d),
new NpgsqlTypes.NpgsqlLine(a: 0.5711534300633364d, b: 0.35700326781858516d, c: 0.9582253068500105d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5090523919349641d, b: 0.49111961545640825d, c: 0.8435601538219601d),
new NpgsqlTypes.NpgsqlLine(a: 0.04618615080456545d, b: 0.6263335798179375d, c: 0.4257304523496762d),
new NpgsqlTypes.NpgsqlLine(a: 0.2049424003824506d, b: 0.5323405159996317d, c: 0.08011809644443235d),
new NpgsqlTypes.NpgsqlLine(a: 0.29870718090563597d, b: 0.5034601348980555d, c: 0.6608896510481903d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6008959662623875d, b: 0.6126508315707108d, c: 0.6454589920107965d),
new NpgsqlTypes.NpgsqlLine(a: 0.2009776097895266d, b: 0.5882150080405864d, c: 0.5004396243630128d),
new NpgsqlTypes.NpgsqlLine(a: 0.3158630436435045d, b: 0.6813078180253141d, c: 0.787543983705059d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4279081489549663d, b: 0.19061797999791552d, c: 0.17049673138343124d),
new NpgsqlTypes.NpgsqlLine(a: 0.31787247593355705d, b: 0.7421346605813253d, c: 0.11991415332527344d),
new NpgsqlTypes.NpgsqlLine(a: 0.47589965328295203d, b: 0.3776183519923513d, c: 0.846350365804711d),
new NpgsqlTypes.NpgsqlLine(a: 0.33155947846808387d, b: 0.774690418902604d, c: 0.9671160050068083d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21304250533235103d, b: 0.761542310442888d, c: 0.7587538089219301d),
new NpgsqlTypes.NpgsqlLine(a: 0.7317785247925339d, b: 0.0075831932198066054d, c: 0.2673680572364696d),
new NpgsqlTypes.NpgsqlLine(a: 0.20647056221455418d, b: 0.5327611354775965d, c: 0.18883024008813354d),
new NpgsqlTypes.NpgsqlLine(a: 0.06813389707683881d, b: 0.7372997631192628d, c: 0.7271825326562524d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.973609366780071d, b: 0.8854556667070943d, c: 0.6684932150349882d),
new NpgsqlTypes.NpgsqlLine(a: 0.8767980863739557d, b: 0.8699433929013615d, c: 0.024328247964115257d),
new NpgsqlTypes.NpgsqlLine(a: 0.050113985188831145d, b: 0.5541449628754899d, c: 0.2504419467345559d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4494410167818751d, b: 0.5221436299780479d, c: 0.6811444050397498d),
new NpgsqlTypes.NpgsqlLine(a: 0.19956507493060616d, b: 0.597527288794204d, c: 0.711196160487919d),
new NpgsqlTypes.NpgsqlLine(a: 0.8352411716095093d, b: 0.35160846468014106d, c: 0.9166683955287998d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6499566434744855d, b: 0.00981361561174432d, c: 0.3872638578586539d),
new NpgsqlTypes.NpgsqlLine(a: 0.1295773587087533d, b: 0.4711287000418125d, c: 0.3737554968028115d),
new NpgsqlTypes.NpgsqlLine(a: 0.5625020884467391d, b: 0.5394686461355953d, c: 0.4190277601736715d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46652812744724115d, b: 0.9333227393104545d, c: 0.811214215355107d),
new NpgsqlTypes.NpgsqlLine(a: 0.1900340751599653d, b: 0.5739260269132327d, c: 0.7418947782448871d),
new NpgsqlTypes.NpgsqlLine(a: 0.41856725850841237d, b: 0.671054197356617d, c: 0.31103747950926974d),
new NpgsqlTypes.NpgsqlLine(a: 0.441855771655259d, b: 0.6427091955746367d, c: 0.7412775037229558d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0889519723702854d, b: 0.18341614399429107d, c: 0.30665001528618707d),
new NpgsqlTypes.NpgsqlLine(a: 0.5230532857387672d, b: 0.4938793669638347d, c: 0.4065051746831436d),
new NpgsqlTypes.NpgsqlLine(a: 0.14893413864286553d, b: 0.4575731168160855d, c: 0.8619484992805554d),
new NpgsqlTypes.NpgsqlLine(a: 0.640537343015303d, b: 0.8592582766565889d, c: 0.835699878672184d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5070921849315377d, b: 0.369632118018024d, c: 0.9032465847308666d),
new NpgsqlTypes.NpgsqlLine(a: 0.9051250128239033d, b: 0.13152886278993126d, c: 0.8106682784653023d),
new NpgsqlTypes.NpgsqlLine(a: 0.3688392760308401d, b: 0.33002211662213166d, c: 0.4511729470241822d),
new NpgsqlTypes.NpgsqlLine(a: 0.6214419950403006d, b: 0.6803140247589572d, c: 0.8849361126024209d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10863237093667799d, b: 0.4248834426626301d, c: 0.5779054212453332d),
new NpgsqlTypes.NpgsqlLine(a: 0.8440869295330552d, b: 0.9928435176576327d, c: 0.2885498488642281d),
new NpgsqlTypes.NpgsqlLine(a: 0.5835617975812195d, b: 0.12742537130384224d, c: 0.17034678919277446d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09084802964160166d, b: 0.8168414688223092d, c: 0.8343223102096047d),
new NpgsqlTypes.NpgsqlLine(a: 0.5353748661877745d, b: 0.38804195433396316d, c: 0.9194738157593432d),
new NpgsqlTypes.NpgsqlLine(a: 0.8301492492093833d, b: 0.2968199803157512d, c: 0.5433774087049974d),
new NpgsqlTypes.NpgsqlLine(a: 0.7540973699696841d, b: 0.0326940808745555d, c: 0.07434934993850784d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9131009427481732d, b: 0.6247522082556657d, c: 0.6234386565201053d),
new NpgsqlTypes.NpgsqlLine(a: 0.16622951502545635d, b: 0.912685626006504d, c: 0.6143505849132733d),
new NpgsqlTypes.NpgsqlLine(a: 0.8279173306339994d, b: 0.634676920815375d, c: 0.5327209171200887d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.02715957115629708d, b: 0.36215172982800403d, c: 0.2587903393235367d),
new NpgsqlTypes.NpgsqlLine(a: 0.27638230402741426d, b: 0.4766557008685529d, c: 0.7302049979983299d),
new NpgsqlTypes.NpgsqlLine(a: 0.07082606620056064d, b: 0.31119492578381247d, c: 0.5292622754091663d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.850452842376781d, b: 0.1660038008204966d, c: 0.6863880446747023d),
new NpgsqlTypes.NpgsqlLine(a: 0.10177849700187747d, b: 0.0796020685796065d, c: 0.7398037376228058d),
new NpgsqlTypes.NpgsqlLine(a: 0.8384093788609206d, b: 0.45690234741334135d, c: 0.08744394335085903d),
new NpgsqlTypes.NpgsqlLine(a: 0.08428841355875383d, b: 0.9412102346884644d, c: 0.2933036796034231d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6109233090725508d, b: 0.7610423555980016d, c: 0.2671481757553269d),
new NpgsqlTypes.NpgsqlLine(a: 0.32232927643059694d, b: 0.6763895120270268d, c: 0.8887533153522489d),
new NpgsqlTypes.NpgsqlLine(a: 0.7025207604264136d, b: 0.5383870718223563d, c: 0.09402314094141462d),
new NpgsqlTypes.NpgsqlLine(a: 0.8937111869546921d, b: 0.37893553165167015d, c: 0.6878085535903626d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9929149109552655d, b: 0.4495327656207341d, c: 0.7372464854365205d),
new NpgsqlTypes.NpgsqlLine(a: 0.4325592119306698d, b: 0.8821050432485249d, c: 0.3488759246042805d),
new NpgsqlTypes.NpgsqlLine(a: 0.8428319466612078d, b: 0.6927731564124603d, c: 0.06456138112859333d),
new NpgsqlTypes.NpgsqlLine(a: 0.6839500081909069d, b: 0.8365827083806365d, c: 0.7243766277978702d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9794771747226064d, b: 0.0695571770978698d, c: 0.9916991199329418d),
new NpgsqlTypes.NpgsqlLine(a: 0.22777513654774162d, b: 0.4154251826542036d, c: 0.41652845853976483d),
new NpgsqlTypes.NpgsqlLine(a: 0.5845361055463594d, b: 0.08985861537965101d, c: 0.6666449233415654d),
new NpgsqlTypes.NpgsqlLine(a: 0.6770346033488583d, b: 0.1345988884495487d, c: 0.9924553063867012d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08083812711427085d, b: 0.15399214305168896d, c: 0.9205841433834823d),
new NpgsqlTypes.NpgsqlLine(a: 0.8807213245541575d, b: 0.2840215373980638d, c: 0.967290832857423d),
new NpgsqlTypes.NpgsqlLine(a: 0.6103096293176113d, b: 0.29333857291024557d, c: 0.2323377354131393d),
new NpgsqlTypes.NpgsqlLine(a: 0.09903704594546214d, b: 0.9266864678657363d, c: 0.5901914389992264d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9797898070189903d, b: 0.6462574422879198d, c: 0.2200846645682366d),
new NpgsqlTypes.NpgsqlLine(a: 0.8716349823844592d, b: 0.4578837157637575d, c: 0.16116248693513957d),
new NpgsqlTypes.NpgsqlLine(a: 0.386751665342415d, b: 0.9792138220486586d, c: 0.919281409199192d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8663592114026465d, b: 0.4285759534211613d, c: 0.25986554254198846d),
new NpgsqlTypes.NpgsqlLine(a: 0.9294341435246598d, b: 0.1134462792254819d, c: 0.9197476034825823d),
new NpgsqlTypes.NpgsqlLine(a: 0.8955958876006381d, b: 0.33589013001081147d, c: 0.27908659692328164d),
new NpgsqlTypes.NpgsqlLine(a: 0.7680791952408843d, b: 0.3573137776124864d, c: 0.06127849376353467d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.016015986090698653d, b: 0.09420425347296324d, c: 0.9753596553006519d),
new NpgsqlTypes.NpgsqlLine(a: 0.9414342690402074d, b: 0.8475291165478275d, c: 0.7470651219073745d),
new NpgsqlTypes.NpgsqlLine(a: 0.22565409118898672d, b: 0.4986266178782064d, c: 0.558979174798599d),
new NpgsqlTypes.NpgsqlLine(a: 0.3191876077631651d, b: 0.9531763053071347d, c: 0.15411807529505428d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4472580431008051d, b: 0.22304728136904373d, c: 0.07087967915915272d),
new NpgsqlTypes.NpgsqlLine(a: 0.00213966160266299d, b: 0.4637011836215992d, c: 0.9167896639873733d),
new NpgsqlTypes.NpgsqlLine(a: 0.2962307396767513d, b: 0.5195481021228747d, c: 0.1603054254620463d),
new NpgsqlTypes.NpgsqlLine(a: 0.6323419409920359d, b: 0.6021490694178365d, c: 0.5155819223813177d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31151726360671217d, b: 0.9946770747889445d, c: 0.8592107202061438d),
new NpgsqlTypes.NpgsqlLine(a: 0.5163473014321456d, b: 0.4973380780887037d, c: 0.10468237602799457d),
new NpgsqlTypes.NpgsqlLine(a: 0.6970825607438683d, b: 0.33352861444634163d, c: 0.2927490984628328d),
new NpgsqlTypes.NpgsqlLine(a: 0.9493700924728087d, b: 0.03962175350468089d, c: 0.15934602284210553d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3674628404144161d, b: 0.27264464406026356d, c: 0.8164494326983759d),
new NpgsqlTypes.NpgsqlLine(a: 0.5330812286033121d, b: 0.8250137295746165d, c: 0.9246885937171908d),
new NpgsqlTypes.NpgsqlLine(a: 0.48511176887812946d, b: 0.03899125324838104d, c: 0.0893392448764444d),
new NpgsqlTypes.NpgsqlLine(a: 0.3015175141117623d, b: 0.4751405137818612d, c: 0.12814155157246265d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7856597391995008d, b: 0.1757889788521082d, c: 0.7997159784944536d),
new NpgsqlTypes.NpgsqlLine(a: 0.4482410327404568d, b: 0.8749828066907721d, c: 0.5930168171829522d),
new NpgsqlTypes.NpgsqlLine(a: 0.2232274312580952d, b: 0.6466875620300472d, c: 0.6683423960115589d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6193039435842794d, b: 0.4357371400883956d, c: 0.9779624400614126d),
new NpgsqlTypes.NpgsqlLine(a: 0.9363394129636337d, b: 0.6130114104588306d, c: 0.025257376362183503d),
new NpgsqlTypes.NpgsqlLine(a: 0.5953700108553845d, b: 0.659278450737205d, c: 0.11317823879535849d),
new NpgsqlTypes.NpgsqlLine(a: 0.3327641651077663d, b: 0.7625942151807611d, c: 0.14071158756246016d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.033406836716104005d, b: 0.5363367486743432d, c: 0.46591838939831876d),
new NpgsqlTypes.NpgsqlLine(a: 0.9529703427004033d, b: 0.631752804249531d, c: 0.489369918111874d),
new NpgsqlTypes.NpgsqlLine(a: 0.24746740045731208d, b: 0.716957644747382d, c: 0.2510661876325898d),
new NpgsqlTypes.NpgsqlLine(a: 0.5453227536508053d, b: 0.3927704541496879d, c: 0.702303473205736d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38672510388025094d, b: 0.8334627478326788d, c: 0.2995550952242081d),
new NpgsqlTypes.NpgsqlLine(a: 0.5758522091715969d, b: 0.31362476765288083d, c: 0.5204363050388051d),
new NpgsqlTypes.NpgsqlLine(a: 0.521448957613329d, b: 0.18206684187036748d, c: 0.4116732245355763d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8811686232723762d, b: 0.19518390731204194d, c: 0.041653537632717175d),
new NpgsqlTypes.NpgsqlLine(a: 0.45674646146399833d, b: 0.2575510669807246d, c: 0.04047161846585223d),
new NpgsqlTypes.NpgsqlLine(a: 0.0686823337086383d, b: 0.47672460112128756d, c: 0.3738343512661969d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23041759682034246d, b: 0.1261943019057321d, c: 0.29789092101346504d),
new NpgsqlTypes.NpgsqlLine(a: 0.8157822249837849d, b: 0.6046010429571408d, c: 0.5025912963627183d),
new NpgsqlTypes.NpgsqlLine(a: 0.5794271168800454d, b: 0.3667225550174975d, c: 0.8407937698188694d),
new NpgsqlTypes.NpgsqlLine(a: 0.9015315842364756d, b: 0.6278285568917262d, c: 0.2647503958118005d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41583993822105547d, b: 0.9180127223721624d, c: 0.5593366127403074d),
new NpgsqlTypes.NpgsqlLine(a: 0.5224634657054839d, b: 0.09390478837746874d, c: 0.02071254026422964d),
new NpgsqlTypes.NpgsqlLine(a: 0.3903731185499725d, b: 0.06243097663288466d, c: 0.9586628546385592d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6801208868709956d, b: 0.8938963921342473d, c: 0.22389008251078923d),
new NpgsqlTypes.NpgsqlLine(a: 0.6563249135921915d, b: 0.6089862303032038d, c: 0.8747533236400132d),
new NpgsqlTypes.NpgsqlLine(a: 0.33812244174884254d, b: 0.18372253071298883d, c: 0.17233309855280365d),
new NpgsqlTypes.NpgsqlLine(a: 0.26615801645517356d, b: 0.8108138970639212d, c: 0.1009219311649111d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1992433173500603d, b: 0.6868785290593165d, c: 0.681749079802441d),
new NpgsqlTypes.NpgsqlLine(a: 0.16093164526584902d, b: 0.6535290642116445d, c: 0.2614172791263739d),
new NpgsqlTypes.NpgsqlLine(a: 0.13107092509417484d, b: 0.7889707144257181d, c: 0.3479652161451747d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9561844448233366d, b: 0.8631465471246446d, c: 0.20161156073625985d),
new NpgsqlTypes.NpgsqlLine(a: 0.002034688709133037d, b: 0.5567706747625901d, c: 0.24211707167304886d),
new NpgsqlTypes.NpgsqlLine(a: 0.7390019857410657d, b: 0.8792019219258983d, c: 0.09303922775209195d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3078823186748073d, b: 0.6290047902601428d, c: 0.720226791717368d),
new NpgsqlTypes.NpgsqlLine(a: 0.1094958207834813d, b: 0.08870001703482133d, c: 0.8509168215498448d),
new NpgsqlTypes.NpgsqlLine(a: 0.3392054759673243d, b: 0.0292630150943739d, c: 0.9716904569483059d),
new NpgsqlTypes.NpgsqlLine(a: 0.8357699593870674d, b: 0.65661093570936d, c: 0.8907962210835879d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8071709064271874d, b: 0.6728196050962478d, c: 0.7360102531510527d),
new NpgsqlTypes.NpgsqlLine(a: 0.21406512659607113d, b: 0.40525566772178756d, c: 0.26156225984972903d),
new NpgsqlTypes.NpgsqlLine(a: 0.9302091923398971d, b: 0.42672482340004403d, c: 0.15009648440568124d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10154385375277164d, b: 0.3373104156520972d, c: 0.025002631688984978d),
new NpgsqlTypes.NpgsqlLine(a: 0.9868215997096776d, b: 0.8177538344965288d, c: 0.7386768465978102d),
new NpgsqlTypes.NpgsqlLine(a: 0.3243679385935486d, b: 0.12920774857124917d, c: 0.371094400187826d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8078227028939111d, b: 0.01894412554662539d, c: 0.07489395112929098d),
new NpgsqlTypes.NpgsqlLine(a: 0.8654095653336163d, b: 0.1610660311095814d, c: 0.82285220375668d),
new NpgsqlTypes.NpgsqlLine(a: 0.11879314575545341d, b: 0.5128696015940111d, c: 0.7648280837968641d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8984907943767325d, b: 0.33098669174561823d, c: 0.7627400707958474d),
new NpgsqlTypes.NpgsqlLine(a: 0.5565429699508104d, b: 0.08420888011829208d, c: 0.050909829600265355d),
new NpgsqlTypes.NpgsqlLine(a: 0.21207302212411083d, b: 0.0905073034397571d, c: 0.004242469054507536d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29332171614093505d, b: 0.7098437856959356d, c: 0.9726658540893832d),
new NpgsqlTypes.NpgsqlLine(a: 0.633834584963842d, b: 0.43802400948204556d, c: 0.923025400307597d),
new NpgsqlTypes.NpgsqlLine(a: 0.2756956656698091d, b: 0.5900628185988891d, c: 0.24325618040546404d),
new NpgsqlTypes.NpgsqlLine(a: 0.954065324560334d, b: 0.4422699542205547d, c: 0.6844566812583863d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6624394061022673d, b: 0.2778247231196299d, c: 0.2740406263834616d),
new NpgsqlTypes.NpgsqlLine(a: 0.7987216926203822d, b: 0.565011220006863d, c: 0.4663552474210584d),
new NpgsqlTypes.NpgsqlLine(a: 0.15890274396638338d, b: 0.7773149726008014d, c: 0.7492925330906256d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6008708033230794d, b: 0.01300480767975598d, c: 0.18737553519974792d),
new NpgsqlTypes.NpgsqlLine(a: 0.7644375388018321d, b: 0.6278526616657121d, c: 0.27962585686267116d),
new NpgsqlTypes.NpgsqlLine(a: 0.42879018558534165d, b: 0.7821620082748384d, c: 0.46237457690147543d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6120651991944754d, b: 0.44944197450733636d, c: 0.9001257257532345d),
new NpgsqlTypes.NpgsqlLine(a: 0.6003916746138557d, b: 0.31048033346269877d, c: 0.6423393985543927d),
new NpgsqlTypes.NpgsqlLine(a: 0.7141107056973066d, b: 0.6417840938478953d, c: 0.8277784146804944d),
new NpgsqlTypes.NpgsqlLine(a: 0.3245312613198006d, b: 0.3682293423683568d, c: 0.7938206834346355d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9458695820138379d, b: 0.9738626636242503d, c: 0.1226633756213894d),
new NpgsqlTypes.NpgsqlLine(a: 0.28983841641308017d, b: 0.6329296757025658d, c: 0.8594820939778901d),
new NpgsqlTypes.NpgsqlLine(a: 0.724121273913132d, b: 0.7833997551499823d, c: 0.13715840498384047d),
new NpgsqlTypes.NpgsqlLine(a: 0.47946879615539506d, b: 0.5927543624860954d, c: 0.874070717696374d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 194,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.783254851970679d, b: 0.4757031452404049d, c: 0.9884368651203317d),
new NpgsqlTypes.NpgsqlLine(a: 0.7806931456081833d, b: 0.1510849813057361d, c: 0.5509376622503986d),
new NpgsqlTypes.NpgsqlLine(a: 0.13040517359492698d, b: 0.5753484839510317d, c: 0.6219701606709059d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.048856146479662854d, b: 0.803547613099521d, c: 0.8589557970488113d),
new NpgsqlTypes.NpgsqlLine(a: 0.34564387412696007d, b: 0.7468462368627442d, c: 0.4755488547438189d),
new NpgsqlTypes.NpgsqlLine(a: 0.3311442797693416d, b: 0.7461713768499976d, c: 0.20739364078397637d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6392509921565496d, b: 0.6232283020723228d, c: 0.05893721716116229d),
new NpgsqlTypes.NpgsqlLine(a: 0.5215750464025561d, b: 0.9829915171893324d, c: 0.050612295459507406d),
new NpgsqlTypes.NpgsqlLine(a: 0.08172029366285671d, b: 0.49466282014582086d, c: 0.7793318386396382d),
},
},
    NullableValue = null,
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
new NpgsqlTypes.NpgsqlLine(a: 0.7970421835903604d, b: 0.18980695124989455d, c: 0.3057898134695741d),
new NpgsqlTypes.NpgsqlLine(a: 0.7367407856596306d, b: 0.5648509389756254d, c: 0.3630939779857314d),
new NpgsqlTypes.NpgsqlLine(a: 0.5838135130109234d, b: 0.602057714814129d, c: 0.06068092486043797d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9075371454848437d, b: 0.0984757423411311d, c: 0.9382899421502773d),
new NpgsqlTypes.NpgsqlLine(a: 0.1441071913088129d, b: 0.3466198282231925d, c: 0.038275661711293596d),
new NpgsqlTypes.NpgsqlLine(a: 0.6771286647571236d, b: 0.06429298853723875d, c: 0.5296853282083368d),
new NpgsqlTypes.NpgsqlLine(a: 0.9509592162283911d, b: 0.4539116776188675d, c: 0.38888264995984834d),
}));
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
new NpgsqlTypes.NpgsqlLine(a: 0.5090523919349641d, b: 0.49111961545640825d, c: 0.8435601538219601d),
new NpgsqlTypes.NpgsqlLine(a: 0.04618615080456545d, b: 0.6263335798179375d, c: 0.4257304523496762d),
new NpgsqlTypes.NpgsqlLine(a: 0.2049424003824506d, b: 0.5323405159996317d, c: 0.08011809644443235d),
new NpgsqlTypes.NpgsqlLine(a: 0.29870718090563597d, b: 0.5034601348980555d, c: 0.6608896510481903d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.973609366780071d, b: 0.8854556667070943d, c: 0.6684932150349882d),
new NpgsqlTypes.NpgsqlLine(a: 0.8767980863739557d, b: 0.8699433929013615d, c: 0.024328247964115257d),
new NpgsqlTypes.NpgsqlLine(a: 0.050113985188831145d, b: 0.5541449628754899d, c: 0.2504419467345559d),
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
                Assert.That(nullable, Is.Null);
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
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

                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 140, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatchAsync(connection, 43, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
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
                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatch(connection, 149, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

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
                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

