

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.28430660337423885d,right: 0.28113184671358005d,bottom: 0.10212361832343175d,left: 0.26727324965761423d),

new NpgsqlTypes.NpgsqlBox(top: 0.4444207360942801d,right: 0.6414820062082852d,bottom: 0.40875330928642695d,left: 0.2022485766911225d),

new NpgsqlTypes.NpgsqlBox(top: 0.866811854914175d,right: 0.8371598455726492d,bottom: 0.24326540742137903d,left: 0.7017967233180237d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.23766040014696155d,right: 0.8690428223314379d,bottom: 0.02181033253542375d,left: 0.3306341546086601d),

new NpgsqlTypes.NpgsqlBox(top: 0.22942945516331592d,right: 0.38801576374976676d,bottom: 0.1434990783887432d,left: 0.10548644441764876d),

new NpgsqlTypes.NpgsqlBox(top: 0.2660387213396189d,right: 0.3035398158973056d,bottom: 0.011279508959422091d,left: 0.10247403684016321d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3622290825840635d,right: 0.5059706445282759d,bottom: 0.21827867300166603d,left: 0.48364770101370613d),

new NpgsqlTypes.NpgsqlBox(top: 0.6463714715774351d,right: 0.5292120483068546d,bottom: 0.3640524548648394d,left: 0.3103544000202829d),

new NpgsqlTypes.NpgsqlBox(top: 0.721733309487263d,right: 0.7071290974984878d,bottom: 0.13613725996312798d,left: 0.2259503879521675d),

new NpgsqlTypes.NpgsqlBox(top: 0.9963332234139818d,right: 0.3360056876613605d,bottom: 0.08727220452379414d,left: 0.04591020047285366d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6788415028777369d,right: 0.8300363523408486d,bottom: 0.3538573106803403d,left: 0.7697068539689012d),

new NpgsqlTypes.NpgsqlBox(top: 0.5231024120325484d,right: 0.7458756693645489d,bottom: 0.17244251413995193d,left: 0.3753394029388317d),

new NpgsqlTypes.NpgsqlBox(top: 0.9362013070163272d,right: 0.6185270628381787d,bottom: 0.6679605619213492d,left: 0.5349932828896962d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9845078144421396d,right: 0.8677705715405511d,bottom: 0.40984755939073714d,left: 0.5613942332683715d),

new NpgsqlTypes.NpgsqlBox(top: 0.5034682095767739d,right: 0.9075283260585078d,bottom: 0.47856499324966995d,left: 0.5951467769880551d),

new NpgsqlTypes.NpgsqlBox(top: 0.8961571000168737d,right: 0.26405932280797506d,bottom: 0.397911726317258d,left: 0.23041185961243538d),

new NpgsqlTypes.NpgsqlBox(top: 0.951744385386573d,right: 0.8966269814635168d,bottom: 0.25335571093614495d,left: 0.5068208538886597d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7858254463428457d,right: 0.5934920514794865d,bottom: 0.6576741492540242d,left: 0.38342957299629943d),

new NpgsqlTypes.NpgsqlBox(top: 0.8542874207097353d,right: 0.797212975664012d,bottom: 0.28562648549811587d,left: 0.5296807811608153d),

new NpgsqlTypes.NpgsqlBox(top: 0.9635094115531079d,right: 0.17920691112163045d,bottom: 0.23050478486599002d,left: 0.1498520791720992d),

new NpgsqlTypes.NpgsqlBox(top: 0.870580831043096d,right: 0.4189998227576759d,bottom: 0.4480182651212685d,left: 0.25307380266583657d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7933849888700851d,right: 0.8493024188390186d,bottom: 0.5957029990673847d,left: 0.3345191176081799d),

new NpgsqlTypes.NpgsqlBox(top: 0.6141418173106793d,right: 0.6747599893022506d,bottom: 0.6061849507184769d,left: 0.16626540969286507d),

new NpgsqlTypes.NpgsqlBox(top: 0.22556977433259895d,right: 0.9515273449820768d,bottom: 0.04099015913616877d,left: 0.42843081076030765d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4595395424325922d,right: 0.488628179733715d,bottom: 0.18945488775398422d,left: 0.0825320844540588d),

new NpgsqlTypes.NpgsqlBox(top: 0.9220195927309476d,right: 0.27361512222431894d,bottom: 0.5378402665957956d,left: 0.2118729452442396d),

new NpgsqlTypes.NpgsqlBox(top: 0.6768955738463847d,right: 0.819258317689595d,bottom: 0.5774290666712808d,left: 0.7244684981458408d),

new NpgsqlTypes.NpgsqlBox(top: 0.7362830983862083d,right: 0.6241108703025464d,bottom: 0.1271960107699548d,left: 0.19750151323918053d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.935125306711976d,right: 0.5630775485119592d,bottom: 0.8830860330407663d,left: 0.18812765826435096d),

new NpgsqlTypes.NpgsqlBox(top: 0.597598876160215d,right: 0.9410790301330842d,bottom: 0.26442328956612715d,left: 0.7868244751356963d),

new NpgsqlTypes.NpgsqlBox(top: 0.9342759893359223d,right: 0.42343014050519534d,bottom: 0.18443856533058944d,left: 0.04082164847089198d),

