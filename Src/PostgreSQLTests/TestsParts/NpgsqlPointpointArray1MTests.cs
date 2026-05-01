

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
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08240837606596096d, y: 0.47100038123941035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7825012015274058d, y: 0.06008880082937118d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7425333538016577d, y: 0.6923981773251783d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7439582789044581d, y: 0.19361372912391606d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21366575262502085d, y: 0.5911924490798063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36399623835731d, y: 0.22095304892787948d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5426920112244793d, y: 0.5555898707675162d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5301579741578538d, y: 0.9556272381544665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2780836768766487d, y: 0.5412465571114922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6610821091013444d, y: 0.027151801476707038d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7242233691858065d, y: 0.0674596212677282d),
new NpgsqlTypes.NpgsqlPoint(x: 0.013145541143479877d, y: 0.3263211316844957d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7904026759626569d, y: 0.8149780711648807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5022692322277597d, y: 0.020226956242511696d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1259581550820349d, y: 0.8238672072062025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2361241865313144d, y: 0.023543060204128108d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5556566409390511d, y: 0.24654594510217853d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19701204454196708d, y: 0.6525356257222562d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1710155746288633d, y: 0.64016797351497d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9007807032749533d, y: 0.1680038107296311d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18357405852521147d, y: 0.5110272290067079d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5553235351614032d, y: 0.7154803300939578d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5800592095027836d, y: 0.504505572964809d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39030446068616276d, y: 0.18844189604714645d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42051622697304925d, y: 0.5970665225647794d),
new NpgsqlTypes.NpgsqlPoint(x: 0.010548585014146239d, y: 0.5628815279940603d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27276429745516917d, y: 0.554523508648524d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6426107679903365d, y: 0.20547955711011934d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6902516764010761d, y: 0.25870734536058027d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8459667054301406d, y: 0.8302113798422202d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.991590439599574d, y: 0.2825471791888091d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7057416227544322d, y: 0.967800568795293d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16057879440426037d, y: 0.5445202036622365d),
new NpgsqlTypes.NpgsqlPoint(x: 0.668136754095193d, y: 0.06593986338558933d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6221805967878741d, y: 0.7233264373806765d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5943624272833383d, y: 0.0127196530230399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4516583273052357d, y: 0.19512645894430347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37223510920981673d, y: 0.6942010983405297d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9770703409759006d, y: 0.575774862834375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03437122863905118d, y: 0.6810828302852988d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38133179561925734d, y: 0.5590984338087687d),
new NpgsqlTypes.NpgsqlPoint(x: 0.936230855076158d, y: 0.9086115714338189d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4278036774462338d, y: 0.4817599649241926d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24343500292142084d, y: 0.383730924594996d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6510595175119803d, y: 0.26914113650442417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12043181617463594d, y: 0.4579019930659154d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.023729725360031928d, y: 0.2741503435022856d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5106566644291082d, y: 0.7401833694000374d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34537362350045475d, y: 0.013672261509510286d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14572027448046476d, y: 0.31980226121760247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.908038533131546d, y: 0.19811669066770887d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4026896373531682d, y: 0.2940993795373118d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8314588288066004d, y: 0.1137113921573144d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7237064565303616d, y: 0.8058637706328263d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12692787930339844d, y: 0.1688951665809345d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7132181782584537d, y: 0.07559319607535453d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0849155702861899d, y: 0.32290163856570986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14227169433272324d, y: 0.1151463305991638d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9437645391713001d, y: 0.2842762003296164d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47622447430439885d, y: 0.2692204847417574d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43953488667884844d, y: 0.8932150178733151d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07586249316279259d, y: 0.9093772068120876d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8581749979976669d, y: 0.009743121194482729d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9043432606125578d, y: 0.9753453136405061d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46349386246730395d, y: 0.5054851254025511d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9016437734331508d, y: 0.267527760275701d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03478657830953569d, y: 0.6465479978571678d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7059912946464233d, y: 0.030631603500315907d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42320724358336603d, y: 0.37140807343452076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5340081347868985d, y: 0.22770753151782086d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.006834316862298739d, y: 0.22509755123474584d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19028893344833708d, y: 0.019653765276372304d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16324290990476809d, y: 0.5209916355588703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8646222070199803d, y: 0.1603410274261171d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39528820657229735d, y: 0.4442249209375799d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7112785463188607d, y: 0.7414377119673679d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24370121337510786d, y: 0.13378559962900782d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5202571567934058d, y: 0.6431578485298308d),
new NpgsqlTypes.NpgsqlPoint(x: 0.006656187227900068d, y: 0.9789087196602297d),
new NpgsqlTypes.NpgsqlPoint(x: 0.016621078487665142d, y: 0.4900508334974605d),
new NpgsqlTypes.NpgsqlPoint(x: 0.423331363812642d, y: 0.21932636817227946d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7389759221657309d, y: 0.1265738694297237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.672296859947549d, y: 0.07358411694997624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09139915908886831d, y: 0.2432370505599344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3819070708437391d, y: 0.18153068504553516d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6930111133713088d, y: 0.04780094964033388d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6836023797179591d, y: 0.16225112145084808d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6727503504172715d, y: 0.14526586281963916d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4799381863540727d, y: 0.43671738350716083d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5695720287238518d, y: 0.7913749816072018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10438931369464277d, y: 0.22414636469375693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8800485429709943d, y: 0.7534659191366645d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40381755814281495d, y: 0.43185386344905263d),
new NpgsqlTypes.NpgsqlPoint(x: 0.428896459641538d, y: 0.13092244201390912d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47497959859567984d, y: 0.8837063669806797d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14829194119852707d, y: 0.06049463196706317d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45010354278038844d, y: 0.8090239469860088d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6855637343142545d, y: 0.7430705921029391d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09980969016196584d, y: 0.7382442436247971d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3589117984565282d, y: 0.9007629734845789d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7484938294380526d, y: 0.7783699888918811d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49001478399132226d, y: 0.5666549596528755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9497069708582389d, y: 0.718998467135353d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8596579653701388d, y: 0.8043184079274113d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4859321789230515d, y: 0.9298514827830671d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6617838270389642d, y: 0.9729071540794278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30451198410373614d, y: 0.37347373139334794d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8596087742466816d, y: 0.3483880392173502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8034010254291387d, y: 0.10195671880777557d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46397772685461736d, y: 0.6712380444093773d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28336759401641565d, y: 0.7816661479355587d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10065576057312631d, y: 0.23508781140338508d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8118673901575189d, y: 0.6736802527916754d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4485772558951342d, y: 0.052955937126488606d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2710091289232821d, y: 0.8661815535867899d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5694820281753508d, y: 0.9545364303668507d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8278461735891618d, y: 0.5730443316041416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9411780136030238d, y: 0.30372186307151394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9662686473842472d, y: 0.8662472470795015d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20692706916878578d, y: 0.859235703629647d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20903727156079965d, y: 0.10526546855335628d),
new NpgsqlTypes.NpgsqlPoint(x: 0.020382325346404495d, y: 0.21464400444745058d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07777527313700439d, y: 0.1317070760266108d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4041729171282513d, y: 0.586999809700118d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8644704995262894d, y: 0.4890831897679949d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5655871003745039d, y: 0.7138987151988895d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1784400664105501d, y: 0.1900238879817705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10543750613717406d, y: 0.8367496777690785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.787983764205112d, y: 0.9994407075135266d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1251235993594363d, y: 0.4403540044695634d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4861194894059886d, y: 0.6617202987164027d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3566276961931303d, y: 0.692765211769547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8760998034288011d, y: 0.2570917729477874d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48706304111652576d, y: 0.4278967521530028d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6380294376464866d, y: 0.2772269371640841d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7069118280173551d, y: 0.9300003377870949d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8477240445020066d, y: 0.3484965131695381d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5559585499734255d, y: 0.31077427990885853d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8585314580753011d, y: 0.6679095452472659d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6007493162856852d, y: 0.9605074033810939d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3926185195165792d, y: 0.4960991552758026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5848348492484043d, y: 0.530865237533445d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7861630137339108d, y: 0.9566708208675521d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16783837531180068d, y: 0.5040836159982189d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30584957300522586d, y: 0.7885990487370577d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20442841128399303d, y: 0.009672786360620744d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49544698645153695d, y: 0.11131057054983573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7312246311439486d, y: 0.734550088480957d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5121659175694322d, y: 0.15491053897598162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6531605195428026d, y: 0.4734036205193578d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20367739278128694d, y: 0.6787178885038616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5431460543312268d, y: 0.8553869506107247d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7718810998032402d, y: 0.32065584661530977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02626895485447356d, y: 0.9202469593799216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7659990614534945d, y: 0.6055182972058069d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9548082107167201d, y: 0.8035583770727213d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40962275326020336d, y: 0.9792882573586892d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9551908706592673d, y: 0.12797868491536046d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8289761673012027d, y: 0.8065332290108655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4301525418767994d, y: 0.00613002853878164d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7844434124165796d, y: 0.07602231003576365d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19637305342495526d, y: 0.9789906726389747d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6600997352900204d, y: 0.6050852730265442d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6795992458438466d, y: 0.7984996254425998d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9440918951434317d, y: 0.6784403728177028d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46668528268148235d, y: 0.569071729373581d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8073620865208151d, y: 0.11442744132531124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5992978673932519d, y: 0.20109581381062525d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5430899372253202d, y: 0.11012392928338766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1095353070169609d, y: 0.0688595019594953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7746332077303962d, y: 0.20225533340976742d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7260640426559778d, y: 0.6618384887403475d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7027566993707334d, y: 0.9396033675360924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.01182548484892798d, y: 0.887464723931433d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28411686541462d, y: 0.10379003880308513d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2992584425245145d, y: 0.9790781828568065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.95551599700422d, y: 0.1644373983303985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3869678250889793d, y: 0.793793680931107d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46503071416492825d, y: 0.8889196055710533d),
new NpgsqlTypes.NpgsqlPoint(x: 0.010898191202079688d, y: 0.6721568928001689d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5308902727797071d, y: 0.5165185752611868d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9178504147946993d, y: 0.143916700765662d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3714441398825107d, y: 0.5997723792635951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4695911764433379d, y: 0.7814811701274974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29006449247440735d, y: 0.9060906461412589d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2500993815148248d, y: 0.24907913058564146d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1389404480113443d, y: 0.6738430556725808d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3338310839789469d, y: 0.703189244973184d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9680799085595774d, y: 0.9129672106666703d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08193411672006423d, y: 0.1917712023248359d),
new NpgsqlTypes.NpgsqlPoint(x: 0.494584616415207d, y: 0.45539096913741706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7940246852787931d, y: 0.5808357549181805d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24842528622311366d, y: 0.2428194021212755d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34254914372638057d, y: 0.9791066258015216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9365347631386023d, y: 0.5446112749545113d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1881315715615226d, y: 0.5722207251738572d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09882752877671463d, y: 0.3978054532425922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5984795402642957d, y: 0.41452404446482416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0872897085153177d, y: 0.07978282593309627d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30915477667316815d, y: 0.7766607173908292d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8079098524638398d, y: 0.6335085210697091d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6230483407290851d, y: 0.7932960536527722d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44469804675098157d, y: 0.1288387359143074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9264165754809472d, y: 0.027470179928885008d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29009655862257633d, y: 0.23847260585681107d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5350279421394547d, y: 0.10464078256433851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8725742475027178d, y: 0.825746761137513d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7265643615024326d, y: 0.7252630708913436d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7987752787501453d, y: 0.7092580770429326d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12623762086842794d, y: 0.03402243005519012d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7874966404429273d, y: 0.6423641065184698d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2195942258364324d, y: 0.7025589528260693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5060681734957746d, y: 0.32893189691396696d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4882484716306341d, y: 0.7298986871782445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7989348250923387d, y: 0.5535007912764082d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7328935950977082d, y: 0.17865608262985067d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6128349762623501d, y: 0.8789756640031239d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2955474525427205d, y: 0.6223013705357257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3998232357814361d, y: 0.7358968645989039d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8579706730839004d, y: 0.25248073283385086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7149456255895167d, y: 0.7983702550276418d),
new NpgsqlTypes.NpgsqlPoint(x: 0.906030453286067d, y: 0.5705637413010219d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7025634457342687d, y: 0.6131882121561276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8892530838023717d, y: 0.956507791236282d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7234500344646418d, y: 0.8986879561613399d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1252477997879058d, y: 0.47082768286242893d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6583356751755547d, y: 0.5291726385561032d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14856305390268465d, y: 0.04846363186310021d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17543441069901833d, y: 0.861144962752157d),
new NpgsqlTypes.NpgsqlPoint(x: 0.585586743175964d, y: 0.2443689270598145d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4647444021418684d, y: 0.3326416616684531d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8161561308256247d, y: 0.028612012725030778d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46780779887542856d, y: 0.3167757290459289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4832085672713835d, y: 0.6706523348272408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6960045741286036d, y: 0.46446624556858884d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8371339680380436d, y: 0.4368478354805091d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2527057405587676d, y: 0.12220986637781317d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49541642768141214d, y: 0.24259497469703284d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7259573764289913d, y: 0.7699059760013154d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5902538936691113d, y: 0.971357576827616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2392234406035103d, y: 0.8050146351843337d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.510922328355813d, y: 0.5127826356379367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27828843797969893d, y: 0.6325365243142557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47484523428160075d, y: 0.1685420865835019d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09097690282567172d, y: 0.8818924500917882d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17515682853396597d, y: 0.8852688221748498d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34867714440636066d, y: 0.16955925536783645d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6849394628970046d, y: 0.37046673320818924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49630749758010384d, y: 0.36793110566531917d),
new NpgsqlTypes.NpgsqlPoint(x: 0.890994505284537d, y: 0.18558028374499203d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8149544419244144d, y: 0.4378271712104099d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3787122725957266d, y: 0.9961117349682566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39150531836500013d, y: 0.7789398791066766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2531222453106706d, y: 0.8986410824997942d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8157617901034362d, y: 0.03693401087259873d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33388302643666934d, y: 0.6118837412881273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4555967450207469d, y: 0.860926916356852d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7550615294526306d, y: 0.12403757054686892d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8373733241242027d, y: 0.881081817221989d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8670928668335869d, y: 0.5925808310209668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07624315639554058d, y: 0.9008022758335005d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28971425099947845d, y: 0.6328609768607332d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7699510259197928d, y: 0.19709035562659305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23352039854336193d, y: 0.6983514586305801d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2123239078678486d, y: 0.013313059052404097d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5058723291094944d, y: 0.14692629984165761d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3602169896660069d, y: 0.45568120492871933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49576126051742164d, y: 0.6298371269315891d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9420740970110536d, y: 0.35901232218077617d),
},
    ModelInner = null,
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.991590439599574d, y: 0.2825471791888091d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7057416227544322d, y: 0.967800568795293d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16057879440426037d, y: 0.5445202036622365d),
new NpgsqlTypes.NpgsqlPoint(x: 0.668136754095193d, y: 0.06593986338558933d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4278036774462338d, y: 0.4817599649241926d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24343500292142084d, y: 0.383730924594996d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6510595175119803d, y: 0.26914113650442417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12043181617463594d, y: 0.4579019930659154d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14572027448046476d, y: 0.31980226121760247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.908038533131546d, y: 0.19811669066770887d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4026896373531682d, y: 0.2940993795373118d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47622447430439885d, y: 0.2692204847417574d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43953488667884844d, y: 0.8932150178733151d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07586249316279259d, y: 0.9093772068120876d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8581749979976669d, y: 0.009743121194482729d),
}));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39528820657229735d, y: 0.4442249209375799d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7112785463188607d, y: 0.7414377119673679d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24370121337510786d, y: 0.13378559962900782d),
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5695720287238518d, y: 0.7913749816072018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10438931369464277d, y: 0.22414636469375693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8800485429709943d, y: 0.7534659191366645d),
}));
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
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 107, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 96, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 12, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 109, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 139, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[34], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[32], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[33], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPointpointArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI), typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                await ((INpgsqlPointArraypointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                ((INpgsqlPointArraypointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointArraypointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

