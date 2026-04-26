

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7903027747690646d,right: 0.7397243630918665d,bottom: 0.15309087171811242d,left: 0.5333742092218972d),

new NpgsqlTypes.NpgsqlBox(top: 0.1560535347796641d,right: 0.7451034695605108d,bottom: 0.08304106037016545d,left: 0.2918457768996462d),

new NpgsqlTypes.NpgsqlBox(top: 0.42910948628045065d,right: 0.7143556532759671d,bottom: 0.06930366420960887d,left: 0.32932082403320706d),

new NpgsqlTypes.NpgsqlBox(top: 0.7143821390284502d,right: 0.8675704036265988d,bottom: 0.07697109910187361d,left: 0.5360550037574201d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7627678921935908d,right: 0.4755344050848258d,bottom: 0.16752045864829668d,left: 0.15512591970824274d),

new NpgsqlTypes.NpgsqlBox(top: 0.826872683769392d,right: 0.7443825877987933d,bottom: 0.6853665685013537d,left: 0.12949954352913073d),

new NpgsqlTypes.NpgsqlBox(top: 0.9224477257416197d,right: 0.785359337811332d,bottom: 0.23750329759020583d,left: 0.7161252246405252d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.578715501529606d,right: 0.9959673162942266d,bottom: 0.5493201702158508d,left: 0.799204638512516d),

new NpgsqlTypes.NpgsqlBox(top: 0.6917069686670461d,right: 0.03295938802220466d,bottom: 0.09319391730098425d,left: 0.005051444264707494d),

new NpgsqlTypes.NpgsqlBox(top: 0.43100241463688427d,right: 0.949829201693852d,bottom: 0.35291636626057443d,left: 0.2770162446972466d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8268637146265096d,right: 0.3020582944807819d,bottom: 0.605997266230551d,left: 0.26122653688378916d),

new NpgsqlTypes.NpgsqlBox(top: 0.8311670472357625d,right: 0.888130536817397d,bottom: 0.2711583581575746d,left: 0.05129526989939859d),

new NpgsqlTypes.NpgsqlBox(top: 0.6130845162046706d,right: 0.5851469859055686d,bottom: 0.11850174292974092d,left: 0.4639392238830472d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7503143129848431d,right: 0.20735300248991506d,bottom: 0.6393627922122296d,left: 0.07729244870915808d),

new NpgsqlTypes.NpgsqlBox(top: 0.3333825226573959d,right: 0.7298366991332564d,bottom: 0.32492641722830373d,left: 0.17929085710771597d),

new NpgsqlTypes.NpgsqlBox(top: 0.36541004401368005d,right: 0.6668176836537134d,bottom: 0.32842300691407866d,left: 0.14837769688814473d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.402413508495157d,right: 0.972829970508183d,bottom: 0.344849321787174d,left: 0.5099430401057877d),

new NpgsqlTypes.NpgsqlBox(top: 0.9184983065240038d,right: 0.3241453892020769d,bottom: 0.3146920771934276d,left: 0.11473346957332631d),

new NpgsqlTypes.NpgsqlBox(top: 0.18632870009052827d,right: 0.7559025189812354d,bottom: 0.07699176278418696d,left: 0.27008594826727084d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6464788466491661d,right: 0.7025471564753908d,bottom: 0.1697095297601715d,left: 0.26435042614423365d),

new NpgsqlTypes.NpgsqlBox(top: 0.7873878445073563d,right: 0.6051923119684836d,bottom: 0.2709346254498842d,left: 0.31561891845945933d),

new NpgsqlTypes.NpgsqlBox(top: 0.7218985015407d,right: 0.6508022521261461d,bottom: 0.6804840391613465d,left: 0.0849975849766722d),

new NpgsqlTypes.NpgsqlBox(top: 0.6335801150477288d,right: 0.9948024380933509d,bottom: 0.4357333753823781d,left: 0.3444319863702865d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4780704026690842d,right: 0.9757487851204079d,bottom: 0.1801518082654313d,left: 0.4675822987266809d),

new NpgsqlTypes.NpgsqlBox(top: 0.7364655710914233d,right: 0.6576741272318961d,bottom: 0.1556350805457164d,left: 0.24836729572341743d),

new NpgsqlTypes.NpgsqlBox(top: 0.41969300597231496d,right: 0.9812902871242606d,bottom: 0.23845479923416335d,left: 0.7149975584683282d),

new NpgsqlTypes.NpgsqlBox(top: 0.8586836226843019d,right: 0.8466417727251199d,bottom: 0.18940250883637955d,left: 0.27429922534744555d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6489463967596918d,right: 0.6758071595875504d,bottom: 0.175373352517754d,left: 0.6176659854959002d),

