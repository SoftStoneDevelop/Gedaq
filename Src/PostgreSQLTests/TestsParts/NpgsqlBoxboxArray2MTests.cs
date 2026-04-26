

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9811360610849141d,right: 0.9293422555024309d,bottom: 0.051269426068808355d,left: 0.3882029613990793d),

new NpgsqlTypes.NpgsqlBox(top: 0.30221729532196706d,right: 0.8287471321485086d,bottom: 0.04845067184017948d,left: 0.41004376833338485d),

new NpgsqlTypes.NpgsqlBox(top: 0.6926797269272572d,right: 0.5980931537277234d,bottom: 0.3020023523035822d,left: 0.1309993748829481d),

new NpgsqlTypes.NpgsqlBox(top: 0.06341936999589659d,right: 0.41221367816077537d,bottom: 0.019388598512600885d,left: 0.13253403452687118d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6040991961437454d,right: 0.6540446561527542d,bottom: 0.46374448081794106d,left: 0.6017855682864307d),

new NpgsqlTypes.NpgsqlBox(top: 0.7532305152739102d,right: 0.12514605754998687d,bottom: 0.5164601199566997d,left: 0.01451436755259572d),

new NpgsqlTypes.NpgsqlBox(top: 0.972683938319551d,right: 0.7292457177738824d,bottom: 0.331385522250094d,left: 0.02686914779823313d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7068678774910037d,right: 0.9849184420396742d,bottom: 0.6403223503055114d,left: 0.917149158806883d),

new NpgsqlTypes.NpgsqlBox(top: 0.8631998198117362d,right: 0.1135115478309695d,bottom: 0.0662209152683666d,left: 0.10061949092590927d),

new NpgsqlTypes.NpgsqlBox(top: 0.3515837937427584d,right: 0.852250309942974d,bottom: 0.0875264667747171d,left: 0.3804471641660433d),

new NpgsqlTypes.NpgsqlBox(top: 0.977687880864272d,right: 0.9091480673453172d,bottom: 0.9025668011878779d,left: 0.6189436338573493d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5369339988958375d,right: 0.9483474479382901d,bottom: 0.2692475193887409d,left: 0.1480674851178042d),

new NpgsqlTypes.NpgsqlBox(top: 0.9024090085710945d,right: 0.1668669674975516d,bottom: 0.4478440568852504d,left: 0.1490966140243687d),

new NpgsqlTypes.NpgsqlBox(top: 0.5059792233353825d,right: 0.4581692303200795d,bottom: 0.33426870733437886d,left: 0.07172743872334153d),

new NpgsqlTypes.NpgsqlBox(top: 0.7858374607127592d,right: 0.9281028618857482d,bottom: 0.38984062062608926d,left: 0.7433896627967743d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9438247785344667d,right: 0.8470882151479778d,bottom: 0.47478291063094435d,left: 0.3092111611378865d),

new NpgsqlTypes.NpgsqlBox(top: 0.522267562307209d,right: 0.8818100888981825d,bottom: 0.06332807642884619d,left: 0.0023562943008115234d),

new NpgsqlTypes.NpgsqlBox(top: 0.9417887125982829d,right: 0.18829126916477879d,bottom: 0.04217061410429601d,left: 0.0758784245181251d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.29824534933269364d,right: 0.9651148540109813d,bottom: 0.09030434721039837d,left: 0.5904147000339846d),

new NpgsqlTypes.NpgsqlBox(top: 0.9530257789321732d,right: 0.9947582443152585d,bottom: 0.9324092290410051d,left: 0.8228347448447934d),

new NpgsqlTypes.NpgsqlBox(top: 0.834513435327765d,right: 0.5550772714428379d,bottom: 0.6397161599434003d,left: 0.20299039290915444d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5799688673102651d,right: 0.47911508027589733d,bottom: 0.5059864689809978d,left: 0.14919759005956867d),

new NpgsqlTypes.NpgsqlBox(top: 0.584390866217481d,right: 0.9833384178885992d,bottom: 0.527347264790866d,left: 0.1183515156575885d),

new NpgsqlTypes.NpgsqlBox(top: 0.6877882740816265d,right: 0.8810211349658834d,bottom: 0.43700306230235586d,left: 0.7907715106638614d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.716511903117742d,right: 0.8171607957504534d,bottom: 0.3704737797001586d,left: 0.6203883396113417d),

new NpgsqlTypes.NpgsqlBox(top: 0.6492030074626118d,right: 0.45771221142810814d,bottom: 0.42937069529927485d,left: 0.007223298189682592d),

new NpgsqlTypes.NpgsqlBox(top: 0.894521256594365d,right: 0.43100335957622515d,bottom: 0.3799558783750534d,left: 0.3949451595158061d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5942722484579428d,right: 0.7931930271003658d,bottom: 0.13711686738784779d,left: 0.1265256624557174d),

new NpgsqlTypes.NpgsqlBox(top: 0.8201270136987698d,right: 0.6809300402632164d,bottom: 0.34184179613459964d,left: 0.15395324634180774d),

new NpgsqlTypes.NpgsqlBox(top: 0.33823042735770503d,right: 0.8185829996511403d,bottom: 0.16625490776203578d,left: 0.7713194840436587d),

