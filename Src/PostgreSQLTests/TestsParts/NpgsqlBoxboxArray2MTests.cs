

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9445360601608981d,right: 0.5959139197227966d,bottom: 0.7803815955753497d,left: 0.13397183876459073d),

new NpgsqlTypes.NpgsqlBox(top: 0.7062561802497506d,right: 0.6891391404877685d,bottom: 0.43085167665072555d,left: 0.31610959350782175d),

new NpgsqlTypes.NpgsqlBox(top: 0.6129772734521152d,right: 0.5134303425159605d,bottom: 0.06618705110625378d,left: 0.4181529428436156d),

new NpgsqlTypes.NpgsqlBox(top: 0.2944994476353954d,right: 0.6567508784591976d,bottom: 0.2546987076475461d,left: 0.29373268478442505d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9463165508094273d,right: 0.3618293637776674d,bottom: 0.642671037567317d,left: 0.09394279989135113d),

new NpgsqlTypes.NpgsqlBox(top: 0.9787272100574068d,right: 0.44455577533435997d,bottom: 0.1401547782277539d,left: 0.2030574546625017d),

new NpgsqlTypes.NpgsqlBox(top: 0.9679784854609387d,right: 0.24899128910425272d,bottom: 0.053121658066456745d,left: 0.23807776612698128d),

new NpgsqlTypes.NpgsqlBox(top: 0.7237579066247745d,right: 0.18380408911343138d,bottom: 0.5352854721576631d,left: 0.1755561970992241d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6015692803156264d,right: 0.3512237379479314d,bottom: 0.5646000659227338d,left: 0.15564252699678505d),

new NpgsqlTypes.NpgsqlBox(top: 0.3512912559636293d,right: 0.11744980354989754d,bottom: 0.12605302833724186d,left: 0.08524485740115095d),

new NpgsqlTypes.NpgsqlBox(top: 0.5114738038036503d,right: 0.7447699187187935d,bottom: 0.14565999611369163d,left: 0.059054679105160934d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9946273089072527d,right: 0.7715750851747517d,bottom: 0.03863401950961587d,left: 0.6045424076306031d),

new NpgsqlTypes.NpgsqlBox(top: 0.987440036547935d,right: 0.21525254237242397d,bottom: 0.3637400948183964d,left: 0.05313824728742478d),

new NpgsqlTypes.NpgsqlBox(top: 0.6071936234651446d,right: 0.1425933132050392d,bottom: 0.43419063213785747d,left: 0.10625452635040344d),

new NpgsqlTypes.NpgsqlBox(top: 0.8032364414413183d,right: 0.78860917099685d,bottom: 0.665408533790789d,left: 0.6340829637057166d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9651621670523306d,right: 0.739804978863095d,bottom: 0.41532089121454174d,left: 0.4727326770078555d),

new NpgsqlTypes.NpgsqlBox(top: 0.354580646766544d,right: 0.5107173943989869d,bottom: 0.11203628065531146d,left: 0.1581608165092716d),

new NpgsqlTypes.NpgsqlBox(top: 0.8743487162517117d,right: 0.7257655563558937d,bottom: 0.1708702159517822d,left: 0.6517480628279558d),

new NpgsqlTypes.NpgsqlBox(top: 0.800937176707732d,right: 0.6336844262502624d,bottom: 0.6809901445681527d,left: 0.5718790872534051d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.87355709921301d,right: 0.7549216162258237d,bottom: 0.03779442495555585d,left: 0.026542992576776947d),

new NpgsqlTypes.NpgsqlBox(top: 0.7932419737043425d,right: 0.14031931860363056d,bottom: 0.6645691683784675d,left: 0.09827224199081253d),

new NpgsqlTypes.NpgsqlBox(top: 0.7000528837905352d,right: 0.5102556662592159d,bottom: 0.5576706338430684d,left: 0.37947132643660886d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7208495455399873d,right: 0.7064357310474274d,bottom: 0.3164131707700478d,left: 0.4237541257144537d),

new NpgsqlTypes.NpgsqlBox(top: 0.7257840482898308d,right: 0.5931699529128169d,bottom: 0.26368589389738406d,left: 0.4763800886197135d),

new NpgsqlTypes.NpgsqlBox(top: 0.24228726871649076d,right: 0.7981034181571426d,bottom: 0.20875249097985282d,left: 0.34862138944058185d),

new NpgsqlTypes.NpgsqlBox(top: 0.26788219683309566d,right: 0.8191582520050035d,bottom: 0.2608934467776922d,left: 0.6227116186218851d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5152030563602792d,right: 0.29566759793303654d,bottom: 0.38446239253778924d,left: 0.005447341147843621d),

new NpgsqlTypes.NpgsqlBox(top: 0.9726223966114967d,right: 0.9925556177668291d,bottom: 0.6838468221042495d,left: 0.1763721598413759d),

new NpgsqlTypes.NpgsqlBox(top: 0.3146828186237204d,right: 0.42768056067735494d,bottom: 0.19677227546108067d,left: 0.381081996503171d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.758051615431429d,right: 0.7117496296695508d,bottom: 0.2870165138095052d,left: 0.20956799883340027d),