new NpgsqlTypes.NpgsqlBox(top: 0.5233570043087666d,right: 0.5323651762178377d,bottom: 0.0034512544348653806d,left: 0.4524292301573075d),

new NpgsqlTypes.NpgsqlBox(top: 0.9138147134995375d,right: 0.2720890806733146d,bottom: 0.45963511761870923d,left: 0.22208203968245843d),

new NpgsqlTypes.NpgsqlBox(top: 0.2826707559197209d,right: 0.6449187389010834d,bottom: 0.088284509708214d,left: 0.6101289968898698d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5309434501765504d,right: 0.8759057359814162d,bottom: 0.25859697738625587d,left: 0.6398474099663567d),

new NpgsqlTypes.NpgsqlBox(top: 0.8370702387898705d,right: 0.555775064250269d,bottom: 0.16221065344287822d,left: 0.3299386356759224d),

new NpgsqlTypes.NpgsqlBox(top: 0.998438299474439d,right: 0.6792239665813484d,bottom: 0.12692822583815988d,left: 0.6463705441392117d),

new NpgsqlTypes.NpgsqlBox(top: 0.9416088660247676d,right: 0.5913041361521924d,bottom: 0.20866773763049762d,left: 0.15887906883953662d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6784858961467057d,right: 0.22713381676835043d,bottom: 0.2651858116307676d,left: 0.18968390983688965d),

new NpgsqlTypes.NpgsqlBox(top: 0.07510247986007978d,right: 0.7819190066645652d,bottom: 0.06521235833514749d,left: 0.3697652900736623d),

new NpgsqlTypes.NpgsqlBox(top: 0.9129682823504683d,right: 0.8531259911333086d,bottom: 0.14447174455006073d,left: 0.7822094026829148d),

new NpgsqlTypes.NpgsqlBox(top: 0.5711302009930189d,right: 0.7333593122471288d,bottom: 0.35629822492870766d,left: 0.3921520164661043d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.38174721955776536d,right: 0.8860984587917914d,bottom: 0.20317089670596167d,left: 0.14964280915893313d),

new NpgsqlTypes.NpgsqlBox(top: 0.999588725188618d,right: 0.7661669184166066d,bottom: 0.7616059808845289d,left: 0.33652277869316194d),

new NpgsqlTypes.NpgsqlBox(top: 0.4353354698844224d,right: 0.5275338687050692d,bottom: 0.4018502868049919d,left: 0.360973666519126d),

new NpgsqlTypes.NpgsqlBox(top: 0.461639481580264d,right: 0.35110962900262777d,bottom: 0.3449826574493625d,left: 0.06500563747317789d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6873044699066987d,right: 0.6984661941506066d,bottom: 0.47022231435562456d,left: 0.06195813590491195d),

new NpgsqlTypes.NpgsqlBox(top: 0.8741680436573713d,right: 0.6693000643401383d,bottom: 0.7943846181716964d,left: 0.6457684651765107d),

new NpgsqlTypes.NpgsqlBox(top: 0.2932864438105426d,right: 0.3810316668513446d,bottom: 0.021424378645826803d,left: 0.08132366372039324d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7460798826687052d,right: 0.6979331432630214d,bottom: 0.4883134449808485d,left: 0.05686916802526942d),

new NpgsqlTypes.NpgsqlBox(top: 0.7618573150473749d,right: 0.3383946283993081d,bottom: 0.2368604562804375d,left: 0.05435549944585061d),

new NpgsqlTypes.NpgsqlBox(top: 0.8779907565828339d,right: 0.794485841143358d,bottom: 0.1828692980538118d,left: 0.14707660426441893d),

new NpgsqlTypes.NpgsqlBox(top: 0.9524761586969344d,right: 0.5680775819533678d,bottom: 0.19848789893425334d,left: 0.4946967188148379d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4713174781107984d,right: 0.757667258537798d,bottom: 0.31588100996283086d,left: 0.30630056077408807d),

new NpgsqlTypes.NpgsqlBox(top: 0.9454594819514274d,right: 0.9446041561816452d,bottom: 0.8321200476736804d,left: 0.6856262239884701d),

new NpgsqlTypes.NpgsqlBox(top: 0.802163166254124d,right: 0.3900078795526798d,bottom: 0.2891040995033278d,left: 0.18820703918032056d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25485930818020275d,right: 0.9350709527970559d,bottom: 0.07034743587983883d,left: 0.0985475154077331d),

new NpgsqlTypes.NpgsqlBox(top: 0.7233169707989122d,right: 0.979240719660253d,bottom: 0.49123985567736683d,left: 0.17998069905141212d),

new NpgsqlTypes.NpgsqlBox(top: 0.41760439422630613d,right: 0.21340187394762788d,bottom: 0.03629905328961458d,left: 0.0694598335545038d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.60657413594517d,right: 0.743920336679607d,bottom: 0.037216710276179454d,left: 0.6084782984436615d),