new NpgsqlTypes.NpgsqlBox(top: 0.7385796055025547d,right: 0.7534326520930623d,bottom: 0.028997723253890606d,left: 0.48285558464125566d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3019667683814792d,right: 0.4761705111488742d,bottom: 0.12129924843150641d,left: 0.17431696019961263d),

new NpgsqlTypes.NpgsqlBox(top: 0.2996984683526661d,right: 0.12169778091810846d,bottom: 0.2682253304618524d,left: 0.11777275673708199d),

new NpgsqlTypes.NpgsqlBox(top: 0.9478032453820172d,right: 0.3133716678823004d,bottom: 0.8718676532246332d,left: 0.2612147710274789d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9452740389441191d,right: 0.9631239195734164d,bottom: 0.08667067792036542d,left: 0.08965042993774941d),

new NpgsqlTypes.NpgsqlBox(top: 0.8492009005043094d,right: 0.919228666981494d,bottom: 0.5567969101133028d,left: 0.18381935735911814d),

new NpgsqlTypes.NpgsqlBox(top: 0.8166404436836796d,right: 0.6318792929943465d,bottom: 0.2123667361323487d,left: 0.504203711000395d),

new NpgsqlTypes.NpgsqlBox(top: 0.8891018752589775d,right: 0.8890598091302268d,bottom: 0.5539675756719256d,left: 0.6850593815302003d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5394859186116987d,right: 0.4538622162600833d,bottom: 0.3074061977494643d,left: 0.4077069241638126d),

new NpgsqlTypes.NpgsqlBox(top: 0.7936901997697745d,right: 0.3214287767449421d,bottom: 0.2658515538003041d,left: 0.16609688876708284d),

new NpgsqlTypes.NpgsqlBox(top: 0.2340349581904697d,right: 0.9231462161698433d,bottom: 0.02019733319942374d,left: 0.6737199250734288d),

new NpgsqlTypes.NpgsqlBox(top: 0.805610534467417d,right: 0.9954002403241248d,bottom: 0.5464497363757437d,left: 0.6714759171731006d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.054219258099870826d,right: 0.8686871511404827d,bottom: 0.034111942400707584d,left: 0.4433188526740428d),

new NpgsqlTypes.NpgsqlBox(top: 0.9776086976693993d,right: 0.6828740879755627d,bottom: 0.2987729216902768d,left: 0.5614724453994314d),

new NpgsqlTypes.NpgsqlBox(top: 0.36762034393827414d,right: 0.27058742270710057d,bottom: 0.3314500370130431d,left: 0.22169303815776042d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.17664498515478932d,right: 0.5853271045266537d,bottom: 0.149343874501769d,left: 0.5075699389742495d),

new NpgsqlTypes.NpgsqlBox(top: 0.1794419423988881d,right: 0.19990063265551294d,bottom: 0.030273783905931162d,left: 0.1068924184414366d),

new NpgsqlTypes.NpgsqlBox(top: 0.9426464265006773d,right: 0.729152120544576d,bottom: 0.20672911215369139d,left: 0.21823391254538593d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9109813904806601d,right: 0.5912444194707717d,bottom: 0.8748059721319477d,left: 0.3507341145900913d),

new NpgsqlTypes.NpgsqlBox(top: 0.5950211826362571d,right: 0.9205834790902733d,bottom: 0.07196789727219055d,left: 0.7731527770500065d),

new NpgsqlTypes.NpgsqlBox(top: 0.5240083205731307d,right: 0.3921774894846123d,bottom: 0.24921003708535605d,left: 0.24289677988394864d),

new NpgsqlTypes.NpgsqlBox(top: 0.9258079081649406d,right: 0.2719008636115725d,bottom: 0.6182990555136588d,left: 0.256627481804388d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7169021856773761d,right: 0.6389762193438d,bottom: 0.008395778481518845d,left: 0.26754123356264203d),

new NpgsqlTypes.NpgsqlBox(top: 0.8079001145439564d,right: 0.8848026052371754d,bottom: 0.24723232382378924d,left: 0.3352150436958975d),

new NpgsqlTypes.NpgsqlBox(top: 0.5777021378232017d,right: 0.8603947080105759d,bottom: 0.3845248942063526d,left: 0.17560363051740868d),

new NpgsqlTypes.NpgsqlBox(top: 0.5047674120881245d,right: 0.7913649149607874d,bottom: 0.1461102230795437d,left: 0.5881269538269953d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9364276385199782d,right: 0.6031400532878971d,bottom: 0.6601641759988227d,left: 0.42977214105707284d),

new NpgsqlTypes.NpgsqlBox(top: 0.855802189026091d,right: 0.8707576589430901d,bottom: 0.10916827432694587d,left: 0.13497529550864595d),

new NpgsqlTypes.NpgsqlBox(top: 0.6480882181273726d,right: 0.8104248362990343d,bottom: 0.6413902739385097d,left: 0.21377051561464044d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5974602014296884d,right: 0.727879932667688d,bottom: 0.041839672053732846d,left: 0.5107229157369259d),

new NpgsqlTypes.NpgsqlBox(top: 0.841788854355973d,right: 0.8925813209956365d,bottom: 0.26758329321518903d,left: 0.25313003624495645d),