new NpgsqlTypes.NpgsqlBox(top: 0.6201226904427571d,right: 0.8138735451311634d,bottom: 0.5972219191875013d,left: 0.1339057499744264d),

new NpgsqlTypes.NpgsqlBox(top: 0.6289694249449908d,right: 0.9069012275917766d,bottom: 0.5501087986360288d,left: 0.8009314292401062d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.900960120415233d,right: 0.7996043611674918d,bottom: 0.31613374125793203d,left: 0.6388614419727433d),

new NpgsqlTypes.NpgsqlBox(top: 0.5485137660222024d,right: 0.608150154071823d,bottom: 0.43840656369556774d,left: 0.5727010247098657d),

new NpgsqlTypes.NpgsqlBox(top: 0.7399134449636561d,right: 0.6732867447234258d,bottom: 0.06358174048165233d,left: 0.35269397023414506d),

new NpgsqlTypes.NpgsqlBox(top: 0.9002838474174052d,right: 0.9067816480359498d,bottom: 0.4628892826423324d,left: 0.15569200209620815d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7363253725652126d,right: 0.9769639134027768d,bottom: 0.19707389326165403d,left: 0.5616703481305806d),

new NpgsqlTypes.NpgsqlBox(top: 0.9058800971518425d,right: 0.5421625162203266d,bottom: 0.31553745610331574d,left: 0.3149467196824155d),

new NpgsqlTypes.NpgsqlBox(top: 0.47668723357712917d,right: 0.8115128400970194d,bottom: 0.3418995296500197d,left: 0.4036080222036246d),

new NpgsqlTypes.NpgsqlBox(top: 0.8074387288928899d,right: 0.3293419818027774d,bottom: 0.5851412963936066d,left: 0.13108610055233394d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3648904467976879d,right: 0.6742286431490567d,bottom: 0.21432562321870585d,left: 0.2179719435117199d),

new NpgsqlTypes.NpgsqlBox(top: 0.9990156882270702d,right: 0.9742414191933063d,bottom: 0.9818949285684897d,left: 0.21032209482490594d),

new NpgsqlTypes.NpgsqlBox(top: 0.8321752951431971d,right: 0.7882868783884885d,bottom: 0.6878897586352228d,left: 0.692689664433163d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.704514438608543d,right: 0.7185987991570575d,bottom: 0.16806402201947912d,left: 0.0969945007971893d),

new NpgsqlTypes.NpgsqlBox(top: 0.5197933816272914d,right: 0.7125335893219308d,bottom: 0.21174294235777003d,left: 0.2007015145711072d),

new NpgsqlTypes.NpgsqlBox(top: 0.7866637719182643d,right: 0.16365214732375055d,bottom: 0.2662416813318794d,left: 0.09499509547941798d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.834852733188551d,right: 0.7321941668801866d,bottom: 0.5463627832096367d,left: 0.3924659340887259d),

new NpgsqlTypes.NpgsqlBox(top: 0.5950456594091355d,right: 0.5593772733103536d,bottom: 0.38936859217858033d,left: 0.387466675510738d),

new NpgsqlTypes.NpgsqlBox(top: 0.6346823488031543d,right: 0.3891098235703224d,bottom: 0.48810680779950255d,left: 0.18353618034789576d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.45146310818299085d,right: 0.5318384601972681d,bottom: 0.42377202154003757d,left: 0.15776501049964942d),

new NpgsqlTypes.NpgsqlBox(top: 0.8112720952980949d,right: 0.9831744231965498d,bottom: 0.11580183832147894d,left: 0.7415308016589299d),

new NpgsqlTypes.NpgsqlBox(top: 0.8118232319449098d,right: 0.9009657088869504d,bottom: 0.6973773750943593d,left: 0.45368896649472257d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6069733405309166d,right: 0.5958436437562864d,bottom: 0.32144894546153213d,left: 0.5654024510861957d),

new NpgsqlTypes.NpgsqlBox(top: 0.9979477648652477d,right: 0.8474410450985047d,bottom: 0.0975609191210739d,left: 0.20564713733584328d),

new NpgsqlTypes.NpgsqlBox(top: 0.6704419659665143d,right: 0.3536138278476547d,bottom: 0.12665250989280963d,left: 0.011601481914548906d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9718285875692952d,right: 0.19914777696151198d,bottom: 0.7527329339203067d,left: 0.15134275327519497d),

new NpgsqlTypes.NpgsqlBox(top: 0.8559710878152512d,right: 0.6297433858098096d,bottom: 0.5713455479948906d,left: 0.13656649502834028d),

new NpgsqlTypes.NpgsqlBox(top: 0.7746831156619856d,right: 0.9297448305438448d,bottom: 0.0008544640857416352d,left: 0.6691281810603624d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8529346446323979d,right: 0.923154273571138d,bottom: 0.26160275658400456d,left: 0.162759241270786d),

new NpgsqlTypes.NpgsqlBox(top: 0.6037687860377927d,right: 0.8390103475096236d,bottom: 0.5299571671209572d,left: 0.672136688547913d),