new NpgsqlTypes.NpgsqlBox(top: 0.713488427791762d,right: 0.6391096412622063d,bottom: 0.6978040925227473d,left: 0.45187938867583255d),

new NpgsqlTypes.NpgsqlBox(top: 0.9436277087542427d,right: 0.4215504445899827d,bottom: 0.48995116639207426d,left: 0.24361331017656196d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6719974509267271d,right: 0.8777637403110327d,bottom: 0.5812539200858445d,left: 0.2631580367085754d),

new NpgsqlTypes.NpgsqlBox(top: 0.9394262970121278d,right: 0.7074567395539229d,bottom: 0.43212279462219827d,left: 0.5246771265548618d),

new NpgsqlTypes.NpgsqlBox(top: 0.333479409434133d,right: 0.8197904480917417d,bottom: 0.20623173067654887d,left: 0.06416970592125337d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6478612138908537d,right: 0.773586093237171d,bottom: 0.474852233613721d,left: 0.4095381498244849d),

new NpgsqlTypes.NpgsqlBox(top: 0.5384186728292115d,right: 0.8816019597422402d,bottom: 0.2626122149489445d,left: 0.6893675494617066d),

new NpgsqlTypes.NpgsqlBox(top: 0.9259041801861744d,right: 0.6327642192121713d,bottom: 0.08057983293897686d,left: 0.370108848303481d),

new NpgsqlTypes.NpgsqlBox(top: 0.6930619492303416d,right: 0.2689682701208258d,bottom: 0.25585052152332066d,left: 0.16599763628509434d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5974476930013369d,right: 0.8939383029469218d,bottom: 0.3450607301992301d,left: 0.6673110553367804d),

new NpgsqlTypes.NpgsqlBox(top: 0.7465112829654713d,right: 0.6245421190669306d,bottom: 0.25595059612112137d,left: 0.33776633724290606d),

new NpgsqlTypes.NpgsqlBox(top: 0.9612929384558127d,right: 0.7462107620147771d,bottom: 0.838504891539677d,left: 0.2735665407337624d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8552964325930533d,right: 0.5338478580907046d,bottom: 0.5496186326057807d,left: 0.3286135253040655d),

new NpgsqlTypes.NpgsqlBox(top: 0.9680630144072508d,right: 0.5892713354780007d,bottom: 0.8646402108667909d,left: 0.38996770551571647d),

new NpgsqlTypes.NpgsqlBox(top: 0.7130754318377411d,right: 0.8464268311770682d,bottom: 0.19667752523958792d,left: 0.6894509089771359d),

new NpgsqlTypes.NpgsqlBox(top: 0.6803270513799156d,right: 0.9193270178776739d,bottom: 0.5949990448975662d,left: 0.02963364516593825d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47330876539380096d,right: 0.6614669447971278d,bottom: 0.10017958481262923d,left: 0.30291821964803334d),

new NpgsqlTypes.NpgsqlBox(top: 0.7479362101102798d,right: 0.7481390750852228d,bottom: 0.5983937781803058d,left: 0.12550023417029044d),

new NpgsqlTypes.NpgsqlBox(top: 0.9788080231351056d,right: 0.18435304758801196d,bottom: 0.10819424609932737d,left: 0.1430803154960849d),

new NpgsqlTypes.NpgsqlBox(top: 0.7973384364597038d,right: 0.9768145955413119d,bottom: 0.5955878780725323d,left: 0.3832678672905454d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42555500692756176d,right: 0.1885873583415424d,bottom: 0.04424287014237227d,left: 0.1737829821297341d),

new NpgsqlTypes.NpgsqlBox(top: 0.5423355657201029d,right: 0.7614585083268997d,bottom: 0.11220715144430438d,left: 0.7413586914777258d),

new NpgsqlTypes.NpgsqlBox(top: 0.9994229650839475d,right: 0.7732668073245182d,bottom: 0.7272789500213676d,left: 0.04313463789115901d),

new NpgsqlTypes.NpgsqlBox(top: 0.7413093962836709d,right: 0.6594410251994791d,bottom: 0.4182504671714654d,left: 0.413963862582852d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5280507851169691d,right: 0.3570524457914068d,bottom: 0.359895819421309d,left: 0.22554336610702164d),

new NpgsqlTypes.NpgsqlBox(top: 0.929833752157029d,right: 0.9644925211173678d,bottom: 0.8573958159571236d,left: 0.12407621280322256d),

new NpgsqlTypes.NpgsqlBox(top: 0.21871654142466057d,right: 0.23859665778637218d,bottom: 0.0018893667909399836d,left: 0.11205844868511561d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7711196419916125d,right: 0.900369527749199d,bottom: 0.4829126266323185d,left: 0.4786619598987891d),