new NpgsqlTypes.NpgsqlBox(top: 0.8904453905525348d,right: 0.6090984165478721d,bottom: 0.7656513489619841d,left: 0.37738723232925764d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.28008530595497894d,right: 0.513544836778648d,bottom: 0.02010251754515846d,left: 0.5079857247086231d),

new NpgsqlTypes.NpgsqlBox(top: 0.7858858934277155d,right: 0.6745857137443566d,bottom: 0.7002640341566161d,left: 0.20164554913152533d),

new NpgsqlTypes.NpgsqlBox(top: 0.5687039659071298d,right: 0.9395808925565244d,bottom: 0.3802392508301844d,left: 0.39118862115368347d),

new NpgsqlTypes.NpgsqlBox(top: 0.5314852783118719d,right: 0.8281442405120264d,bottom: 0.36487261741701826d,left: 0.33721415878997385d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3959402663394782d,right: 0.2550303579116775d,bottom: 0.1955552896674152d,left: 0.20856388786815738d),

new NpgsqlTypes.NpgsqlBox(top: 0.9858212566815794d,right: 0.19876598716410765d,bottom: 0.06805272243830585d,left: 0.028210779059268165d),

new NpgsqlTypes.NpgsqlBox(top: 0.9975157452904605d,right: 0.13786789070362238d,bottom: 0.2097267659103872d,left: 0.06712256939822647d),

new NpgsqlTypes.NpgsqlBox(top: 0.5406036212924255d,right: 0.8336353049235881d,bottom: 0.03435666699960127d,left: 0.16697446274753602d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9769647414935243d,right: 0.9287627579967046d,bottom: 0.6554665180625802d,left: 0.4930393095234453d),

new NpgsqlTypes.NpgsqlBox(top: 0.32640168961745175d,right: 0.6476181272366717d,bottom: 0.21306885459035396d,left: 0.6443398125348674d),

new NpgsqlTypes.NpgsqlBox(top: 0.8985670158488775d,right: 0.9050006088423324d,bottom: 0.6055301643232568d,left: 0.6989080034901145d),

new NpgsqlTypes.NpgsqlBox(top: 0.8421145060943516d,right: 0.908863453210822d,bottom: 0.14720112868070423d,left: 0.11667179823034313d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7701219627716192d,right: 0.8225411064424987d,bottom: 0.1474089077799663d,left: 0.534623844640866d),

new NpgsqlTypes.NpgsqlBox(top: 0.7441745325993702d,right: 0.5621350020880244d,bottom: 0.43184143093659955d,left: 0.35830131229611073d),

new NpgsqlTypes.NpgsqlBox(top: 0.3031469467454182d,right: 0.9026044915036929d,bottom: 0.23701367916726246d,left: 0.20067728476333524d),

new NpgsqlTypes.NpgsqlBox(top: 0.6470907205892393d,right: 0.7583814463589204d,bottom: 0.09756996118022832d,left: 0.2523438372585213d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9639837602868732d,right: 0.9330498523228045d,bottom: 0.5081055202828152d,left: 0.14311900516434573d),

new NpgsqlTypes.NpgsqlBox(top: 0.5867758295150763d,right: 0.8103079150620487d,bottom: 0.22324148799277455d,left: 0.7568004764322247d),

new NpgsqlTypes.NpgsqlBox(top: 0.8482259613815243d,right: 0.9871451458644765d,bottom: 0.14666993186689237d,left: 0.6450949735281416d),

new NpgsqlTypes.NpgsqlBox(top: 0.5094136856394383d,right: 0.6133900740288031d,bottom: 0.39510381050552124d,left: 0.2613778491506722d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.535235114739901d,right: 0.4493793982812617d,bottom: 0.29692942410886713d,left: 0.32649259868830005d),

new NpgsqlTypes.NpgsqlBox(top: 0.8725776897581933d,right: 0.1064445423846d,bottom: 0.3176819249235786d,left: 0.03987826561297847d),

new NpgsqlTypes.NpgsqlBox(top: 0.5011230102265329d,right: 0.7762276769280453d,bottom: 0.007727949300202153d,left: 0.14454044612142702d),

new NpgsqlTypes.NpgsqlBox(top: 0.4294470058311334d,right: 0.2344470753643031d,bottom: 0.27220942483392263d,left: 0.18346251791347568d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9642160582942501d,right: 0.9697239179306235d,bottom: 0.0017919479413964767d,left: 0.05316891825202885d),

new NpgsqlTypes.NpgsqlBox(top: 0.8022864518802948d,right: 0.3189798257258515d,bottom: 0.36401981759294155d,left: 0.3161728837323968d),

new NpgsqlTypes.NpgsqlBox(top: 0.8846331775154758d,right: 0.20526437982773715d,bottom: 0.19134054592940075d,left: 0.1056381757020628d),

new NpgsqlTypes.NpgsqlBox(top: 0.8010636866977384d,right: 0.654954627072473d,bottom: 0.6065105160051075d,left: 0.34458627984212986d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.915548319751899d,right: 0.6733601914677908d,bottom: 0.3791028463810272d,left: 0.5655893048628576d),

new NpgsqlTypes.NpgsqlBox(top: 0.6116825576976781d,right: 0.5155018884331362d,bottom: 0.421278271123102d,left: 0.015538368492111987d),

new NpgsqlTypes.NpgsqlBox(top: 0.6331436450759002d,right: 0.21178522545496214d,bottom: 0.1677919357168971d,left: 0.20049225329492937d),