new NpgsqlTypes.NpgsqlBox(top: 0.7813929661228174d,right: 0.5209158128464976d,bottom: 0.541751288658173d,left: 0.0687111223897402d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.158521686467892d,right: 0.6970440218170192d,bottom: 0.08006282816224619d,left: 0.35314049353206634d),

new NpgsqlTypes.NpgsqlBox(top: 0.5664480781842924d,right: 0.8828722433688277d,bottom: 0.27530726234196556d,left: 0.7858795939628274d),

new NpgsqlTypes.NpgsqlBox(top: 0.7870343920142945d,right: 0.4226555729265856d,bottom: 0.7336376994508949d,left: 0.055554613913515793d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5491393981128461d,right: 0.7639274477117679d,bottom: 0.46070521856867697d,left: 0.1024792334681085d),

new NpgsqlTypes.NpgsqlBox(top: 0.753675593631562d,right: 0.368472651585087d,bottom: 0.3802118890152105d,left: 0.18934355597170682d),

new NpgsqlTypes.NpgsqlBox(top: 0.9981528399378893d,right: 0.9870706228441483d,bottom: 0.20899897226509268d,left: 0.03693810042327783d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6693988819266183d,right: 0.4105479572374705d,bottom: 0.30365637821326485d,left: 0.37958936257912657d),

new NpgsqlTypes.NpgsqlBox(top: 0.9694966471780767d,right: 0.8754953238880857d,bottom: 0.5285096363669828d,left: 0.7934624373627633d),

new NpgsqlTypes.NpgsqlBox(top: 0.6960369807190696d,right: 0.8125861242095104d,bottom: 0.31139064092051205d,left: 0.12460682114085031d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7693295085181667d,right: 0.4439482065523971d,bottom: 0.293582436484056d,left: 0.03653135198193136d),

new NpgsqlTypes.NpgsqlBox(top: 0.5978524522889231d,right: 0.6254208897451503d,bottom: 0.17054500189727018d,left: 0.36481408435685114d),

new NpgsqlTypes.NpgsqlBox(top: 0.8235708446041198d,right: 0.9367168834508233d,bottom: 0.23038129885323155d,left: 0.8811636174705492d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9310542961090613d,right: 0.4521374031489037d,bottom: 0.28128277689121595d,left: 0.07058666917071554d),

new NpgsqlTypes.NpgsqlBox(top: 0.5671855811809072d,right: 0.9444590621752522d,bottom: 0.4064387263855045d,left: 0.5389328079604628d),

new NpgsqlTypes.NpgsqlBox(top: 0.9282478992809834d,right: 0.8728156778224108d,bottom: 0.8058635844465547d,left: 0.4494288009677675d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5874300574213428d,right: 0.774989660861317d,bottom: 0.4140875949891616d,left: 0.25898738943480926d),

new NpgsqlTypes.NpgsqlBox(top: 0.5181648556088297d,right: 0.9020403270970764d,bottom: 0.1769194806285821d,left: 0.07143707198866134d),

new NpgsqlTypes.NpgsqlBox(top: 0.7239478600896169d,right: 0.14881178524731586d,bottom: 0.2920676463357651d,left: 0.1184352244622221d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9039532022424193d,right: 0.8489194776105867d,bottom: 0.7600882255601318d,left: 0.31613349336469354d),

new NpgsqlTypes.NpgsqlBox(top: 0.9834421938730538d,right: 0.8847067492271983d,bottom: 0.19811571362113156d,left: 0.5150068066948803d),

new NpgsqlTypes.NpgsqlBox(top: 0.8974211407140628d,right: 0.13650790833664417d,bottom: 0.3971227425646231d,left: 0.09485451555189828d),

new NpgsqlTypes.NpgsqlBox(top: 0.78241818805926d,right: 0.2261384147089167d,bottom: 0.4823409767856517d,left: 0.16798740007225876d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9913507106754177d,right: 0.9312356345838827d,bottom: 0.6007898516563551d,left: 0.4929887194707373d),

new NpgsqlTypes.NpgsqlBox(top: 0.29364473476168573d,right: 0.9116567439490909d,bottom: 0.21380193720377505d,left: 0.7111938007244352d),

new NpgsqlTypes.NpgsqlBox(top: 0.9017219598183004d,right: 0.7153024648254497d,bottom: 0.6812358104291507d,left: 0.4932023867441728d),

new NpgsqlTypes.NpgsqlBox(top: 0.9380406542637757d,right: 0.8396146741175297d,bottom: 0.06095282820586212d,left: 0.7479128688411122d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8493047325859739d,right: 0.7759062233398638d,bottom: 0.3320743588787235d,left: 0.7619430128814225d),

new NpgsqlTypes.NpgsqlBox(top: 0.5267933640379973d,right: 0.6801766745590003d,bottom: 0.3048395139468971d,left: 0.31032730716084944d),

new NpgsqlTypes.NpgsqlBox(top: 0.767865076904563d,right: 0.7678067404262245d,bottom: 0.5797768475056427d,left: 0.5379847113606214d),

new NpgsqlTypes.NpgsqlBox(top: 0.9380210995601971d,right: 0.20439782488795433d,bottom: 0.7405662915251028d,left: 0.0919798645284271d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8453464334965773d,right: 0.7997824112449218d,bottom: 0.5097558385218959d,left: 0.21332291219894084d),