new NpgsqlTypes.NpgsqlBox(top: 0.641942864328804d,right: 0.9063387435374679d,bottom: 0.47697529199455035d,left: 0.138450389142863d),

new NpgsqlTypes.NpgsqlBox(top: 0.6542769231506752d,right: 0.7333325461119782d,bottom: 0.08886779460990268d,left: 0.6188630621933096d),

new NpgsqlTypes.NpgsqlBox(top: 0.9577976824270423d,right: 0.9007362601413402d,bottom: 0.09315188089426019d,left: 0.10834916431062036d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9058192787846403d,right: 0.9678246398339256d,bottom: 0.21917975297141612d,left: 0.0765719014421804d),

new NpgsqlTypes.NpgsqlBox(top: 0.8814437627802689d,right: 0.9146705833528076d,bottom: 0.23531583907884268d,left: 0.15756912468158213d),

new NpgsqlTypes.NpgsqlBox(top: 0.801171891237907d,right: 0.6161772610187631d,bottom: 0.7545729361963941d,left: 0.1880695953010082d),

new NpgsqlTypes.NpgsqlBox(top: 0.5078914629386381d,right: 0.3381314588260389d,bottom: 0.45872272045423135d,left: 0.18474517927524858d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3053433487936673d,right: 0.692047436413065d,bottom: 0.2636214181693348d,left: 0.3531150396103775d),

new NpgsqlTypes.NpgsqlBox(top: 0.25355096292970714d,right: 0.2477327159012237d,bottom: 0.19233534285869958d,left: 0.124475657614877d),

new NpgsqlTypes.NpgsqlBox(top: 0.41393608089979095d,right: 0.8753095184643481d,bottom: 0.06596879931729938d,left: 0.4854639558399525d),

new NpgsqlTypes.NpgsqlBox(top: 0.06162783477983236d,right: 0.3414002371160726d,bottom: 0.059132641734893854d,left: 0.16627482532703441d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5519875588254354d,right: 0.4366287693669101d,bottom: 0.36967741061764414d,left: 0.4081564006520705d),

new NpgsqlTypes.NpgsqlBox(top: 0.42304734867523075d,right: 0.8876784631375082d,bottom: 0.19618956915224028d,left: 0.6690969503508859d),

new NpgsqlTypes.NpgsqlBox(top: 0.7937004515930322d,right: 0.6449448006206305d,bottom: 0.1521546370032748d,left: 0.5589144760741825d),

new NpgsqlTypes.NpgsqlBox(top: 0.806474664084302d,right: 0.9737625344622108d,bottom: 0.7742653448616024d,left: 0.23732843497485523d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.573267095496882d,right: 0.5981607152564037d,bottom: 0.20842569113176168d,left: 0.44851408556794536d),

new NpgsqlTypes.NpgsqlBox(top: 0.8498302695955601d,right: 0.7442282727886904d,bottom: 0.6662650706804959d,left: 0.5998376244319765d),

new NpgsqlTypes.NpgsqlBox(top: 0.9112568994249021d,right: 0.6334523100353655d,bottom: 0.20828470249854159d,left: 0.4285421033408733d),

new NpgsqlTypes.NpgsqlBox(top: 0.8104599695205665d,right: 0.523705323315841d,bottom: 0.6762474968111767d,left: 0.09300361601655038d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7219465967285575d,right: 0.48019849439922135d,bottom: 0.0958168113244221d,left: 0.35181925062541675d),

new NpgsqlTypes.NpgsqlBox(top: 0.4314404911018642d,right: 0.9533587195069627d,bottom: 0.421212902007311d,left: 0.6718383567021353d),

new NpgsqlTypes.NpgsqlBox(top: 0.48586723365062245d,right: 0.685078094582684d,bottom: 0.280479125745546d,left: 0.4150903758965562d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6541250695655785d,right: 0.9803058132944305d,bottom: 0.13732915388732236d,left: 0.4972374565466955d),

new NpgsqlTypes.NpgsqlBox(top: 0.8082277546093404d,right: 0.4846741392522528d,bottom: 0.6891686545523715d,left: 0.044549018616041325d),

new NpgsqlTypes.NpgsqlBox(top: 0.6530346939758672d,right: 0.24766936732545863d,bottom: 0.32143793704583057d,left: 0.08986070463311513d),

new NpgsqlTypes.NpgsqlBox(top: 0.6220850683424314d,right: 0.5587065997393099d,bottom: 0.2725866664527712d,left: 0.5102485101957482d),

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
new NpgsqlTypes.NpgsqlBox(top: 0.8758962846800813d,right: 0.49474181093105196d,bottom: 0.6338968406394285d,left: 0.1315137196249374d),