new NpgsqlTypes.NpgsqlBox(top: 0.6940939288162864d,right: 0.6124814694974123d,bottom: 0.2854064658950908d,left: 0.40370761637570407d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8772326342778762d,right: 0.4565663231861148d,bottom: 0.6800857622760991d,left: 0.2778863757833089d),

new NpgsqlTypes.NpgsqlBox(top: 0.8128277986351269d,right: 0.5951215657561377d,bottom: 0.1338529518386692d,left: 0.33278690792041943d),

new NpgsqlTypes.NpgsqlBox(top: 0.7654615587688857d,right: 0.913962400960179d,bottom: 0.3340039223415706d,left: 0.42694213898769284d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9124404751509843d,right: 0.5192386478214854d,bottom: 0.10800569455124931d,left: 0.1831314764762848d),

new NpgsqlTypes.NpgsqlBox(top: 0.5207449691628657d,right: 0.6518546692235451d,bottom: 0.4177635881652474d,left: 0.4093476621386336d),

new NpgsqlTypes.NpgsqlBox(top: 0.7115192168283978d,right: 0.8945938348957835d,bottom: 0.16992832913050582d,left: 0.5116812352425868d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5783394039575813d,right: 0.5725807829605986d,bottom: 0.18822590625142344d,left: 0.43462420258501155d),

new NpgsqlTypes.NpgsqlBox(top: 0.600084558260737d,right: 0.8333198331116639d,bottom: 0.5987895737375609d,left: 0.3752013340292497d),

new NpgsqlTypes.NpgsqlBox(top: 0.741225843824253d,right: 0.8708614148266988d,bottom: 0.04292996522935599d,left: 0.601423385841456d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7702221282628868d,right: 0.977782740515228d,bottom: 0.020873812208687226d,left: 0.6295759802251928d),

new NpgsqlTypes.NpgsqlBox(top: 0.6790761531456907d,right: 0.45474610979190755d,bottom: 0.1670709710848709d,left: 0.32456809609272486d),

new NpgsqlTypes.NpgsqlBox(top: 0.1899399387385472d,right: 0.8040180827392999d,bottom: 0.150072079335271d,left: 0.2645034963752644d),

new NpgsqlTypes.NpgsqlBox(top: 0.41621684322461705d,right: 0.9330539911306999d,bottom: 0.3398650832592467d,left: 0.3228435865006203d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.30960332677176394d,right: 0.9749480779620293d,bottom: 0.04520561291801284d,left: 0.8479892296596879d),

new NpgsqlTypes.NpgsqlBox(top: 0.8876018547012178d,right: 0.27533960066523333d,bottom: 0.47684027264211315d,left: 0.04943714417505296d),

new NpgsqlTypes.NpgsqlBox(top: 0.13708527746556032d,right: 0.6851840176832314d,bottom: 3.140514676769346E-05d,left: 0.29654927129439224d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.38356737005470976d,right: 0.5109404044581274d,bottom: 0.20379505436808787d,left: 0.16677840295171242d),

new NpgsqlTypes.NpgsqlBox(top: 0.5568016915101899d,right: 0.6824550449983474d,bottom: 0.321931981268464d,left: 0.21405048003144866d),

new NpgsqlTypes.NpgsqlBox(top: 0.9790061728917314d,right: 0.4196173097391528d,bottom: 0.096903459960761d,left: 0.07840253537859931d),

new NpgsqlTypes.NpgsqlBox(top: 0.7231616749132784d,right: 0.8856539464281821d,bottom: 0.3157594753906695d,left: 0.19168666471398288d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9990516474873329d,right: 0.5078213549212081d,bottom: 0.6872629608596521d,left: 0.3272361746371778d),

new NpgsqlTypes.NpgsqlBox(top: 0.6155445943512021d,right: 0.14829752877023772d,bottom: 0.2041976241777238d,left: 0.10271321841056269d),

new NpgsqlTypes.NpgsqlBox(top: 0.8640755508091511d,right: 0.8499335974777293d,bottom: 0.27154602512203774d,left: 0.4808951201425148d),

new NpgsqlTypes.NpgsqlBox(top: 0.8727613082432817d,right: 0.8692642062108812d,bottom: 0.7247768055429408d,left: 0.27204224304033386d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1592669586978277d,right: 0.8930360393563912d,bottom: 0.04719377868451835d,left: 0.8541080585396055d),

new NpgsqlTypes.NpgsqlBox(top: 0.7661055127054099d,right: 0.7844432433739094d,bottom: 0.4054836924785238d,left: 0.017913203729204463d),

new NpgsqlTypes.NpgsqlBox(top: 0.2650206452079439d,right: 0.7621349626948954d,bottom: 0.15779760745587612d,left: 0.7372798463392366d),

new NpgsqlTypes.NpgsqlBox(top: 0.7758268019551146d,right: 0.6166282663477527d,bottom: 0.30895562373742513d,left: 0.4955316586782351d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9124278089820543d,right: 0.3868966575012084d,bottom: 0.5466418582335364d,left: 0.3525369304310456d),

new NpgsqlTypes.NpgsqlBox(top: 0.9432420289340758d,right: 0.6203724503696069d,bottom: 0.050730730186943296d,left: 0.3895174422190516d),