new NpgsqlTypes.NpgsqlBox(top: 0.8192510281426244d,right: 0.9734896345830766d,bottom: 0.6790372268871586d,left: 0.5682439059373551d),

new NpgsqlTypes.NpgsqlBox(top: 0.9943534697000989d,right: 0.9192398349304661d,bottom: 0.10219264084489121d,left: 0.06170640341013456d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8956836124572402d,right: 0.9250764941690521d,bottom: 0.7139699344111974d,left: 0.16696759562785557d),

new NpgsqlTypes.NpgsqlBox(top: 0.6202677950421305d,right: 0.294680619008737d,bottom: 0.17870617807876177d,left: 0.1939485757944076d),

new NpgsqlTypes.NpgsqlBox(top: 0.6562987121414785d,right: 0.8214425671622372d,bottom: 0.466272109968047d,left: 0.7609084992863513d),

new NpgsqlTypes.NpgsqlBox(top: 0.3493971527814861d,right: 0.4267451853059384d,bottom: 0.13408421337549958d,left: 0.07587906379918519d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9928451161929728d,right: 0.3812333320747513d,bottom: 0.4796979034029144d,left: 0.2826250424669441d),

new NpgsqlTypes.NpgsqlBox(top: 0.04337510357665264d,right: 0.9693416395714616d,bottom: 0.03617205908045207d,left: 0.335039246165563d),

new NpgsqlTypes.NpgsqlBox(top: 0.2973011371894895d,right: 0.749425683160736d,bottom: 0.011644300867903135d,left: 0.03304356062640201d),

new NpgsqlTypes.NpgsqlBox(top: 0.6467729674305676d,right: 0.5099918432359121d,bottom: 0.4848546365164229d,left: 0.11448645305616745d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.31634302549638826d,right: 0.9751787922804794d,bottom: 0.17934610719669153d,left: 0.09977919364078003d),

new NpgsqlTypes.NpgsqlBox(top: 0.9676869673108985d,right: 0.8127253325777264d,bottom: 0.3890758359073412d,left: 0.10149303115964581d),

new NpgsqlTypes.NpgsqlBox(top: 0.9142759323679801d,right: 0.20299630770623323d,bottom: 0.6314705467569509d,left: 0.1320777508151193d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9041630745449776d,right: 0.46031751491312844d,bottom: 0.36955191227969564d,left: 0.4402251381655683d),

new NpgsqlTypes.NpgsqlBox(top: 0.30879013358493157d,right: 0.3789974142498539d,bottom: 0.2023815672331869d,left: 0.31477165106532456d),

new NpgsqlTypes.NpgsqlBox(top: 0.8734290317384016d,right: 0.9823216277906865d,bottom: 0.4085699376739188d,left: 0.2555672096518927d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2878256452797504d,right: 0.7764619367667994d,bottom: 0.2802621716757532d,left: 0.0804193259904108d),

new NpgsqlTypes.NpgsqlBox(top: 0.37904895694277985d,right: 0.8998918755191155d,bottom: 0.2910861063061304d,left: 0.2674904169350828d),

new NpgsqlTypes.NpgsqlBox(top: 0.801173071766932d,right: 0.7067601220281122d,bottom: 0.052115771869528205d,left: 0.3468848491417237d),

new NpgsqlTypes.NpgsqlBox(top: 0.8959160575530742d,right: 0.39597311254742285d,bottom: 0.6989807083410466d,left: 0.046346001303419815d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9325217761601907d,right: 0.9208673748031813d,bottom: 0.11109829538783211d,left: 0.053879534618067604d),

new NpgsqlTypes.NpgsqlBox(top: 0.5553853698487677d,right: 0.70287085455165d,bottom: 0.32799620146409525d,left: 0.6667594230817377d),

new NpgsqlTypes.NpgsqlBox(top: 0.3424270774710514d,right: 0.7796860884819324d,bottom: 0.20028589262316676d,left: 0.32417511739167326d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6245392095513448d,right: 0.3392471901513652d,bottom: 0.10049627606672884d,left: 0.14698872937537055d),

new NpgsqlTypes.NpgsqlBox(top: 0.19738565502737582d,right: 0.41411511912990884d,bottom: 0.009971492312213837d,left: 0.33182971858574273d),

new NpgsqlTypes.NpgsqlBox(top: 0.652373255987627d,right: 0.8992093171725063d,bottom: 0.09112565418167007d,left: 0.7208579396454337d),

new NpgsqlTypes.NpgsqlBox(top: 0.4895738118762676d,right: 0.9941305257925337d,bottom: 0.29328656498887495d,left: 0.7176714319246688d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8808052585317697d,right: 0.3027928024637694d,bottom: 0.05658055816766627d,left: 0.23986962981621074d),

new NpgsqlTypes.NpgsqlBox(top: 0.9681433906488558d,right: 0.7826028889509401d,bottom: 0.3005778480483946d,left: 0.3212090568180982d),

new NpgsqlTypes.NpgsqlBox(top: 0.8191819049834969d,right: 0.6553216384905636d,bottom: 0.6928481243747509d,left: 0.3892179321406727d),