new NpgsqlTypes.NpgsqlBox(top: 0.9067945600182513d,right: 0.8169089218720816d,bottom: 0.8306918535048493d,left: 0.6251120993895056d),

new NpgsqlTypes.NpgsqlBox(top: 0.6874577974652507d,right: 0.6171066535495656d,bottom: 0.40548352971551904d,left: 0.06599310242837919d),

new NpgsqlTypes.NpgsqlBox(top: 0.800589020867517d,right: 0.4557146119209948d,bottom: 0.05783941797644154d,left: 0.14487985524649616d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2077805793194929d,right: 0.7456370335996957d,bottom: 0.022984306007007294d,left: 0.6181537892298365d),

new NpgsqlTypes.NpgsqlBox(top: 0.9465101207686252d,right: 0.7130223904602369d,bottom: 0.9450400039138415d,left: 0.5846696677210939d),

new NpgsqlTypes.NpgsqlBox(top: 0.6652859721424255d,right: 0.2848494369482296d,bottom: 0.335721557400498d,left: 0.16313489615157106d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8059731406441945d,right: 0.7500464436635123d,bottom: 0.3440805495578483d,left: 0.5158586311442492d),

new NpgsqlTypes.NpgsqlBox(top: 0.6593075027370631d,right: 0.8382026919250971d,bottom: 0.18863087051257377d,left: 0.4030837827087832d),

new NpgsqlTypes.NpgsqlBox(top: 0.9388786996961948d,right: 0.8530198323127782d,bottom: 0.3600332270415393d,left: 0.2581376490620897d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.35959117169438726d,right: 0.9523142153519677d,bottom: 0.31372720783355124d,left: 0.5426165248872887d),

new NpgsqlTypes.NpgsqlBox(top: 0.9237128583170938d,right: 0.8469767243145041d,bottom: 0.7312930945020156d,left: 0.2952907902986288d),

new NpgsqlTypes.NpgsqlBox(top: 0.7172640147761596d,right: 0.8874300976815009d,bottom: 0.19046096543950897d,left: 0.4249839295772345d),

new NpgsqlTypes.NpgsqlBox(top: 0.3927954992001973d,right: 0.9569398097585803d,bottom: 0.30075116347208475d,left: 0.9277953019883548d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.91883076335697d,right: 0.25592335963503376d,bottom: 0.26717679184371745d,left: 0.10196601791442894d),

new NpgsqlTypes.NpgsqlBox(top: 0.951893562406325d,right: 0.20575501100287374d,bottom: 0.12038225219142662d,left: 0.002790147230588569d),

new NpgsqlTypes.NpgsqlBox(top: 0.1874848945173445d,right: 0.5319606713134054d,bottom: 0.12665325948569428d,left: 0.1475901640992151d),

new NpgsqlTypes.NpgsqlBox(top: 0.6470867563221192d,right: 0.9805841742348199d,bottom: 0.06948601427212064d,left: 0.6409918026531427d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.950359214058978d,right: 0.47103665240248593d,bottom: 0.5272417718352949d,left: 0.3247481026992818d),

new NpgsqlTypes.NpgsqlBox(top: 0.8496603791151731d,right: 0.9168044730588275d,bottom: 0.6752690849778925d,left: 0.023335550681931605d),

new NpgsqlTypes.NpgsqlBox(top: 0.9722917255716822d,right: 0.14225476856569785d,bottom: 0.2236213593107963d,left: 0.10966444148899035d),

new NpgsqlTypes.NpgsqlBox(top: 0.7324159991600562d,right: 0.7193035771988633d,bottom: 0.5829404632596393d,left: 0.33223211161297783d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8329223079828796d,right: 0.12160434639234907d,bottom: 0.3496973645439183d,left: 0.061454682574370256d),

new NpgsqlTypes.NpgsqlBox(top: 0.9287223384182256d,right: 0.9062157676346514d,bottom: 0.6745761450906411d,left: 0.521380433474299d),

new NpgsqlTypes.NpgsqlBox(top: 0.8709620976892645d,right: 0.9931263623273879d,bottom: 0.11574544617158344d,left: 0.18158046989479126d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4773180126114184d,right: 0.1357735703788806d,bottom: 0.20776815257182435d,left: 0.09345468340004137d),

new NpgsqlTypes.NpgsqlBox(top: 0.5369518319849619d,right: 0.7690964725013786d,bottom: 0.2733049294374559d,left: 0.5518923955064566d),

new NpgsqlTypes.NpgsqlBox(top: 0.8714648788034783d,right: 0.9317819183223399d,bottom: 0.2568981421197344d,left: 0.7851695080223368d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6880553755097634d,right: 0.9446752421099911d,bottom: 0.5552214822783961d,left: 0.46813335817736157d),