new NpgsqlTypes.NpgsqlBox(top: 0.745976317682712d,right: 0.20080101790975124d,bottom: 0.26499297763903584d,left: 0.04175895152557163d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6957472773641268d,right: 0.9923806240771916d,bottom: 0.25208016940801137d,left: 0.9770677473583262d),

new NpgsqlTypes.NpgsqlBox(top: 0.7725062859972112d,right: 0.25294147435165926d,bottom: 0.5487381347010638d,left: 0.19467131171827234d),

new NpgsqlTypes.NpgsqlBox(top: 0.47674819707084914d,right: 0.4730512347800836d,bottom: 0.4114049660066714d,left: 0.4679469943155997d),

new NpgsqlTypes.NpgsqlBox(top: 0.6988276682277605d,right: 0.4448093581695248d,bottom: 0.03582412398878809d,left: 0.05040670963999838d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4747497923749704d,right: 0.6886580800280516d,bottom: 0.22775241973556537d,left: 0.5326441050560958d),

new NpgsqlTypes.NpgsqlBox(top: 0.5433656362192594d,right: 0.8360814066369503d,bottom: 0.30216419220949386d,left: 0.6940200931826115d),

new NpgsqlTypes.NpgsqlBox(top: 0.39969275559341266d,right: 0.9491582441072886d,bottom: 0.15037350721105347d,left: 0.1553159885092481d),

new NpgsqlTypes.NpgsqlBox(top: 0.26478951483909385d,right: 0.34642106548578966d,bottom: 0.25649185492253945d,left: 0.1576962200769031d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7883480242032688d,right: 0.8418141542734452d,bottom: 0.040229189375595054d,left: 0.5468509538740521d),

new NpgsqlTypes.NpgsqlBox(top: 0.5874112975615272d,right: 0.6103787122100678d,bottom: 0.5751552778598562d,left: 0.20293861423810255d),

new NpgsqlTypes.NpgsqlBox(top: 0.52771018431136d,right: 0.8943965355239599d,bottom: 0.23036058650713442d,left: 0.30670160712440186d),

new NpgsqlTypes.NpgsqlBox(top: 0.4127244696978062d,right: 0.7530333252752128d,bottom: 0.3462125632616445d,left: 0.08847749323190501d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.713557005903369d,right: 0.773853867863204d,bottom: 0.2320556265113134d,left: 0.6459060745663066d),

new NpgsqlTypes.NpgsqlBox(top: 0.991798979258924d,right: 0.9855088084335634d,bottom: 0.6536046322850587d,left: 0.1029465541083946d),

new NpgsqlTypes.NpgsqlBox(top: 0.5836437779865272d,right: 0.517862619757621d,bottom: 0.09746939931518783d,left: 0.3874545376586773d),

new NpgsqlTypes.NpgsqlBox(top: 0.934111837196449d,right: 0.2261576670677693d,bottom: 0.6479329696598832d,left: 0.22505502519714538d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41906965608175994d,right: 0.7667940366066306d,bottom: 0.21123619562075857d,left: 0.5384660081981546d),

new NpgsqlTypes.NpgsqlBox(top: 0.8155692645221322d,right: 0.8612387187797708d,bottom: 0.3976915759754538d,left: 0.14446229116271425d),

new NpgsqlTypes.NpgsqlBox(top: 0.5725573299731435d,right: 0.9324097482165581d,bottom: 0.15523456746411424d,left: 0.5471699858358589d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8801640111352609d,right: 0.9298291964529386d,bottom: 0.33585611124065917d,left: 0.7868127719816767d),

new NpgsqlTypes.NpgsqlBox(top: 0.6977010849599767d,right: 0.2667280135473955d,bottom: 0.1096738123175468d,left: 0.14264631069775635d),

new NpgsqlTypes.NpgsqlBox(top: 0.4447892798924522d,right: 0.6755601825531171d,bottom: 0.15668920249474982d,left: 0.15150558897835043d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9295529447045718d,right: 0.6579508588953893d,bottom: 0.3963221952995074d,left: 0.20740919936590918d),

new NpgsqlTypes.NpgsqlBox(top: 0.7784535456411075d,right: 0.755212171601166d,bottom: 0.29126172344236967d,left: 0.19346171509109422d),

new NpgsqlTypes.NpgsqlBox(top: 0.9889568908920857d,right: 0.6101797360855454d,bottom: 0.8407272008006584d,left: 0.3244507984909226d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9304838457493042d,right: 0.2882139438459982d,bottom: 0.3866962219630118d,left: 0.05222191519498609d),

new NpgsqlTypes.NpgsqlBox(top: 0.6042416360043812d,right: 0.9022280469887205d,bottom: 0.5289453488675592d,left: 0.0822511818628302d),

new NpgsqlTypes.NpgsqlBox(top: 0.5846615920416958d,right: 0.377140224471476d,bottom: 0.4702838968277575d,left: 0.018583172649030866d),

new NpgsqlTypes.NpgsqlBox(top: 0.885967039195633d,right: 0.9269312595083238d,bottom: 0.6858809037618109d,left: 0.4682685686704997d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3678382850317865d,right: 0.8940449639453225d,bottom: 0.20568185644911618d,left: 0.1025028136247016d),

new NpgsqlTypes.NpgsqlBox(top: 0.914468389740295d,right: 0.9705555409497519d,bottom: 0.15559953477006372d,left: 0.11032267877157709d),