new NpgsqlTypes.NpgsqlBox(top: 0.9237845653576444d,right: 0.8614554647545855d,bottom: 0.43474687986085314d,left: 0.4198350010627644d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8463306534420266d,right: 0.4910588354343809d,bottom: 0.5628507279738879d,left: 0.4623874638704054d),

new NpgsqlTypes.NpgsqlBox(top: 0.6341949757509209d,right: 0.8330396702318699d,bottom: 0.5749554030327971d,left: 0.26960392539040723d),

new NpgsqlTypes.NpgsqlBox(top: 0.9702753764753312d,right: 0.6981596231411977d,bottom: 0.3466632421704211d,left: 0.12862981234110027d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9517771746466922d,right: 0.6669239718748199d,bottom: 0.3021816787650615d,left: 0.5173753768513342d),

new NpgsqlTypes.NpgsqlBox(top: 0.7789718726894547d,right: 0.8474420504430651d,bottom: 0.44165820463178207d,left: 0.44650112414490184d),

new NpgsqlTypes.NpgsqlBox(top: 0.6666594441207316d,right: 0.6432339489535982d,bottom: 0.32436325435081326d,left: 0.3197913088357678d),

new NpgsqlTypes.NpgsqlBox(top: 0.6045353583183837d,right: 0.5474687596489284d,bottom: 0.23280726696665d,left: 0.02687477743793265d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9697695008896188d,right: 0.28846792330109905d,bottom: 0.29056800957862117d,left: 0.05043027689063284d),

new NpgsqlTypes.NpgsqlBox(top: 0.3471414947136988d,right: 0.8853863307712474d,bottom: 0.1783906886614819d,left: 0.46899846370121345d),

new NpgsqlTypes.NpgsqlBox(top: 0.7391068827918639d,right: 0.9870387886922919d,bottom: 0.13708673350461265d,left: 0.8899044058379764d),

new NpgsqlTypes.NpgsqlBox(top: 0.9466788233296101d,right: 0.4527335467637168d,bottom: 0.1905684452176145d,left: 0.12282069914987792d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5852286286239263d,right: 0.6623624424616108d,bottom: 0.4626425529225674d,left: 0.6209491768023994d),

new NpgsqlTypes.NpgsqlBox(top: 0.8959787822618718d,right: 0.8560535011260998d,bottom: 0.07662690448106124d,left: 0.34904432192635726d),

new NpgsqlTypes.NpgsqlBox(top: 0.3837662350522202d,right: 0.8483354033168923d,bottom: 0.03967388130738292d,left: 0.4854222245777621d),

new NpgsqlTypes.NpgsqlBox(top: 0.7419125011958474d,right: 0.958410268834408d,bottom: 0.34393011157379716d,left: 0.47353824913079046d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3553499714999403d,right: 0.9859934998668346d,bottom: 0.17895848638468237d,left: 0.37234902066925013d),

new NpgsqlTypes.NpgsqlBox(top: 0.5768689948753407d,right: 0.5663617335221054d,bottom: 0.4213733506530841d,left: 0.05240994380674069d),

new NpgsqlTypes.NpgsqlBox(top: 0.9155653075107586d,right: 0.7405219322722371d,bottom: 0.6078238472018461d,left: 0.23615631114875668d),

new NpgsqlTypes.NpgsqlBox(top: 0.46914930497444585d,right: 0.9732340337483789d,bottom: 0.04414964377722874d,left: 0.5321988723463545d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22860825201363455d,right: 0.7196883489995183d,bottom: 0.02172820503307693d,left: 0.17933377398548156d),

new NpgsqlTypes.NpgsqlBox(top: 0.9248194276939551d,right: 0.7677366687987595d,bottom: 0.4221559793614065d,left: 0.07424935791004694d),

new NpgsqlTypes.NpgsqlBox(top: 0.5719686741305852d,right: 0.9403797129629131d,bottom: 0.023782270010242357d,left: 0.3079413766559618d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6271054150695997d,right: 0.578321531357631d,bottom: 0.5027048151255566d,left: 0.04289583369267724d),

new NpgsqlTypes.NpgsqlBox(top: 0.7486941528875709d,right: 0.9916339866639623d,bottom: 0.3297700336883409d,left: 0.9884326711988607d),

new NpgsqlTypes.NpgsqlBox(top: 0.8619309724251648d,right: 0.6777679783806859d,bottom: 0.6776371006158143d,left: 0.5754477633781823d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5600919451203952d,right: 0.6811234008722344d,bottom: 0.5128798687171091d,left: 0.5122789503236324d),

new NpgsqlTypes.NpgsqlBox(top: 0.792328449988193d,right: 0.5371252394924729d,bottom: 0.15888852555088429d,left: 0.49134305227892916d),

new NpgsqlTypes.NpgsqlBox(top: 0.800960608661162d,right: 0.8362044131127687d,bottom: 0.7954650985989636d,left: 0.4492063916816662d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6360723241079165d,right: 0.8026018220270731d,bottom: 0.2720129562532322d,left: 0.5151610293720467d),

new NpgsqlTypes.NpgsqlBox(top: 0.8719151415319638d,right: 0.5264414023281455d,bottom: 0.12053132891866347d,left: 0.15872299068547424d),