new NpgsqlTypes.NpgsqlBox(top: 0.8426806388151965d,right: 0.3221665257484122d,bottom: 0.6723319016021598d,left: 0.07398023104438023d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9194481141916672d,right: 0.7845538917992653d,bottom: 0.8822250281793693d,left: 0.4786952805111212d),

new NpgsqlTypes.NpgsqlBox(top: 0.815703195992758d,right: 0.721076214118122d,bottom: 0.6401658932027525d,left: 0.022884378117492d),

new NpgsqlTypes.NpgsqlBox(top: 0.8197270849473078d,right: 0.8285379197647972d,bottom: 0.4865282807669359d,left: 0.3168975640066536d),

new NpgsqlTypes.NpgsqlBox(top: 0.4903016473498538d,right: 0.8033985099665406d,bottom: 0.2962273961452895d,left: 0.21956499286972908d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7865143688108748d,right: 0.7280004936811182d,bottom: 0.6029256921058428d,left: 0.43318791849396476d),

new NpgsqlTypes.NpgsqlBox(top: 0.9770609501889103d,right: 0.7923634075489314d,bottom: 0.3513735235791091d,left: 0.5485518605656066d),

new NpgsqlTypes.NpgsqlBox(top: 0.5974876155651051d,right: 0.9578090715597096d,bottom: 0.07290370662504142d,left: 0.4204561920847847d),

new NpgsqlTypes.NpgsqlBox(top: 0.17912751377411795d,right: 0.6748718851847109d,bottom: 0.006649120615206838d,left: 0.013507086591348472d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48008578765226606d,right: 0.6267642139006414d,bottom: 0.3506573760797671d,left: 0.5760151391052926d),

new NpgsqlTypes.NpgsqlBox(top: 0.33983345915594776d,right: 0.9594010113821145d,bottom: 0.016438193938690948d,left: 0.37250393057316056d),

new NpgsqlTypes.NpgsqlBox(top: 0.8203250454902477d,right: 0.30766327968136287d,bottom: 0.350445083702009d,left: 0.3035506824506867d),

new NpgsqlTypes.NpgsqlBox(top: 0.5304811655956508d,right: 0.9718384305283303d,bottom: 0.42303815465869476d,left: 0.7791719524066001d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.872545564851945d,right: 0.8081956596862291d,bottom: 0.2576669074824086d,left: 0.07951584966574199d),

new NpgsqlTypes.NpgsqlBox(top: 0.4126652702856707d,right: 0.7495201326480176d,bottom: 0.22430056810442267d,left: 0.10930748449276273d),

new NpgsqlTypes.NpgsqlBox(top: 0.9073380482077159d,right: 0.4985233433298112d,bottom: 0.5874494519082495d,left: 0.4744233311566213d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7839332825126959d,right: 0.7032196532331413d,bottom: 0.37256391310672643d,left: 0.41847175245881785d),

new NpgsqlTypes.NpgsqlBox(top: 0.9661585714110341d,right: 0.5924059897393124d,bottom: 0.2368045114005476d,left: 0.14721188785176642d),

new NpgsqlTypes.NpgsqlBox(top: 0.47575306285512975d,right: 0.7640971462206233d,bottom: 0.3158393582474013d,left: 0.6570035361418123d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43362780658637057d,right: 0.959299715723379d,bottom: 0.24001634594802534d,left: 0.22609212743183826d),

new NpgsqlTypes.NpgsqlBox(top: 0.9568133457874778d,right: 0.9406218051026398d,bottom: 0.7568506670572024d,left: 0.32565562351548405d),

new NpgsqlTypes.NpgsqlBox(top: 0.48384024462497155d,right: 0.9426451446066544d,bottom: 0.14057028579222386d,left: 0.7463439719754877d),

new NpgsqlTypes.NpgsqlBox(top: 0.8828976728130641d,right: 0.5306859113045298d,bottom: 0.39397967563779d,left: 0.33020368390900445d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48652326776237087d,right: 0.4975689298345578d,bottom: 0.03916672773920127d,left: 0.13554135820000168d),

new NpgsqlTypes.NpgsqlBox(top: 0.7636837892127428d,right: 0.514228500118983d,bottom: 0.3064442510987201d,left: 0.05465074741552889d),

new NpgsqlTypes.NpgsqlBox(top: 0.9257722411068258d,right: 0.737818428916487d,bottom: 0.7917661286942452d,left: 0.23112186420346104d),

new NpgsqlTypes.NpgsqlBox(top: 0.991182448978688d,right: 0.6264125355066145d,bottom: 0.0016026461944491643d,left: 0.5272640672189952d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9897351330002833d,right: 0.8529730581624004d,bottom: 0.3097871692239752d,left: 0.7547513242847275d),

new NpgsqlTypes.NpgsqlBox(top: 0.8400824507158455d,right: 0.23028302233127151d,bottom: 0.004628229601664979d,left: 0.2101568132630569d),

new NpgsqlTypes.NpgsqlBox(top: 0.8327648258832498d,right: 0.8615470544675702d,bottom: 0.010492899017571555d,left: 0.31746977149650824d),