new NpgsqlTypes.NpgsqlBox(top: 0.9569659192160687d,right: 0.28554739064192713d,bottom: 0.13546219833378592d,left: 0.06453768960667594d),

new NpgsqlTypes.NpgsqlBox(top: 0.4846431521611364d,right: 0.8033361501145183d,bottom: 0.39776011064808503d,left: 0.2793538164816116d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32193010265573196d,right: 0.34237872095963484d,bottom: 0.2008941571709012d,left: 0.24913484390305907d),

new NpgsqlTypes.NpgsqlBox(top: 0.9659687983042347d,right: 0.26177819534379865d,bottom: 0.13714003987729873d,left: 0.24983721493685807d),

new NpgsqlTypes.NpgsqlBox(top: 0.8827953431837414d,right: 0.7840333264126835d,bottom: 0.7087465957939425d,left: 0.2118884367948879d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9367134762762312d,right: 0.7018529768144718d,bottom: 0.7331924872369395d,left: 0.050833205990664876d),

new NpgsqlTypes.NpgsqlBox(top: 0.7957015095434627d,right: 0.5573636046229d,bottom: 0.04919518489140806d,left: 0.3377238226868261d),

new NpgsqlTypes.NpgsqlBox(top: 0.8211740806383986d,right: 0.9807036975634306d,bottom: 0.31914698715263445d,left: 0.34644250364462736d),

new NpgsqlTypes.NpgsqlBox(top: 0.023094254790256064d,right: 0.47662358230561086d,bottom: 0.013938831915132122d,left: 0.0649089326266502d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5943660189321873d,right: 0.7329304485837891d,bottom: 0.4053116131326252d,left: 0.521020740190415d),

new NpgsqlTypes.NpgsqlBox(top: 0.5195899418857439d,right: 0.9733220266833148d,bottom: 0.3007638859015408d,left: 0.8511884362328085d),

new NpgsqlTypes.NpgsqlBox(top: 0.36283922030261195d,right: 0.6559161954122443d,bottom: 0.21657628092085157d,left: 0.07869562777337291d),

new NpgsqlTypes.NpgsqlBox(top: 0.9672682189361971d,right: 0.8301709230607093d,bottom: 0.5622827522254157d,left: 0.29065262765910704d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9638476498447753d,right: 0.7220897651085041d,bottom: 0.20293956106659872d,left: 0.25090808349525473d),

new NpgsqlTypes.NpgsqlBox(top: 0.8025716932601816d,right: 0.9228931083481249d,bottom: 0.2513394979188257d,left: 0.4396486761083218d),

new NpgsqlTypes.NpgsqlBox(top: 0.4590483221156014d,right: 0.5009764195927483d,bottom: 0.3917588012142116d,left: 0.2918732268264139d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7383124013975733d,right: 0.9653314312335818d,bottom: 0.2564684264479067d,left: 0.2908824590962664d),

new NpgsqlTypes.NpgsqlBox(top: 0.4511634900305058d,right: 0.5481016160440536d,bottom: 0.26807727582480045d,left: 0.09967313213227325d),

new NpgsqlTypes.NpgsqlBox(top: 0.9454431476864141d,right: 0.7936101186237478d,bottom: 0.28668277003632103d,left: 0.7872479018307481d),

new NpgsqlTypes.NpgsqlBox(top: 0.6114262691545307d,right: 0.5020710430419791d,bottom: 0.27936370250444686d,left: 0.024617597951607118d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4716486420148285d,right: 0.49140714815182607d,bottom: 0.2764102341583703d,left: 0.13857665047463308d),

new NpgsqlTypes.NpgsqlBox(top: 0.8429782960146099d,right: 0.6682459189789459d,bottom: 0.08534110895201119d,left: 0.40203170951652856d),

new NpgsqlTypes.NpgsqlBox(top: 0.7222615662296369d,right: 0.5760901751141824d,bottom: 0.5390663971431406d,left: 0.36568790396477424d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5383295460663804d,right: 0.8510029896775495d,bottom: 0.32514233584286967d,left: 0.011706258103684197d),

new NpgsqlTypes.NpgsqlBox(top: 0.919063948616284d,right: 0.5306951519563714d,bottom: 0.4116467378948423d,left: 0.0144204476948665d),

new NpgsqlTypes.NpgsqlBox(top: 0.7037154848037418d,right: 0.6838914750383311d,bottom: 0.12316194966552585d,left: 0.27112131662940864d),

new NpgsqlTypes.NpgsqlBox(top: 0.8235629314855134d,right: 0.968602661635847d,bottom: 0.3698295904055403d,left: 0.7656803980789196d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6083662419936129d,right: 0.8654277889638362d,bottom: 0.18532594210660824d,left: 0.48666024554032916d),

new NpgsqlTypes.NpgsqlBox(top: 0.8792596073120091d,right: 0.9241953117601055d,bottom: 0.1720956687050802d,left: 0.572480008602149d),

new NpgsqlTypes.NpgsqlBox(top: 0.8870479806788076d,right: 0.9368417041877982d,bottom: 0.2329098309835449d,left: 0.6019122878931102d),