new NpgsqlTypes.NpgsqlBox(top: 0.4305346898225232d,right: 0.6993514352114986d,bottom: 0.015326240610785913d,left: 0.2954330967857698d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20353352527854973d,right: 0.4774897239719873d,bottom: 0.0879665938231945d,left: 0.4741578289192293d),

new NpgsqlTypes.NpgsqlBox(top: 0.8917811625708325d,right: 0.776977072182954d,bottom: 0.7509528623659895d,left: 0.4237281147765424d),

new NpgsqlTypes.NpgsqlBox(top: 0.7630069889744074d,right: 0.4566031557173498d,bottom: 0.21056920876961183d,left: 0.4275220377283764d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9618749421164199d,right: 0.5778272285637407d,bottom: 0.9527262592184799d,left: 0.418447306455894d),

new NpgsqlTypes.NpgsqlBox(top: 0.6232222433408487d,right: 0.7598329917496426d,bottom: 0.40632118487900415d,left: 0.27387626076435856d),

new NpgsqlTypes.NpgsqlBox(top: 0.9792363469655164d,right: 0.9805846978000468d,bottom: 0.7925552499142025d,left: 0.32208937043494945d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.761619749342663d,right: 0.13845590030073673d,bottom: 0.6839044108631598d,left: 0.12137054343402898d),

new NpgsqlTypes.NpgsqlBox(top: 0.35986293544112513d,right: 0.9757371994372065d,bottom: 0.17440964045424645d,left: 0.5706265762681506d),

new NpgsqlTypes.NpgsqlBox(top: 0.3193400858944191d,right: 0.9990852840739474d,bottom: 0.31271794282121623d,left: 0.1667220785883795d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6969209945132071d,right: 0.8219846738343645d,bottom: 0.06819260345872336d,left: 0.7138181861396536d),

new NpgsqlTypes.NpgsqlBox(top: 0.45468000732807856d,right: 0.5525710008441879d,bottom: 0.14234734287105777d,left: 0.18171683963470375d),

new NpgsqlTypes.NpgsqlBox(top: 0.35008578709406724d,right: 0.7014828942962081d,bottom: 0.2280335854240343d,left: 0.3599765738012207d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.504028824001144d,right: 0.36773411998342864d,bottom: 0.4876916891445058d,left: 0.2513095453496751d),

new NpgsqlTypes.NpgsqlBox(top: 0.7054016639720582d,right: 0.8202117716229516d,bottom: 0.36062441513735166d,left: 0.08950163609505812d),

new NpgsqlTypes.NpgsqlBox(top: 0.9511648827876046d,right: 0.8827867929671094d,bottom: 0.5124328429631295d,left: 0.8380870907863289d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6882018420200668d,right: 0.6489260600331045d,bottom: 0.30956445564981405d,left: 0.34275515949259916d),

new NpgsqlTypes.NpgsqlBox(top: 0.531612733555915d,right: 0.9824734554165251d,bottom: 0.17299224556084758d,left: 0.1398937312264713d),

new NpgsqlTypes.NpgsqlBox(top: 0.608840577801486d,right: 0.7765903525068232d,bottom: 0.504149681109786d,left: 0.553109148293165d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7675721552914073d,right: 0.416998995964608d,bottom: 0.3996185843630371d,left: 0.09720080827484223d),

new NpgsqlTypes.NpgsqlBox(top: 0.9629839340886543d,right: 0.5093695509772241d,bottom: 0.6507095653703427d,left: 0.19734368002231784d),

new NpgsqlTypes.NpgsqlBox(top: 0.7417917986868442d,right: 0.8038359444704783d,bottom: 0.6774706951149302d,left: 0.2881463703148769d),

new NpgsqlTypes.NpgsqlBox(top: 0.8238073893739685d,right: 0.7437313445463828d,bottom: 0.5193008726003405d,left: 0.46002228931882083d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7042588345397287d,right: 0.38437441011959306d,bottom: 0.05546253884775809d,left: 0.039724966961112385d),

new NpgsqlTypes.NpgsqlBox(top: 0.6947396519603241d,right: 0.3412003740534757d,bottom: 0.026677140448447934d,left: 0.03059879363009188d),

new NpgsqlTypes.NpgsqlBox(top: 0.4299160452142424d,right: 0.6775235079485855d,bottom: 0.11542161204578605d,left: 0.4341268298943527d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8362205248947859d,right: 0.8175587970715149d,bottom: 0.6804457746769927d,left: 0.7537566671494195d),

new NpgsqlTypes.NpgsqlBox(top: 0.8137171709449011d,right: 0.7117056026810922d,bottom: 0.24518361633525243d,left: 0.13525777486259405d),

new NpgsqlTypes.NpgsqlBox(top: 0.1810205954017191d,right: 0.037266505263397476d,bottom: 0.032081936413131396d,left: 0.023233799972046332d),

new NpgsqlTypes.NpgsqlBox(top: 0.9164141288717458d,right: 0.9904050691568773d,bottom: 0.11714131964597907d,left: 0.3185221809892894d),

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
new NpgsqlTypes.NpgsqlBox(top: 0.9909115786436188d,right: 0.8170842402064011d,bottom: 0.45446594066475376d,left: 0.07552226540106632d),