new NpgsqlTypes.NpgsqlBox(top: 0.7788005316589939d,right: 0.9308925355754114d,bottom: 0.5467186570752759d,left: 0.751692963115797d),

new NpgsqlTypes.NpgsqlBox(top: 0.8333709039584486d,right: 0.5140896241994838d,bottom: 0.4180248540317568d,left: 0.20435865656558672d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7539937965751078d,right: 0.25542748780510327d,bottom: 0.07568517732551971d,left: 0.10169793058076859d),

new NpgsqlTypes.NpgsqlBox(top: 0.8371205243041986d,right: 0.9349815347312367d,bottom: 0.680544931521175d,left: 0.8668216311101916d),

new NpgsqlTypes.NpgsqlBox(top: 0.8992326131537197d,right: 0.5817476784261975d,bottom: 0.5080035311160568d,left: 0.27443871217812776d),

new NpgsqlTypes.NpgsqlBox(top: 0.8497408903292111d,right: 0.44287152005754504d,bottom: 0.64049474521379d,left: 0.19807472086353517d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.40326553733439263d,right: 0.42783202098695783d,bottom: 0.026429288770864034d,left: 0.2970351471179883d),

new NpgsqlTypes.NpgsqlBox(top: 0.6481438466411014d,right: 0.9280427188037261d,bottom: 0.6050369146482689d,left: 0.2685700981766189d),

new NpgsqlTypes.NpgsqlBox(top: 0.6306273970197819d,right: 0.286528455790954d,bottom: 0.21100837921554827d,left: 0.27612550677220105d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8235212802241902d,right: 0.7703997231242018d,bottom: 0.5695722482733756d,left: 0.02939502133509897d),

new NpgsqlTypes.NpgsqlBox(top: 0.9731170092685408d,right: 0.22820421976236505d,bottom: 0.18808278743355877d,left: 0.12169189828819948d),

new NpgsqlTypes.NpgsqlBox(top: 0.62481163273795d,right: 0.29447368907017957d,bottom: 0.6145162637334569d,left: 0.11643237973787168d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4851369204826629d,right: 0.5713257593454337d,bottom: 0.2014362766778761d,left: 0.10515634708898602d),

new NpgsqlTypes.NpgsqlBox(top: 0.715929968510018d,right: 0.9536994517578026d,bottom: 0.581760446158302d,left: 0.08101097126145906d),

new NpgsqlTypes.NpgsqlBox(top: 0.8899629423989643d,right: 0.7106716497870535d,bottom: 0.6197261694926699d,left: 0.20536352942487235d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8153688303015639d,right: 0.6803229491522754d,bottom: 0.7601839056258411d,left: 0.42106370888288347d),

new NpgsqlTypes.NpgsqlBox(top: 0.6842596254248969d,right: 0.3086666364759669d,bottom: 0.04319952009087935d,left: 0.006361851645231953d),

new NpgsqlTypes.NpgsqlBox(top: 0.7614712468950284d,right: 0.9547852712742413d,bottom: 0.4052993728306029d,left: 0.3052032168164961d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8073512736676556d,right: 0.6898069747365043d,bottom: 0.4242090551639359d,left: 0.267781432014077d),

new NpgsqlTypes.NpgsqlBox(top: 0.9927507860446719d,right: 0.5035390019452677d,bottom: 0.7920476020950753d,left: 0.4534096003489225d),

new NpgsqlTypes.NpgsqlBox(top: 0.4532985183978785d,right: 0.8286571615627745d,bottom: 0.3613137135234745d,left: 0.4491223632952088d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49449201770920337d,right: 0.42781274575115436d,bottom: 0.27641643893814993d,left: 0.0697956408234155d),

new NpgsqlTypes.NpgsqlBox(top: 0.6070860606371553d,right: 0.6720571459024745d,bottom: 0.5905624814088654d,left: 0.22891996407149873d),

new NpgsqlTypes.NpgsqlBox(top: 0.01321636997569997d,right: 0.7080990156672272d,bottom: 0.008795418474740635d,left: 0.05962967543981201d),

new NpgsqlTypes.NpgsqlBox(top: 0.2509199953550243d,right: 0.6314957657529712d,bottom: 0.18742324782038455d,left: 0.6212094238353699d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7422237236175938d,right: 0.6027887324497966d,bottom: 0.3840559141731007d,left: 0.3515398122501273d),

new NpgsqlTypes.NpgsqlBox(top: 0.5515755012409043d,right: 0.8212168525566814d,bottom: 0.43922174073519005d,left: 0.3657017585857948d),

new NpgsqlTypes.NpgsqlBox(top: 0.6775238234625608d,right: 0.7996380268257675d,bottom: 0.047392396149565585d,left: 0.6184124382411016d),