new NpgsqlTypes.NpgsqlBox(top: 0.4108187610252614d,right: 0.4784711667034187d,bottom: 0.14213309227766202d,left: 0.16946911542405896d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25764438036361925d,right: 0.40478403440381816d,bottom: 0.205443298106197d,left: 0.2308987490509531d),

new NpgsqlTypes.NpgsqlBox(top: 0.476187915402689d,right: 0.5075574631844245d,bottom: 0.32172403478020783d,left: 0.009643984967806718d),

new NpgsqlTypes.NpgsqlBox(top: 0.3430021694422558d,right: 0.8713984064470034d,bottom: 0.12143822609049082d,left: 0.6426686558781365d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9416973102389945d,right: 0.8506907609095422d,bottom: 0.1587551168073541d,left: 0.23970435464505047d),

new NpgsqlTypes.NpgsqlBox(top: 0.3117420354042647d,right: 0.9609235896192772d,bottom: 0.16376978474768134d,left: 0.6992141989908736d),

new NpgsqlTypes.NpgsqlBox(top: 0.3834569016259808d,right: 0.8150683704567135d,bottom: 0.2960097170707443d,left: 0.24543127768215267d),

new NpgsqlTypes.NpgsqlBox(top: 0.3488561874774059d,right: 0.5250773794383476d,bottom: 0.2760058307463549d,left: 0.0721675090205367d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4327518844825723d,right: 0.4079878897464878d,bottom: 0.37476516690041817d,left: 0.3385967349048363d),

new NpgsqlTypes.NpgsqlBox(top: 0.6288131792097121d,right: 0.9694303806114984d,bottom: 0.3921307504183307d,left: 0.49860966644929516d),

new NpgsqlTypes.NpgsqlBox(top: 0.7781891493219106d,right: 0.7338298189561294d,bottom: 0.7091122610876667d,left: 0.5883597623899538d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8696943033876595d,right: 0.11850114519966237d,bottom: 0.14756752618990665d,left: 0.01488181249525855d),

new NpgsqlTypes.NpgsqlBox(top: 0.6807927450511835d,right: 0.6679118265796561d,bottom: 0.06933826108736174d,left: 0.05815300914873667d),

new NpgsqlTypes.NpgsqlBox(top: 0.04651965118085066d,right: 0.739953027004708d,bottom: 0.024338422204148613d,left: 0.5600569847675473d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6330807123021779d,right: 0.8901211798229949d,bottom: 0.25099457002564296d,left: 0.305322275950929d),

new NpgsqlTypes.NpgsqlBox(top: 0.404222415252227d,right: 0.4270284560547182d,bottom: 0.13416540027410484d,left: 0.3079150734793119d),

new NpgsqlTypes.NpgsqlBox(top: 0.483376511113082d,right: 0.5429005892395236d,bottom: 0.2722145717558251d,left: 0.4351175608436554d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9204586476346561d,right: 0.43438277711238205d,bottom: 0.5690679512814645d,left: 0.1253296568574408d),

new NpgsqlTypes.NpgsqlBox(top: 0.3009118418568205d,right: 0.8808537899834222d,bottom: 0.16772431133720078d,left: 0.8545341118942857d),

new NpgsqlTypes.NpgsqlBox(top: 0.7352860100428829d,right: 0.6410301083563541d,bottom: 0.32647125147428335d,left: 0.3532598700125674d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5331487364067905d,right: 0.9269353136689872d,bottom: 0.22390099303615407d,left: 0.5377836712738362d),

new NpgsqlTypes.NpgsqlBox(top: 0.8556537201798388d,right: 0.34746703831848325d,bottom: 0.40452576227241843d,left: 0.2579258749149761d),

new NpgsqlTypes.NpgsqlBox(top: 0.8513648792435683d,right: 0.7530567175080051d,bottom: 0.4736315507366349d,left: 0.5460282717872585d),

new NpgsqlTypes.NpgsqlBox(top: 0.8023052300101908d,right: 0.8490715535044638d,bottom: 0.6091962745522341d,left: 0.7181043360299292d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9375015420577287d,right: 0.8957085546629818d,bottom: 0.47990608810423296d,left: 0.41333630131441057d),

new NpgsqlTypes.NpgsqlBox(top: 0.8927865375284889d,right: 0.920148784946374d,bottom: 0.3840800416049315d,left: 0.6513838366523467d),

new NpgsqlTypes.NpgsqlBox(top: 0.5276233030606687d,right: 0.8269166718381271d,bottom: 0.33329664307475115d,left: 0.37624569250524786d),

new NpgsqlTypes.NpgsqlBox(top: 0.7558048888980599d,right: 0.43430444425724224d,bottom: 0.4365121952566804d,left: 0.27077438666166276d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7120262492682706d,right: 0.5860127076148494d,bottom: 0.32012032095647514d,left: 0.20711492231838857d),

new NpgsqlTypes.NpgsqlBox(top: 0.6706216178278315d,right: 0.9878649180487081d,bottom: 0.2026715706919161d,left: 0.9456219011548486d),

new NpgsqlTypes.NpgsqlBox(top: 0.8773883864309465d,right: 0.7163508278261301d,bottom: 0.8611012787687308d,left: 0.699311257510222d),

new NpgsqlTypes.NpgsqlBox(top: 0.9667070522465687d,right: 0.5417359741699757d,bottom: 0.9363096169939517d,left: 0.4838051985015831d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6279716436602195d,right: 0.7653781705920383d,bottom: 0.3943392523879159d,left: 0.3540393502584457d),