new NpgsqlTypes.NpgsqlBox(top: 0.6314761208683987d,right: 0.6610496007432558d,bottom: 0.04175104963531295d,left: 0.06048787885343532d),

new NpgsqlTypes.NpgsqlBox(top: 0.6207557903595244d,right: 0.5790215318004165d,bottom: 0.043407523429943806d,left: 0.13368139197536055d),

new NpgsqlTypes.NpgsqlBox(top: 0.8834675492743413d,right: 0.13585789611017596d,bottom: 0.5943841799663003d,left: 0.11854452006787353d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.10268453994388582d,right: 0.564737839912629d,bottom: 0.06822620048638672d,left: 0.14045725363194905d),

new NpgsqlTypes.NpgsqlBox(top: 0.5989603796798741d,right: 0.320202408755876d,bottom: 0.460861116366728d,left: 0.08531648189019692d),

new NpgsqlTypes.NpgsqlBox(top: 0.62662813132278d,right: 0.8848812284070342d,bottom: 0.4330932748470223d,left: 0.45310538768462827d),

new NpgsqlTypes.NpgsqlBox(top: 0.9221070878456903d,right: 0.25347193399115286d,bottom: 0.5108379897257934d,left: 0.14734486506989908d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.343112146934339d,right: 0.1061730611485997d,bottom: 0.16777749926030827d,left: 0.06415205742364838d),

new NpgsqlTypes.NpgsqlBox(top: 0.6775267285085458d,right: 0.4145496217106194d,bottom: 0.21281102720262424d,left: 0.15374532636224914d),

new NpgsqlTypes.NpgsqlBox(top: 0.3550377080325914d,right: 0.6434902746067178d,bottom: 0.03986603797853128d,left: 0.03308726251289951d),

new NpgsqlTypes.NpgsqlBox(top: 0.7499690211347427d,right: 0.552671787406474d,bottom: 0.392561418224576d,left: 0.36635251356321874d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7778785738668166d,right: 0.9582267649954141d,bottom: 0.2854368515709028d,left: 0.37311931889256844d),

new NpgsqlTypes.NpgsqlBox(top: 0.43271290806317797d,right: 0.46101262238009244d,bottom: 0.2276744232300828d,left: 0.13524791063383268d),

new NpgsqlTypes.NpgsqlBox(top: 0.6995140237038987d,right: 0.533279629479561d,bottom: 0.05068181930009097d,left: 0.032382324902922255d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9084843890629236d,right: 0.468670492069982d,bottom: 0.25006186520718954d,left: 0.1821903932671195d),

new NpgsqlTypes.NpgsqlBox(top: 0.3421440716638595d,right: 0.349897214503919d,bottom: 0.19551327725889522d,left: 0.01599373950147831d),

new NpgsqlTypes.NpgsqlBox(top: 0.3714932891916153d,right: 0.3693035464645953d,bottom: 0.10005465030171534d,left: 0.14034353487966356d),

new NpgsqlTypes.NpgsqlBox(top: 0.9267627719157057d,right: 0.10597623270454493d,bottom: 0.8500736080187902d,left: 0.059738322784702036d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4550726777035533d,right: 0.9031981303899344d,bottom: 0.10512224415624072d,left: 0.5039006587259579d),

new NpgsqlTypes.NpgsqlBox(top: 0.5716762129569901d,right: 0.9823162245252527d,bottom: 0.16451391157085815d,left: 0.8484297145078085d),

new NpgsqlTypes.NpgsqlBox(top: 0.5318341640058122d,right: 0.2670577984234631d,bottom: 0.2227031445137153d,left: 0.1661076806530981d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.26249237287600713d,right: 0.4751734705615712d,bottom: 0.20753030965928332d,left: 0.20413628324769229d),

new NpgsqlTypes.NpgsqlBox(top: 0.6846695635764322d,right: 0.8257180864703167d,bottom: 0.3257926269517767d,left: 0.22751077551121057d),

new NpgsqlTypes.NpgsqlBox(top: 0.991176140569292d,right: 0.7035872938790109d,bottom: 0.2948477804408809d,left: 0.3323121594306916d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.873427122921311d,right: 0.2235650165409625d,bottom: 0.6824908929108527d,left: 0.03704150330315403d),

new NpgsqlTypes.NpgsqlBox(top: 0.8606359802709862d,right: 0.8791675579738949d,bottom: 0.77691952778869d,left: 0.8573422910099556d),

new NpgsqlTypes.NpgsqlBox(top: 0.40357358992879266d,right: 0.8828498475725908d,bottom: 0.1579922659820946d,left: 0.08541959901399643d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.45211498346681955d,right: 0.896178644178427d,bottom: 0.1913418621259566d,left: 0.3399006445572499d),

new NpgsqlTypes.NpgsqlBox(top: 0.7767481563087859d,right: 0.8295568681398928d,bottom: 0.005583953862064783d,left: 0.7956561564487916d),