new NpgsqlTypes.NpgsqlBox(top: 0.5183339004761547d,right: 0.6733650613707036d,bottom: 0.22483758092071982d,left: 0.06653730524202184d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6459611014088484d,right: 0.456357304984775d,bottom: 0.3665015844515761d,left: 0.3379794268386127d),

new NpgsqlTypes.NpgsqlBox(top: 0.8052150658061856d,right: 0.9625838398807994d,bottom: 0.039540164458111926d,left: 0.4991957977943625d),

new NpgsqlTypes.NpgsqlBox(top: 0.8687013180391564d,right: 0.3876438994256526d,bottom: 0.4044463683529961d,left: 0.2383361974350381d),

new NpgsqlTypes.NpgsqlBox(top: 0.6970465682273881d,right: 0.3843889218408263d,bottom: 0.10247393526523452d,left: 0.15581117935656463d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2526853385101776d,right: 0.47671324976049d,bottom: 0.06964968206906286d,left: 0.36401315976017656d),

new NpgsqlTypes.NpgsqlBox(top: 0.8028758925329206d,right: 0.7770853149119388d,bottom: 0.7310192417080927d,left: 0.1453806083746445d),

new NpgsqlTypes.NpgsqlBox(top: 0.7390527304067607d,right: 0.8393656980026045d,bottom: 0.3343077328469324d,left: 0.6045525427549419d),

new NpgsqlTypes.NpgsqlBox(top: 0.7064321006583587d,right: 0.9636896816649754d,bottom: 0.6079989986504204d,left: 0.1716363942822916d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5844891572334535d,right: 0.561554699227957d,bottom: 0.4675633208251916d,left: 0.08446754740343032d),

new NpgsqlTypes.NpgsqlBox(top: 0.7651874803306277d,right: 0.8506494451019482d,bottom: 0.6520723278891147d,left: 0.6790628262481485d),

new NpgsqlTypes.NpgsqlBox(top: 0.9607456480161688d,right: 0.6839613006433223d,bottom: 0.11364150218904079d,left: 0.20980380715031866d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6556593439243273d,right: 0.17916524122602417d,bottom: 0.4287375094436582d,left: 0.13697250911303938d),

new NpgsqlTypes.NpgsqlBox(top: 0.7974103029461477d,right: 0.466635857781719d,bottom: 0.2282673867417675d,left: 0.12646172139187128d),

new NpgsqlTypes.NpgsqlBox(top: 0.8910971915985131d,right: 0.45229643449926016d,bottom: 0.5747393895419758d,left: 0.382233797933357d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.960969379042085d,right: 0.8758084072600306d,bottom: 0.5868299129160736d,left: 0.7661341910347533d),

new NpgsqlTypes.NpgsqlBox(top: 0.4132530108608312d,right: 0.5624074182422901d,bottom: 0.04036820425312071d,left: 0.3465178060088798d),

new NpgsqlTypes.NpgsqlBox(top: 0.8844697586527757d,right: 0.783405283459221d,bottom: 0.037392868585750194d,left: 0.3689303467099878d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7965914111804994d,right: 0.12298785211261798d,bottom: 0.5365044388090229d,left: 0.04537896497972671d),

new NpgsqlTypes.NpgsqlBox(top: 0.7496865392410477d,right: 0.9942199158960275d,bottom: 0.020066800086084635d,left: 0.6224178649952569d),

new NpgsqlTypes.NpgsqlBox(top: 0.8328066788918556d,right: 0.7683787150543934d,bottom: 0.1942361858528785d,left: 0.44187353050982725d),

new NpgsqlTypes.NpgsqlBox(top: 0.4438956210575855d,right: 0.8024899728219453d,bottom: 0.19838163757765703d,left: 0.4107086103880647d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8120830319504955d,right: 0.9979475664106198d,bottom: 0.5391761771601791d,left: 0.09819432088923363d),

new NpgsqlTypes.NpgsqlBox(top: 0.878567229739257d,right: 0.5610159320476855d,bottom: 0.17472542158037563d,left: 0.07592695053123222d),

new NpgsqlTypes.NpgsqlBox(top: 0.7753448544888041d,right: 0.7342994669131676d,bottom: 0.7350987185769638d,left: 0.5812805896822294d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5092598067877228d,right: 0.6480699717624347d,bottom: 0.04045785538370561d,left: 0.614169465127967d),

new NpgsqlTypes.NpgsqlBox(top: 0.881402307372603d,right: 0.7403101514560524d,bottom: 0.6406123390646105d,left: 0.2872697538795256d),

new NpgsqlTypes.NpgsqlBox(top: 0.6763700758600693d,right: 0.9976543989872996d,bottom: 0.522836645389661d,left: 0.5123191812750614d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9740196325988932d,right: 0.6496543029373815d,bottom: 0.15136373862286157d,left: 0.2726747576317584d),

new NpgsqlTypes.NpgsqlBox(top: 0.5025084746169826d,right: 0.682487199342818d,bottom: 0.49289665979019737d,left: 0.4339365814511027d),

new NpgsqlTypes.NpgsqlBox(top: 0.34647238740484987d,right: 0.6905286005178602d,bottom: 0.23495503132476359d,left: 0.2384088362122504d),