new NpgsqlTypes.NpgsqlBox(top: 0.7710266126640567d,right: 0.8675841674012525d,bottom: 0.2208573412922339d,left: 0.6940444137195033d),

new NpgsqlTypes.NpgsqlBox(top: 0.8288352875766699d,right: 0.6995275442282507d,bottom: 0.194462107982885d,left: 0.37410683762801533d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6870383694940773d,right: 0.6141656946807665d,bottom: 0.6024581660297461d,left: 0.34619067395499226d),

new NpgsqlTypes.NpgsqlBox(top: 0.9719627407122381d,right: 0.8699136823468283d,bottom: 0.011576159851856893d,left: 0.3888493908040206d),

new NpgsqlTypes.NpgsqlBox(top: 0.5383091391404438d,right: 0.9599460773713939d,bottom: 0.14629021466548575d,left: 0.750514878571878d),

new NpgsqlTypes.NpgsqlBox(top: 0.5117768878697d,right: 0.28456420175896746d,bottom: 0.008053364249422712d,left: 0.014710625886707573d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6137082517137961d,right: 0.8259021501971817d,bottom: 0.36000675184210706d,left: 0.5546673987952528d),

new NpgsqlTypes.NpgsqlBox(top: 0.7656777613351508d,right: 0.18529828322359032d,bottom: 0.4761617458014712d,left: 0.17378171182989377d),

new NpgsqlTypes.NpgsqlBox(top: 0.7878825117377248d,right: 0.7521341966350336d,bottom: 0.13490611566128763d,left: 0.17578586271711882d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.719803518929144d,right: 0.06581690949064667d,bottom: 0.5929280646996034d,left: 0.039541319067885605d),

new NpgsqlTypes.NpgsqlBox(top: 0.9241832623637644d,right: 0.9466818649786456d,bottom: 0.7388529714246909d,left: 0.2302022191412405d),

new NpgsqlTypes.NpgsqlBox(top: 0.982846331702825d,right: 0.31584119317328574d,bottom: 0.9621927918903218d,left: 0.20263559314659574d),

new NpgsqlTypes.NpgsqlBox(top: 0.4970322686790162d,right: 0.8273207428647936d,bottom: 0.32049516505007336d,left: 0.5753852906864696d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4594271046544348d,right: 0.9008057734267257d,bottom: 0.2707492925117523d,left: 0.2247247928174695d),

new NpgsqlTypes.NpgsqlBox(top: 0.5385993801336698d,right: 0.3921566320959847d,bottom: 0.0415880507151698d,left: 0.3011832677476881d),

new NpgsqlTypes.NpgsqlBox(top: 0.9579528938487889d,right: 0.7409226894259704d,bottom: 0.6044785804611529d,left: 0.474229474343835d),

new NpgsqlTypes.NpgsqlBox(top: 0.5972628919913229d,right: 0.3093618122944315d,bottom: 0.2634846445472283d,left: 0.03865951850256055d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9798102502855272d,right: 0.6462415308101731d,bottom: 0.5312612707625992d,left: 0.16645936089063595d),

new NpgsqlTypes.NpgsqlBox(top: 0.5203472334444386d,right: 0.8358219999659579d,bottom: 0.47650801722502645d,left: 0.1224222323789721d),

new NpgsqlTypes.NpgsqlBox(top: 0.8907895488757284d,right: 0.7351565024247965d,bottom: 0.17017626600801072d,left: 0.7141734042762306d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.519106638450225d,right: 0.6078801172543365d,bottom: 0.2520825633492889d,left: 0.5336354348909026d),

new NpgsqlTypes.NpgsqlBox(top: 0.5799621694784031d,right: 0.8451703902738358d,bottom: 0.5572954658918428d,left: 0.7042581391559547d),

new NpgsqlTypes.NpgsqlBox(top: 0.8216299365413509d,right: 0.3326098854504893d,bottom: 0.8054697789307627d,left: 0.07307812706720229d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7006351700048843d,right: 0.30828571528803483d,bottom: 0.15956771248712776d,left: 0.1741692119675845d),

new NpgsqlTypes.NpgsqlBox(top: 0.9263840371935541d,right: 0.8796498938140279d,bottom: 0.7975286420834568d,left: 0.5892267175978696d),

new NpgsqlTypes.NpgsqlBox(top: 0.9500481892967413d,right: 0.19984842309842388d,bottom: 0.7678707552921922d,left: 0.14799513631547379d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.097000277566335d,right: 0.8232711831514523d,bottom: 0.09092878795368742d,left: 0.22318964515507622d),

new NpgsqlTypes.NpgsqlBox(top: 0.12842626440919735d,right: 0.7780321100530281d,bottom: 0.12558561421201098d,left: 0.4621395635540496d),

new NpgsqlTypes.NpgsqlBox(top: 0.5525301056169928d,right: 0.8949240304195525d,bottom: 0.2753831239171576d,left: 0.8825038569134693d),

new NpgsqlTypes.NpgsqlBox(top: 0.8148908606788362d,right: 0.8847293767990634d,bottom: 0.7149105169471424d,left: 0.3084948942299335d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.818785488233562d,right: 0.907960678740842d,bottom: 0.5944635766287243d,left: 0.562512922764041d),