new NpgsqlTypes.NpgsqlBox(top: 0.41653360982795595d,right: 0.7740715479300594d,bottom: 0.3384230649708342d,left: 0.3520907753191862d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8214010924028085d,right: 0.6563561806485815d,bottom: 0.6671273885206451d,left: 0.25129064634143294d),

new NpgsqlTypes.NpgsqlBox(top: 0.5034096734496912d,right: 0.756439415829912d,bottom: 0.35272742464322926d,left: 0.2226112926994852d),

new NpgsqlTypes.NpgsqlBox(top: 0.8175643909993116d,right: 0.5787157745591516d,bottom: 0.3437128426945786d,left: 0.35712796995951357d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7854401865326135d,right: 0.9612040633043245d,bottom: 0.24288686383508096d,left: 0.2182673126999768d),

new NpgsqlTypes.NpgsqlBox(top: 0.6593586546089684d,right: 0.9035398585498047d,bottom: 0.37524560167134124d,left: 0.3766272531780849d),

new NpgsqlTypes.NpgsqlBox(top: 0.2890390264600091d,right: 0.49406288424233824d,bottom: 0.22405900774088217d,left: 0.43533584022472893d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.23877740959160065d,right: 0.8952241815335685d,bottom: 0.004453340436854303d,left: 0.11250594621445009d),

new NpgsqlTypes.NpgsqlBox(top: 0.44146556039291396d,right: 0.7663556896078769d,bottom: 0.17462375557090049d,left: 0.5243920301745157d),

new NpgsqlTypes.NpgsqlBox(top: 0.8477118201506523d,right: 0.8771931439016645d,bottom: 0.26492170870500265d,left: 0.3725356734614985d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8829664288009942d,right: 0.9507117357612298d,bottom: 0.4908372888977969d,left: 0.11900895862150973d),

new NpgsqlTypes.NpgsqlBox(top: 0.8867878760356868d,right: 0.19287269009729868d,bottom: 0.26398746821228614d,left: 0.05677177465904715d),

new NpgsqlTypes.NpgsqlBox(top: 0.14278238325204518d,right: 0.6234222942233538d,bottom: 0.05255508944890175d,left: 0.1195777123599987d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8146539331373023d,right: 0.9134256470498259d,bottom: 0.1765295701679821d,left: 0.17681493908234214d),

new NpgsqlTypes.NpgsqlBox(top: 0.6926652381325829d,right: 0.9023102791823101d,bottom: 0.6510644621367893d,left: 0.2654620137833965d),

new NpgsqlTypes.NpgsqlBox(top: 0.7432069120127035d,right: 0.6348864919784681d,bottom: 0.29315481450721037d,left: 0.09045775004091627d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9332388920975121d,right: 0.42097723032326806d,bottom: 0.43913656810736357d,left: 0.3299519993452079d),

new NpgsqlTypes.NpgsqlBox(top: 0.5779100998872866d,right: 0.5393664455543188d,bottom: 0.47035833246830383d,left: 0.44334111466854076d),

new NpgsqlTypes.NpgsqlBox(top: 0.3352194547314189d,right: 0.39216660585481233d,bottom: 0.007251660590182563d,left: 0.29311561137867626d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9285766755832162d,right: 0.5372061931820912d,bottom: 0.19918244350221181d,left: 0.007724808000470373d),

new NpgsqlTypes.NpgsqlBox(top: 0.4129956868730169d,right: 0.6254841170688473d,bottom: 0.2848124752087824d,left: 0.2918447989901545d),

new NpgsqlTypes.NpgsqlBox(top: 0.25596143128255755d,right: 0.48756540698212225d,bottom: 0.18290172898105916d,left: 0.2605163165040716d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9788641568586484d,right: 0.28155291437825214d,bottom: 0.7398896223344041d,left: 0.03537214228107255d),

new NpgsqlTypes.NpgsqlBox(top: 0.8240512221572733d,right: 0.8636395369252083d,bottom: 0.610854665652627d,left: 0.25816433549969453d),

new NpgsqlTypes.NpgsqlBox(top: 0.7675948176689633d,right: 0.7737290520746254d,bottom: 0.43226395294499265d,left: 0.5046684397549434d),

new NpgsqlTypes.NpgsqlBox(top: 0.7769375735556407d,right: 0.663499295707236d,bottom: 0.31407160024565206d,left: 0.6095096176902294d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.28019260001210256d,right: 0.6704466385453469d,bottom: 0.27629981537284753d,left: 0.23014132596393744d),

new NpgsqlTypes.NpgsqlBox(top: 0.51642894986868d,right: 0.3379172175794881d,bottom: 0.37070333080753426d,left: 0.2335801638583631d),

new NpgsqlTypes.NpgsqlBox(top: 0.39267450523888847d,right: 0.7000073697931863d,bottom: 0.09806207773991793d,left: 0.13786467172695926d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4867081157538139d,right: 0.898903083576183d,bottom: 0.2137664865466995d,left: 0.25386365276838285d),

new NpgsqlTypes.NpgsqlBox(top: 0.8342688851343559d,right: 0.9495673899940966d,bottom: 0.4817876384965806d,left: 0.8452931791579821d),