new NpgsqlTypes.NpgsqlBox(top: 0.8267867765212364d,right: 0.8712192439300749d,bottom: 0.41776794578066034d,left: 0.8652968166790812d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.941866990437594d,right: 0.4531534765322124d,bottom: 0.26663963236054344d,left: 0.10457710816132293d),

new NpgsqlTypes.NpgsqlBox(top: 0.7410515971929417d,right: 0.6084778975590638d,bottom: 0.5569328418497168d,left: 0.30462868664822695d),

new NpgsqlTypes.NpgsqlBox(top: 0.5117311183153345d,right: 0.8664757551350245d,bottom: 0.37900953257124226d,left: 0.7627272903813467d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49467228403351093d,right: 0.5946358395297777d,bottom: 0.24585411872352692d,left: 0.40422218137901533d),

new NpgsqlTypes.NpgsqlBox(top: 0.6310563446897716d,right: 0.4969027652187391d,bottom: 0.23229431784811438d,left: 0.13342759547083238d),

new NpgsqlTypes.NpgsqlBox(top: 0.9558154151811824d,right: 0.33230585457996387d,bottom: 0.444803282674033d,left: 0.21483285739443003d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6722400504252819d,right: 0.9567951218110425d,bottom: 0.017893094059364012d,left: 0.058637534773446465d),

new NpgsqlTypes.NpgsqlBox(top: 0.2875499306347211d,right: 0.44874689302397686d,bottom: 0.08089274064072849d,left: 0.38644680199810244d),

new NpgsqlTypes.NpgsqlBox(top: 0.8864177460222884d,right: 0.8946370570036845d,bottom: 0.5528217446492751d,left: 0.8649101375133766d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.11336584252284998d,right: 0.8268949301151872d,bottom: 0.06021176584849308d,left: 0.09538520717619792d),

new NpgsqlTypes.NpgsqlBox(top: 0.7246866479965822d,right: 0.7514611395126677d,bottom: 0.7108272314470545d,left: 0.6128109343273388d),

new NpgsqlTypes.NpgsqlBox(top: 0.869868471515349d,right: 0.9502524461035292d,bottom: 0.6937657854915485d,left: 0.303224619769743d),

new NpgsqlTypes.NpgsqlBox(top: 0.7327303187802097d,right: 0.6841689496864489d,bottom: 0.2026315610398859d,left: 0.2823839339773899d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7320265765106764d,right: 0.9872098450900451d,bottom: 0.2995592343832033d,left: 0.0413723201687638d),

new NpgsqlTypes.NpgsqlBox(top: 0.5334411241763662d,right: 0.7921908159291605d,bottom: 0.4669959926603171d,left: 0.6330813537361047d),

new NpgsqlTypes.NpgsqlBox(top: 0.2900788069796142d,right: 0.901312074969548d,bottom: 0.25178354455698104d,left: 0.2673612807057062d),

new NpgsqlTypes.NpgsqlBox(top: 0.5731822252952302d,right: 0.839531892484223d,bottom: 0.09828746754077877d,left: 0.2502365198521018d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9540564168302733d,right: 0.5370752450951752d,bottom: 0.05839135586204813d,left: 0.2804118442845356d),

new NpgsqlTypes.NpgsqlBox(top: 0.577214223032593d,right: 0.632040597416244d,bottom: 0.5411043321193266d,left: 0.3124636772149575d),

new NpgsqlTypes.NpgsqlBox(top: 0.9347872717628802d,right: 0.9902293454091485d,bottom: 0.2691767275902811d,left: 0.624610033766066d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4283642897743585d,right: 0.7920002881574072d,bottom: 0.1623252521457046d,left: 0.6690944479011844d),

new NpgsqlTypes.NpgsqlBox(top: 0.6943421998616495d,right: 0.7912149502655922d,bottom: 0.3823627203519018d,left: 0.5322913438304645d),

new NpgsqlTypes.NpgsqlBox(top: 0.9433152292826772d,right: 0.26457323058855775d,bottom: 0.8276370953622932d,left: 0.017183113694181684d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8534557464502228d,right: 0.5495798229634729d,bottom: 0.12737771668921205d,left: 0.44931250109048004d),

new NpgsqlTypes.NpgsqlBox(top: 0.7444093300397026d,right: 0.9135471918223463d,bottom: 0.37003424970082577d,left: 0.42793028751889184d),

new NpgsqlTypes.NpgsqlBox(top: 0.3852168446496763d,right: 0.8189391047914252d,bottom: 0.1064014147655985d,left: 0.22954443001687874d),

new NpgsqlTypes.NpgsqlBox(top: 0.952784648032812d,right: 0.857295747478395d,bottom: 0.06065975689856962d,left: 0.15978193589877687d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9753433133152801d,right: 0.628644427415305d,bottom: 0.8751442837169013d,left: 0.5479738908652323d),

new NpgsqlTypes.NpgsqlBox(top: 0.9631219342203201d,right: 0.6328458079764577d,bottom: 0.8696496340941414d,left: 0.194748285440965d),

new NpgsqlTypes.NpgsqlBox(top: 0.9296044243112538d,right: 0.43309952832879184d,bottom: 0.43286699169766807d,left: 0.14042974504857786d),