new NpgsqlTypes.NpgsqlBox(top: 0.5297500411437969d,right: 0.9989587180743126d,bottom: 0.42557495152432623d,left: 0.7497219030726426d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7811794112347963d,right: 0.5648550207149646d,bottom: 0.6709629963011812d,left: 0.031910137959785256d),

new NpgsqlTypes.NpgsqlBox(top: 0.4462493143908062d,right: 0.3410442340414659d,bottom: 0.14113436806457824d,left: 0.1714562598853394d),

new NpgsqlTypes.NpgsqlBox(top: 0.7635965707646847d,right: 0.7717084681645662d,bottom: 0.7521807715401078d,left: 0.32035642598582115d),

new NpgsqlTypes.NpgsqlBox(top: 0.5927179832167735d,right: 0.31200727757593594d,bottom: 0.026012687970819792d,left: 0.2669942334510622d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.26291775521344163d,right: 0.2727060613827511d,bottom: 0.24000135715979376d,left: 0.14192405871807967d),

new NpgsqlTypes.NpgsqlBox(top: 0.9680759767825196d,right: 0.936519004410942d,bottom: 0.2689761026980019d,left: 0.21768978836399333d),

new NpgsqlTypes.NpgsqlBox(top: 0.6598272853699575d,right: 0.836654262053599d,bottom: 0.5382509409668241d,left: 0.131405054917351d),

new NpgsqlTypes.NpgsqlBox(top: 0.9252570507303434d,right: 0.6607495399455433d,bottom: 0.02544213686592922d,left: 0.09955197547367312d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5871199975689594d,right: 0.8412851240496043d,bottom: 0.16412862966462216d,left: 0.054387809297044676d),

new NpgsqlTypes.NpgsqlBox(top: 0.7094567797798569d,right: 0.9092262599899359d,bottom: 0.21606850272999056d,left: 0.406157322063765d),

new NpgsqlTypes.NpgsqlBox(top: 0.6626469270306532d,right: 0.24583602012923655d,bottom: 0.525484912233509d,left: 0.08970403394454729d),

new NpgsqlTypes.NpgsqlBox(top: 0.911444398340203d,right: 0.8877447432377298d,bottom: 0.0925751493319702d,left: 0.5879103232843405d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9281551390076227d,right: 0.9941813511428923d,bottom: 0.48312030492380575d,left: 0.4517070571466286d),

new NpgsqlTypes.NpgsqlBox(top: 0.4130996239613641d,right: 0.8509941434730517d,bottom: 0.2517573606248885d,left: 0.8188413766329223d),

new NpgsqlTypes.NpgsqlBox(top: 0.9577485640857678d,right: 0.9610274794748362d,bottom: 0.8253053630013749d,left: 0.8348734863245781d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6885291362851774d,right: 0.9535671214623332d,bottom: 0.21779289083325193d,left: 0.18380479250388793d),

new NpgsqlTypes.NpgsqlBox(top: 0.6631363167368685d,right: 0.13545280730919718d,bottom: 0.3366822058716844d,left: 0.03137098784557524d),

new NpgsqlTypes.NpgsqlBox(top: 0.6836608588339923d,right: 0.6337596870872906d,bottom: 0.23468311728445967d,left: 0.6329269435391223d),

new NpgsqlTypes.NpgsqlBox(top: 0.8857516199427562d,right: 0.9141348132064723d,bottom: 0.4183841801309466d,left: 0.018732284589641823d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.837531457329918d,right: 0.4682737642529181d,bottom: 0.5720548597015928d,left: 0.034636651203605484d),

new NpgsqlTypes.NpgsqlBox(top: 0.7510869035844284d,right: 0.9742493270938851d,bottom: 0.3027881648248729d,left: 0.6618271831562119d),

new NpgsqlTypes.NpgsqlBox(top: 0.799215961116706d,right: 0.6583454262661623d,bottom: 0.7140340131267794d,left: 0.268186854446829d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.589327073255298d,right: 0.9016367446247103d,bottom: 0.43022981974763663d,left: 0.4618383473115967d),

new NpgsqlTypes.NpgsqlBox(top: 0.8248111804085864d,right: 0.4547287863194056d,bottom: 0.24015767953767175d,left: 0.2563068039716667d),

new NpgsqlTypes.NpgsqlBox(top: 0.5711363206447563d,right: 0.44810676542578687d,bottom: 0.06143326820440831d,left: 0.07925126568683638d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5381490810718018d,right: 0.6189874228529968d,bottom: 0.0933757710994656d,left: 0.11654416561881586d),

new NpgsqlTypes.NpgsqlBox(top: 0.4580051568102924d,right: 0.47371329390892236d,bottom: 0.2304932675703737d,left: 0.2639193347991493d),