new NpgsqlTypes.NpgsqlBox(top: 0.6426475090432177d,right: 0.70260945826715d,bottom: 0.09591413152956962d,left: 0.19173372810366363d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7130382451050644d,right: 0.48644190726696157d,bottom: 0.6477738254218006d,left: 0.24536015124486144d),

new NpgsqlTypes.NpgsqlBox(top: 0.6454605557241793d,right: 0.48173062167044944d,bottom: 0.39105218917219264d,left: 0.18582409600186656d),

new NpgsqlTypes.NpgsqlBox(top: 0.8287820988859635d,right: 0.632780061278961d,bottom: 0.20476822646286674d,left: 0.5072059443549853d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.23247980671132795d,right: 0.7766100375969132d,bottom: 0.17354021038124579d,left: 0.05407786367842893d),

new NpgsqlTypes.NpgsqlBox(top: 0.44658366550506223d,right: 0.9568728723729216d,bottom: 0.14288788392104257d,left: 0.052936711912975554d),

new NpgsqlTypes.NpgsqlBox(top: 0.7779903590491478d,right: 0.6549308736649413d,bottom: 0.08448285591478832d,left: 0.5614589360938518d),

new NpgsqlTypes.NpgsqlBox(top: 0.33732285470401036d,right: 0.12928906783006677d,bottom: 0.3030036504710464d,left: 0.05390750217389062d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5140687017781744d,right: 0.8333956304071675d,bottom: 0.1943583768050582d,left: 0.5258491860971446d),

new NpgsqlTypes.NpgsqlBox(top: 0.5375977323525194d,right: 0.4596652553312113d,bottom: 0.21745906124216274d,left: 0.4319501327608939d),

new NpgsqlTypes.NpgsqlBox(top: 0.653302149665875d,right: 0.9183501931715038d,bottom: 0.56163300745257d,left: 0.4702683901239698d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.295282132592535d,right: 0.8406022257278417d,bottom: 0.006931853636896301d,left: 0.7587952907943505d),

new NpgsqlTypes.NpgsqlBox(top: 0.7640941952940069d,right: 0.3383443378921832d,bottom: 0.5596657215941834d,left: 0.33652160466479697d),

new NpgsqlTypes.NpgsqlBox(top: 0.8889908870154892d,right: 0.622505707423044d,bottom: 0.5587418664303504d,left: 0.07631792733899989d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8187257571325517d,right: 0.9829168552321852d,bottom: 0.1636814079001342d,left: 0.5896472547648501d),

new NpgsqlTypes.NpgsqlBox(top: 0.8783169781347626d,right: 0.5186052796169768d,bottom: 0.5478644362588744d,left: 0.5030423865982405d),

new NpgsqlTypes.NpgsqlBox(top: 0.5001687348004442d,right: 0.6182064944611514d,bottom: 0.35652567583835093d,left: 0.6134930986663412d),

new NpgsqlTypes.NpgsqlBox(top: 0.858696843131757d,right: 0.47258261465593576d,bottom: 0.648101279368518d,left: 0.4083104460417034d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3805500604919829d,right: 0.4749769326038461d,bottom: 0.028258153936216224d,left: 0.465607176036991d),

new NpgsqlTypes.NpgsqlBox(top: 0.5057693774800452d,right: 0.6235335332440061d,bottom: 0.10101376693356723d,left: 0.26773980270960684d),

new NpgsqlTypes.NpgsqlBox(top: 0.9413551167236538d,right: 0.6173682367797333d,bottom: 0.8060863456627444d,left: 0.3350582967335295d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6220811863110306d,right: 0.8378368060881746d,bottom: 0.5893143674098118d,left: 0.5004448708426908d),

new NpgsqlTypes.NpgsqlBox(top: 0.8296270404511791d,right: 0.7864626276970184d,bottom: 0.5582470555924598d,left: 0.2701688315954659d),

new NpgsqlTypes.NpgsqlBox(top: 0.6189486806753762d,right: 0.48914063032426147d,bottom: 0.49054188997141235d,left: 0.014591058571334248d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9337847375020567d,right: 0.2070435726242239d,bottom: 0.5093411016871835d,left: 0.12734690519923453d),

new NpgsqlTypes.NpgsqlBox(top: 0.4130123930778248d,right: 0.6877793663336393d,bottom: 0.22134621698269907d,left: 0.617888642581435d),

new NpgsqlTypes.NpgsqlBox(top: 0.750807379095979d,right: 0.595798624248374d,bottom: 0.6222815295259229d,left: 0.1940318802533496d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9615802566611256d,right: 0.9800948626203178d,bottom: 0.04552505543758634d,left: 0.10687068078004835d),

new NpgsqlTypes.NpgsqlBox(top: 0.9986782455299587d,right: 0.32864948503562263d,bottom: 0.4844278417332467d,left: 0.1549373452873125d),

new NpgsqlTypes.NpgsqlBox(top: 0.8572924663446857d,right: 0.29831169964839177d,bottom: 0.5114680201021453d,left: 0.0307187379363576d),