new NpgsqlTypes.NpgsqlBox(top: 0.8145232925811051d,right: 0.9691217163351862d,bottom: 0.2363241779517904d,left: 0.7755419430886732d),

new NpgsqlTypes.NpgsqlBox(top: 0.650695721725796d,right: 0.7371764638523921d,bottom: 0.26487572531722103d,left: 0.2138743913097222d),

new NpgsqlTypes.NpgsqlBox(top: 0.7735826388673996d,right: 0.6141245725804154d,bottom: 0.6980863986117635d,left: 0.5834702005427075d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5709421595469253d,right: 0.7045072622527676d,bottom: 0.06878500171028024d,left: 0.6900446685695216d),

new NpgsqlTypes.NpgsqlBox(top: 0.8655964395163076d,right: 0.678001307295018d,bottom: 0.10725716260752871d,left: 0.5885361935023039d),

new NpgsqlTypes.NpgsqlBox(top: 0.7793465364892647d,right: 0.877196858269952d,bottom: 0.56782281453894d,left: 0.4935545281090996d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5431257477334736d,right: 0.8152609833557071d,bottom: 0.2780571350823313d,left: 0.1653594784831458d),

new NpgsqlTypes.NpgsqlBox(top: 0.2863806827968961d,right: 0.9411565286491139d,bottom: 0.050286981841037304d,left: 0.625390102746542d),

new NpgsqlTypes.NpgsqlBox(top: 0.6372464756373942d,right: 0.5608431475060542d,bottom: 0.34404182786614823d,left: 0.5220891602323343d),

new NpgsqlTypes.NpgsqlBox(top: 0.9479824585813866d,right: 0.5342749219332339d,bottom: 0.04300383967193133d,left: 0.4640839779659759d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.939828555925818d,right: 0.5124717241189914d,bottom: 0.6822009564907399d,left: 0.21267840724156484d),

new NpgsqlTypes.NpgsqlBox(top: 0.6149222753076764d,right: 0.5965486222169514d,bottom: 0.17410296764573585d,left: 0.336268501234133d),

new NpgsqlTypes.NpgsqlBox(top: 0.9938226772697928d,right: 0.6489228948033152d,bottom: 0.7632389280835826d,left: 0.037306875027663944d),

new NpgsqlTypes.NpgsqlBox(top: 0.2561252808950544d,right: 0.7672185206748429d,bottom: 0.012998638003076546d,left: 0.2871632110522996d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7575746506002936d,right: 0.7263472994373029d,bottom: 0.44563262306783313d,left: 0.350562591519449d),

new NpgsqlTypes.NpgsqlBox(top: 0.9005138205307802d,right: 0.8111893697055197d,bottom: 0.8718968534677619d,left: 0.21308886359548218d),

new NpgsqlTypes.NpgsqlBox(top: 0.46940588312605247d,right: 0.9415049035433061d,bottom: 0.1410418918019416d,left: 0.6596909397092108d),

new NpgsqlTypes.NpgsqlBox(top: 0.48243977542033467d,right: 0.5064124419129623d,bottom: 0.42028541010010334d,left: 0.22136607302231626d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4641806932974577d,right: 0.9541171512540352d,bottom: 0.3836247666636474d,left: 0.31811579970758297d),

new NpgsqlTypes.NpgsqlBox(top: 0.7543105993159288d,right: 0.3736408600195691d,bottom: 0.15946836571616507d,left: 0.12433884998874256d),

new NpgsqlTypes.NpgsqlBox(top: 0.7268122863448561d,right: 0.6322666387791346d,bottom: 0.6086858464846251d,left: 0.253562488940683d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8011421288105993d,right: 0.5939116273191586d,bottom: 0.37307409685498516d,left: 0.37864718225942595d),

new NpgsqlTypes.NpgsqlBox(top: 0.8005865345006085d,right: 0.9610459586270335d,bottom: 0.39652485741723187d,left: 0.5936154493131536d),

new NpgsqlTypes.NpgsqlBox(top: 0.6392197813003289d,right: 0.38161023525391824d,bottom: 0.22071811586268597d,left: 0.32051303022882693d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1644042509392717d,right: 0.8645863601070589d,bottom: 0.01849424588976256d,left: 0.6944846795228213d),

new NpgsqlTypes.NpgsqlBox(top: 0.9437394278354241d,right: 0.6156913330992952d,bottom: 0.8498214821922558d,left: 0.5290425518608033d),

new NpgsqlTypes.NpgsqlBox(top: 0.9574866740634164d,right: 0.4640086515589319d,bottom: 0.225797918271046d,left: 0.17727331121134782d),

new NpgsqlTypes.NpgsqlBox(top: 0.5337938181229542d,right: 0.6512543923216796d,bottom: 0.05229092681332892d,left: 0.44651006033769813d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8299628639374413d,right: 0.21867661813736106d,bottom: 0.22924026220604055d,left: 0.14838269780317992d),

new NpgsqlTypes.NpgsqlBox(top: 0.5119189272476432d,right: 0.916823960404864d,bottom: 0.40765747595552293d,left: 0.48213966537048236d),

new NpgsqlTypes.NpgsqlBox(top: 0.8122665506600395d,right: 0.8182316959249455d,bottom: 0.3196650695205331d,left: 0.3323349282381537d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 121, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 117, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 31, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 30, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 48, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 58, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 58, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 143);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