new NpgsqlTypes.NpgsqlBox(top: 0.9170426770241585d,right: 0.7660974197513394d,bottom: 0.018570507334630504d,left: 0.6250136291885549d),

new NpgsqlTypes.NpgsqlBox(top: 0.4735688380010431d,right: 0.9002556489903977d,bottom: 0.14057819417655026d,left: 0.2583978164275045d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9490878265211702d,right: 0.9919081939414323d,bottom: 0.23689654120294434d,left: 0.23683344394874428d),

new NpgsqlTypes.NpgsqlBox(top: 0.9551519652460282d,right: 0.648462055102377d,bottom: 0.15532720238473818d,left: 0.10232829233235108d),

new NpgsqlTypes.NpgsqlBox(top: 0.7639387315955621d,right: 0.6260457168252005d,bottom: 0.04954120650280669d,left: 0.4619076791339374d),

new NpgsqlTypes.NpgsqlBox(top: 0.7264375308358125d,right: 0.24901412291783287d,bottom: 0.645468859975785d,left: 0.20556936241460588d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.16045581863862413d,right: 0.26023358546620246d,bottom: 0.03211671342326605d,left: 0.013021966993176814d),

new NpgsqlTypes.NpgsqlBox(top: 0.5450899887374785d,right: 0.6967534861600488d,bottom: 0.08997428262457052d,left: 0.6754892383484341d),

new NpgsqlTypes.NpgsqlBox(top: 0.9070280774383843d,right: 0.8756547719112903d,bottom: 0.7438068223884239d,left: 0.42139650120840133d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7602187550499109d,right: 0.9141608604849507d,bottom: 0.6869866593647025d,left: 0.7304664199115295d),

new NpgsqlTypes.NpgsqlBox(top: 0.9617965968290637d,right: 0.7749628712414887d,bottom: 0.512004852525347d,left: 0.7377394833941624d),

new NpgsqlTypes.NpgsqlBox(top: 0.7400123849669923d,right: 0.4061164386652121d,bottom: 0.3931451976092656d,left: 0.21464711370253486d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.56207105066783d,right: 0.9390178932672871d,bottom: 0.5526763926995377d,left: 0.547599630892353d),

new NpgsqlTypes.NpgsqlBox(top: 0.9855103211981068d,right: 0.2608359951096998d,bottom: 0.5247916518098732d,left: 0.03599127062367391d),

new NpgsqlTypes.NpgsqlBox(top: 0.7011508933195801d,right: 0.38013399370537027d,bottom: 0.1440830326910475d,left: 0.1975171648372973d),

new NpgsqlTypes.NpgsqlBox(top: 0.8917453559912287d,right: 0.2770570778373286d,bottom: 0.8462326685651342d,left: 0.0791106906218062d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8897045211032175d,right: 0.43264304873165105d,bottom: 0.40262927471446597d,left: 0.4085511518488213d),

new NpgsqlTypes.NpgsqlBox(top: 0.5806062868572233d,right: 0.8214930806249575d,bottom: 0.39771453189028005d,left: 0.747094592582395d),

new NpgsqlTypes.NpgsqlBox(top: 0.8882561926563884d,right: 0.9768076389387081d,bottom: 0.4244754973326651d,left: 0.9537679589853161d),

new NpgsqlTypes.NpgsqlBox(top: 0.38919145802568533d,right: 0.8083226371424947d,bottom: 0.09004835568814418d,left: 0.31092136488930977d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6263185527781756d,right: 0.6050276037739625d,bottom: 0.07054387080556712d,left: 0.34014987883018255d),

new NpgsqlTypes.NpgsqlBox(top: 0.9237196173618005d,right: 0.9019114442121867d,bottom: 0.8983365883107058d,left: 0.866142681327742d),

new NpgsqlTypes.NpgsqlBox(top: 0.3050159062761276d,right: 0.8123101856920402d,bottom: 0.003310307740077678d,left: 0.3998545736044463d),

new NpgsqlTypes.NpgsqlBox(top: 0.924760467393717d,right: 0.7945447254461787d,bottom: 0.6689020754904388d,left: 0.16762376303175996d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.38325720125017526d,right: 0.9029327213502732d,bottom: 0.21363989020485707d,left: 0.3921093182333061d),

new NpgsqlTypes.NpgsqlBox(top: 0.8769530678314362d,right: 0.6864112409587246d,bottom: 0.21762812199115744d,left: 0.4874994787204733d),

new NpgsqlTypes.NpgsqlBox(top: 0.5389767917351896d,right: 0.8260232571166838d,bottom: 0.40436238266571833d,left: 0.3655590362812774d),

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 35, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 38, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                int resultIndex = 0;
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 12, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 59, query1, 115, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                int resultIndex = 0;
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 85, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 59, 38))
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 85, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
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