new NpgsqlTypes.NpgsqlBox(top: 0.8863322029551148d,right: 0.7583608630649172d,bottom: 0.2922345973915019d,left: 0.5581533682680148d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8134346136647604d,right: 0.4478648337861929d,bottom: 0.06366490812158332d,left: 0.44416965646286133d),

new NpgsqlTypes.NpgsqlBox(top: 0.5190905169803525d,right: 0.5354388882601874d,bottom: 0.17721769007508015d,left: 0.49585886394093737d),

new NpgsqlTypes.NpgsqlBox(top: 0.33300216822169904d,right: 0.9366507900623983d,bottom: 0.24450947652370092d,left: 0.7793255581562615d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9038686656311842d,right: 0.8717311741300979d,bottom: 0.8983511515151391d,left: 0.8364219254094116d),

new NpgsqlTypes.NpgsqlBox(top: 0.49488843928498627d,right: 0.6258453584980387d,bottom: 0.1304822810709667d,left: 0.3417156802666871d),

new NpgsqlTypes.NpgsqlBox(top: 0.7574131284787878d,right: 0.9740305139073802d,bottom: 0.7447931878602887d,left: 0.07780186668007538d),

new NpgsqlTypes.NpgsqlBox(top: 0.4069210692623525d,right: 0.8391748863788673d,bottom: 0.03930299158344208d,left: 0.4810694085422976d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7389487214871974d,right: 0.9315563864878512d,bottom: 0.13675742848707473d,left: 0.821030317732711d),

new NpgsqlTypes.NpgsqlBox(top: 0.6449158143595978d,right: 0.950241002591788d,bottom: 0.5355415376441677d,left: 0.029221035740082613d),

new NpgsqlTypes.NpgsqlBox(top: 0.6125460735032537d,right: 0.2727651193959941d,bottom: 0.0014937291884662418d,left: 0.006787071283273272d),

new NpgsqlTypes.NpgsqlBox(top: 0.3036267921003969d,right: 0.8767420389200575d,bottom: 0.23551738611319606d,left: 0.709071081860274d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6882540634874891d,right: 0.4932603745597024d,bottom: 0.3490063650609211d,left: 0.07413187969818025d),

new NpgsqlTypes.NpgsqlBox(top: 0.554756335289078d,right: 0.7097707112067554d,bottom: 0.041297335096769694d,left: 0.13083566058759588d),

new NpgsqlTypes.NpgsqlBox(top: 0.5798075970168697d,right: 0.4986913638777958d,bottom: 0.08328669369927177d,left: 0.16854237107300518d),

new NpgsqlTypes.NpgsqlBox(top: 0.9052716641765696d,right: 0.823630758343168d,bottom: 0.29740141249147756d,left: 0.27569203947236154d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.27060216239902746d,right: 0.656452738386842d,bottom: 0.21468303127527022d,left: 0.42965036026892767d),

new NpgsqlTypes.NpgsqlBox(top: 0.8351541666241395d,right: 0.4324438151099934d,bottom: 0.3398258626841998d,left: 0.19332720834320793d),

new NpgsqlTypes.NpgsqlBox(top: 0.8807877772882221d,right: 0.4676249856565986d,bottom: 0.1509066257022773d,left: 0.12220806403329476d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9737468095959514d,right: 0.2906694690303139d,bottom: 0.8943120319186868d,left: 0.09449912976845398d),

new NpgsqlTypes.NpgsqlBox(top: 0.46247578577097725d,right: 0.3284414807857784d,bottom: 0.10112170600223447d,left: 0.07915541467687182d),

new NpgsqlTypes.NpgsqlBox(top: 0.5708719970836628d,right: 0.2561900178065627d,bottom: 0.25461705014296254d,left: 0.18857781596301493d),

new NpgsqlTypes.NpgsqlBox(top: 0.5204037173293896d,right: 0.7507079876507416d,bottom: 0.021955232264286417d,left: 0.36375519136235557d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6754797172871116d,right: 0.6388978964313812d,bottom: 0.5375165719549915d,left: 0.3959591193657326d),

new NpgsqlTypes.NpgsqlBox(top: 0.43098018376025415d,right: 0.8838586578368901d,bottom: 0.2171548058563565d,left: 0.8181652788436169d),

new NpgsqlTypes.NpgsqlBox(top: 0.5073909034830719d,right: 0.9141380931881262d,bottom: 0.1823824826852759d,left: 0.22177694175788876d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4147815868744176d,right: 0.8839013938215987d,bottom: 0.3768965843629868d,left: 0.18460836768298317d),

new NpgsqlTypes.NpgsqlBox(top: 0.7000572392779745d,right: 0.5372420482330214d,bottom: 0.6612490991246761d,left: 0.3860841550780695d),

new NpgsqlTypes.NpgsqlBox(top: 0.6338896395572383d,right: 0.8077693944397035d,bottom: 0.354627257220826d,left: 0.759113019183444d),

},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 167, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 3, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 46, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 75, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 56, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 124, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 8, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[34], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI), typeof(NpgsqlBoxboxArray2MI)],
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                await ((INpgsqlBoxListboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                ((INpgsqlBoxListboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
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
                var models = await ((INpgsqlBoxListboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
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

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