new NpgsqlTypes.NpgsqlBox(top: 0.9509498250315069d,right: 0.7119295963799964d,bottom: 0.31071552358664045d,left: 0.44558815192989876d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.21118492353891694d,right: 0.30152408330399394d,bottom: 0.20309652726619976d,left: 0.26340138880566655d),

new NpgsqlTypes.NpgsqlBox(top: 0.8165439016195916d,right: 0.3644565293117673d,bottom: 0.5344726006578532d,left: 0.04213790717849897d),

new NpgsqlTypes.NpgsqlBox(top: 0.41174139804628074d,right: 0.830324944243652d,bottom: 0.2666627787621004d,left: 0.4474390070660983d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9422645436976874d,right: 0.7568014786928152d,bottom: 0.32592736790815724d,left: 0.4252872943528959d),

new NpgsqlTypes.NpgsqlBox(top: 0.6642993280515447d,right: 0.7342875448419816d,bottom: 0.6392066237851876d,left: 0.39715402978560677d),

new NpgsqlTypes.NpgsqlBox(top: 0.6007469315010779d,right: 0.5286799444173215d,bottom: 0.09823193486071014d,left: 0.4130024994347756d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4932798279561147d,right: 0.6393140851772957d,bottom: 0.25923689980806786d,left: 0.5018792261739399d),

new NpgsqlTypes.NpgsqlBox(top: 0.8786671404241613d,right: 0.8373452810805413d,bottom: 0.6594586546718759d,left: 0.11765100073589607d),

new NpgsqlTypes.NpgsqlBox(top: 0.24323693497273158d,right: 0.9165294562961169d,bottom: 0.10357249255912837d,left: 0.3012929217757767d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9435813441731474d,right: 0.7890052218966933d,bottom: 0.008346970515667906d,left: 0.361424481290451d),

new NpgsqlTypes.NpgsqlBox(top: 0.7421153454655639d,right: 0.6150879647655313d,bottom: 0.4269559681603664d,left: 0.3478476622216382d),

new NpgsqlTypes.NpgsqlBox(top: 0.8699424658318529d,right: 0.5715880023482758d,bottom: 0.34089512895417473d,left: 0.05407426485233968d),

new NpgsqlTypes.NpgsqlBox(top: 0.2831192788901953d,right: 0.7589374458736708d,bottom: 0.20772016123906623d,left: 0.10074710907469397d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.586377578395007d,right: 0.8612138626811493d,bottom: 0.5748971736510002d,left: 0.635423860435453d),

new NpgsqlTypes.NpgsqlBox(top: 0.38033370700601876d,right: 0.428802959480738d,bottom: 0.3080507740398566d,left: 0.09077667007478318d),

new NpgsqlTypes.NpgsqlBox(top: 0.39129273053851743d,right: 0.9125488037128116d,bottom: 0.2103643440368389d,left: 0.7687655320612838d),

new NpgsqlTypes.NpgsqlBox(top: 0.7436926186824291d,right: 0.3807426641407702d,bottom: 0.03160226514044939d,left: 0.01805241554131387d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5270772963552318d,right: 0.7014526984330721d,bottom: 0.24399689533610747d,left: 0.34093821061799634d),

new NpgsqlTypes.NpgsqlBox(top: 0.4270072472521914d,right: 0.7403578209156911d,bottom: 0.35693357970709494d,left: 0.7224991824179792d),

new NpgsqlTypes.NpgsqlBox(top: 0.6839212352149445d,right: 0.7739710286296351d,bottom: 0.067181446565584d,left: 0.6703507644546244d),

new NpgsqlTypes.NpgsqlBox(top: 0.9049784849322092d,right: 0.3814493602830349d,bottom: 0.46011239767034795d,left: 0.19755959185561d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22152588798988482d,right: 0.7233367950833763d,bottom: 0.04790034805443433d,left: 0.6765149967425793d),

new NpgsqlTypes.NpgsqlBox(top: 0.8711250439245259d,right: 0.8123721349078983d,bottom: 0.8675095177725897d,left: 0.4403093365020043d),

new NpgsqlTypes.NpgsqlBox(top: 0.8206768338762822d,right: 0.4727422360368576d,bottom: 0.5571136893083232d,left: 0.4718537265384767d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9683031866425085d,right: 0.6379046790111106d,bottom: 0.10826836525529304d,left: 0.3346844471534203d),

new NpgsqlTypes.NpgsqlBox(top: 0.5922180781374045d,right: 0.8918151475180854d,bottom: 0.35103756426259014d,left: 0.2717694980013583d),

new NpgsqlTypes.NpgsqlBox(top: 0.5286679822767666d,right: 0.630269664901691d,bottom: 0.5163472039103749d,left: 0.625998490935657d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22897965239412033d,right: 0.9117347474951126d,bottom: 0.22028717441998857d,left: 0.7044146851799157d),

new NpgsqlTypes.NpgsqlBox(top: 0.8781199049642211d,right: 0.6281435942150785d,bottom: 0.009870705225667575d,left: 0.06012403141233302d),

new NpgsqlTypes.NpgsqlBox(top: 0.6556090565776603d,right: 0.21462885191809533d,bottom: 0.5182580421763128d,left: 0.15123452301957274d),

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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 156;
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
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

                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 8, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatchAsync(connection, 27, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
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
                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatch(connection, 117, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

